//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SearchPhrase.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace VirtoCommerce.SearchModule.Data.Services.SearchPhraseParsing.Antlr {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISearchPhraseListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class SearchPhraseBaseListener : ISearchPhraseListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.searchPhrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSearchPhrase([NotNull] SearchPhraseParser.SearchPhraseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.searchPhrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSearchPhrase([NotNull] SearchPhraseParser.SearchPhraseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.phrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPhrase([NotNull] SearchPhraseParser.PhraseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.phrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPhrase([NotNull] SearchPhraseParser.PhraseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] SearchPhraseParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] SearchPhraseParser.KeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.filter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilter([NotNull] SearchPhraseParser.FilterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.filter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilter([NotNull] SearchPhraseParser.FilterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.fieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldName([NotNull] SearchPhraseParser.FieldNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.fieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldName([NotNull] SearchPhraseParser.FieldNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.attributeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributeFilterValue([NotNull] SearchPhraseParser.AttributeFilterValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.attributeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributeFilterValue([NotNull] SearchPhraseParser.AttributeFilterValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SearchPhraseParser.rangeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRangeFilterValue([NotNull] SearchPhraseParser.RangeFilterValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SearchPhraseParser.rangeFilterValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRangeFilterValue([NotNull] SearchPhraseParser.RangeFilterValueContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace VirtoCommerce.SearchModule.Data.Services.SearchPhraseParsing.Antlr