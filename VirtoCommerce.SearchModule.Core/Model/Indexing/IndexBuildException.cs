﻿using System;

namespace VirtoCommerce.SearchModule.Core.Model.Indexing
{
    public class IndexBuildException : SearchException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexBuildException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public IndexBuildException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexBuildException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public IndexBuildException(string message)
            : base(message)
        {
        }
    }
}
