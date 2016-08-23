//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Cerberus\Documents\Visual Studio 2015\Projects\MascaretWebGL\Dev\CS\Mascaret\Mascaret\VEHA\Kernel\OCLExpression.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Mascaret {

using System;
using System.Collections;
using System.Collections.Generic;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="OCLExpressionParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IOCLExpressionListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] OCLExpressionParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] OCLExpressionParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.relationaloperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationaloperator([NotNull] OCLExpressionParser.RelationaloperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.relationaloperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationaloperator([NotNull] OCLExpressionParser.RelationaloperatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.unaryoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryoperator([NotNull] OCLExpressionParser.UnaryoperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.unaryoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryoperator([NotNull] OCLExpressionParser.UnaryoperatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.numericalconstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericalconstant([NotNull] OCLExpressionParser.NumericalconstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.numericalconstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericalconstant([NotNull] OCLExpressionParser.NumericalconstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.additiveexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveexpression([NotNull] OCLExpressionParser.AdditiveexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.additiveexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveexpression([NotNull] OCLExpressionParser.AdditiveexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInteger([NotNull] OCLExpressionParser.IntegerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInteger([NotNull] OCLExpressionParser.IntegerContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.postfixexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixexpression([NotNull] OCLExpressionParser.PostfixexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.postfixexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixexpression([NotNull] OCLExpressionParser.PostfixexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.propertycall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertycall([NotNull] OCLExpressionParser.PropertycallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.propertycall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertycall([NotNull] OCLExpressionParser.PropertycallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.float"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] OCLExpressionParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.float"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] OCLExpressionParser.FloatContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.unaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryexpression([NotNull] OCLExpressionParser.UnaryexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.unaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryexpression([NotNull] OCLExpressionParser.UnaryexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.logicaloperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicaloperator([NotNull] OCLExpressionParser.LogicaloperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.logicaloperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicaloperator([NotNull] OCLExpressionParser.LogicaloperatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.primaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryexpression([NotNull] OCLExpressionParser.PrimaryexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.primaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryexpression([NotNull] OCLExpressionParser.PrimaryexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.multiplyoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplyoperator([NotNull] OCLExpressionParser.MultiplyoperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.multiplyoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplyoperator([NotNull] OCLExpressionParser.MultiplyoperatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.relationexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationexpression([NotNull] OCLExpressionParser.RelationexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.relationexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationexpression([NotNull] OCLExpressionParser.RelationexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.addoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddoperator([NotNull] OCLExpressionParser.AddoperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.addoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddoperator([NotNull] OCLExpressionParser.AddoperatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.logicalexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalexpression([NotNull] OCLExpressionParser.LogicalexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.logicalexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalexpression([NotNull] OCLExpressionParser.LogicalexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.multiplicativeexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeexpression([NotNull] OCLExpressionParser.MultiplicativeexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.multiplicativeexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeexpression([NotNull] OCLExpressionParser.MultiplicativeexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OCLExpressionParser.attributecall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributecall([NotNull] OCLExpressionParser.AttributecallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OCLExpressionParser.attributecall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributecall([NotNull] OCLExpressionParser.AttributecallContext context);
}
} // namespace Mascaret