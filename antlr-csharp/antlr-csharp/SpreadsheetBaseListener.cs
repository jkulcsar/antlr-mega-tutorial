//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from P:/source/repos/antlr-mega-tutorial/antlr-csharp/antlr-csharp\Spreadsheet.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISpreadsheetListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class SpreadsheetBaseListener : ISpreadsheetListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>numericAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericAtomExp([NotNull] SpreadsheetParser.NumericAtomExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numericAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericAtomExp([NotNull] SpreadsheetParser.NumericAtomExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>powerExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPowerExp([NotNull] SpreadsheetParser.PowerExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>powerExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPowerExp([NotNull] SpreadsheetParser.PowerExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDivExp([NotNull] SpreadsheetParser.MulDivExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDivExp([NotNull] SpreadsheetParser.MulDivExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesisExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisExp([NotNull] SpreadsheetParser.ParenthesisExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesisExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisExp([NotNull] SpreadsheetParser.ParenthesisExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>idAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdAtomExp([NotNull] SpreadsheetParser.IdAtomExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>idAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdAtomExp([NotNull] SpreadsheetParser.IdAtomExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>addSubExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSubExp([NotNull] SpreadsheetParser.AddSubExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>addSubExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSubExp([NotNull] SpreadsheetParser.AddSubExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>functionExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionExp([NotNull] SpreadsheetParser.FunctionExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>functionExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionExp([NotNull] SpreadsheetParser.FunctionExpContext context) { }

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
