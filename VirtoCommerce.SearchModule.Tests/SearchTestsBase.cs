﻿using System;
using System.IO;
using System.Linq;
using Moq;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.Settings;
using VirtoCommerce.SearchModule.Core.Model;
using VirtoCommerce.SearchModule.Core.Model.Filters;
using VirtoCommerce.SearchModule.Core.Model.Indexing;
using VirtoCommerce.SearchModule.Core.Model.Search;
using VirtoCommerce.SearchModule.Data.Providers.AzureSearch;
using VirtoCommerce.SearchModule.Data.Providers.ElasticSearch;
using VirtoCommerce.SearchModule.Data.Providers.LuceneSearch;
using VirtoCommerce.SearchModule.Data.Services;
using VirtoCommerce.SearchModule.Data.Services.SearchPhraseParsing;

namespace VirtoCommerce.SearchModule.Test
{
    public class SearchTestsBase : IDisposable
    {
        private readonly string _luceneStorageDir = Path.Combine(Path.GetTempPath(), "lucene");

        protected ISearchProvider GetSearchProvider(string searchProvider, string scope)
        {
            ISearchProvider provider = null;

            var phraseSearchCriteriaPreprocessor = new PhraseSearchCriteriaPreprocessor(new SearchPhraseParser());
            var searchCriteriaPreprocessors = new[] { (ISearchCriteriaPreprocessor)phraseSearchCriteriaPreprocessor };

            if (searchProvider == "Lucene")
            {
                var connection = new SearchConnection(_luceneStorageDir, scope);
                var queryBuilder = new LuceneSearchQueryBuilder() as ISearchQueryBuilder;
                provider = new LuceneSearchProvider(new[] { queryBuilder }, connection, searchCriteriaPreprocessors);
            }

            if (searchProvider == "Elastic")
            {
                var elasticsearchHost = Environment.GetEnvironmentVariable("TestElasticsearchHost") ?? "localhost:9200";

                var connection = new SearchConnection(elasticsearchHost, scope);
                var queryBuilder = new ElasticSearchQueryBuilder() as ISearchQueryBuilder;
                provider = new ElasticSearchProvider(connection, searchCriteriaPreprocessors, new[] { queryBuilder }, GetSettingsManager()) { EnableTrace = true };
            }

            if (searchProvider == "Azure")
            {
                var azureSearchServiceName = Environment.GetEnvironmentVariable("TestAzureSearchServiceName");
                var azureSearchAccessKey = Environment.GetEnvironmentVariable("TestAzureSearchAccessKey");

                var connection = new SearchConnection(azureSearchServiceName, scope, accessKey: azureSearchAccessKey);
                var queryBuilder = new AzureSearchQueryBuilder() as ISearchQueryBuilder;
                provider = new AzureSearchProvider(connection, searchCriteriaPreprocessors, new[] { queryBuilder }, GetSettingsManager());
            }

            if (provider == null)
                throw new ArgumentException($"Search provider '{searchProvider}' is not supported", nameof(searchProvider));

            return provider;
        }

        protected ISettingsManager GetSettingsManager()
        {
            var mock = new Mock<ISettingsManager>();

            mock.Setup(s => s.GetValue(It.IsAny<string>(), It.IsAny<string>())).Returns((string name, string defaultValue) => defaultValue);
            mock.Setup(s => s.GetValue(It.IsAny<string>(), It.IsAny<bool>())).Returns((string name, bool defaultValue) => defaultValue);
            mock.Setup(s => s.GetValue(It.IsAny<string>(), It.IsAny<int>())).Returns((string name, int defaultValue) => defaultValue);

            return mock.Object;
        }

        protected virtual ISearchFilter CreateRangeFilter(string key, string lower, string upper, bool includeLower, bool includeUpper)
        {
            return new RangeFilter
            {
                Key = key,
                Values = new[]
                {
                    new RangeFilterValue
                    {
                        Lower = lower,
                        Upper = upper,
                        IncludeLower = includeLower,
                        IncludeUpper = includeUpper,
                    }
                },
            };
        }

        protected long GetFacetCount(ISearchResults<DocumentDictionary> results, string fieldName, string facetKey)
        {
            if (results.Facets == null || results.Facets.Count == 0)
            {
                return 0;
            }

            var group = results.Facets.SingleOrDefault(fg => fg.FieldName.EqualsInvariant(fieldName));

            return group?.Facets
                .Where(facet => facet.Key == facetKey)
                .Select(facet => facet.Count)
                .FirstOrDefault() ?? 0;
        }

        public virtual void Dispose()
        {
            try
            {
                if (Directory.Exists(_luceneStorageDir))
                    Directory.Delete(_luceneStorageDir, true);
            }
            catch
            {
                // ignored
            }
        }
    }
}
