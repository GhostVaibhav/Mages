﻿namespace Mages.Core.Tests
{
    using Mages.Core.Ast;
    using Mages.Core.Ast.Expressions;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ImplicitMultiplicationTests
    {
        [Test]
        public void ExplicitMultiplicationInvolvingNumberAndIdentifier()
        {
            var source = "2 * x";
            var parser = new ExpressionParser();
            var expr = parser.ParseExpression(source);

            AssertMultiplication(expr, 2.0, "x");
        }

        [Test]
        public void ExplicitMultiplicationInvolvingTwoIdentifiers()
        {
            var source = "x * y";
            var parser = new ExpressionParser();
            var expr = parser.ParseExpression(source);

            AssertMultiplication(expr, "x", "y");
        }

        [Test]
        public void ImplicitMultiplicationInvolvingNumberAndIdentifierSeparatedBySpace()
        {
            var source = "2 x";
            var parser = new ExpressionParser();
            var expr = parser.ParseExpression(source);

            AssertMultiplication(expr, 2.0, "x");
        }

        [Test]
        public void ImplicitMultiplicationInvolvingTwoNumbersSeparatedBySpace()
        {
            var source = "2 3";
            var parser = new ExpressionParser();
            var expr = parser.ParseExpression(source);

            AssertMultiplication(expr, 2.0, 3.0);
        }

        [Test]
        public void ImplicitMultiplicationInvolvingTwoIdentifiersSeparatedBySpace()
        {
            var source = "x y";
            var parser = new ExpressionParser();
            var expr = parser.ParseExpression(source);

            AssertMultiplication(expr, "x", "y");
        }

        [Test]
        public void ImplicitMultiplicationInvolvingNumberAndIdentifierNotSeparatedBySpace()
        {
            var source = "2x";
            var parser = new ExpressionParser();
            var expr = parser.ParseExpression(source);

            AssertMultiplication(expr, 2.0, "x");
        }

        [Test]
        public void ImplicitMultiplicationInvolvingNumberAndFunctionCallNotSeparatedBySpace()
        {
            var source = "6.28sin(x)";
            var parser = new ExpressionParser();
            var expr = parser.ParseExpression(source);

            AssertMultiplication(expr, 6.28, "sin", "x");
        }

        private static void AssertMultiplication(IExpression expr, String leftName, String rightName)
        {
            AssertMultiplication<VariableExpression, VariableExpression>(expr,
                variable => variable.Name == leftName,
                variable => variable.Name == rightName);
        }
        
        private static void AssertMultiplication(IExpression expr, Double value, String name)
        {
            AssertMultiplication<ConstantExpression, VariableExpression>(expr,
                constant => (Double)constant.Value == value,
                variable => variable.Name == name);
        }

        private static void AssertMultiplication(IExpression expr, Double leftValue, Double rightValue)
        {
            AssertMultiplication<ConstantExpression, ConstantExpression>(expr,
                constant => (Double)constant.Value == leftValue,
                constant => (Double)constant.Value == rightValue);
        }

        private static void AssertMultiplication(IExpression expr, Double value, String functionName, String functionArgument)
        {
            AssertMultiplication<ConstantExpression, CallExpression>(expr,
                constant => (Double)constant.Value == value,
                call => ((VariableExpression)call.Function).Name == functionName && ((VariableExpression)call.Arguments.Expressions[0]).Name == functionArgument);
        }

        private static void AssertMultiplication<TLeft, TRight>(IExpression expr, Predicate<TLeft> leftChecker, Predicate<TRight> rightChecker)
        {
            Assert.IsInstanceOf<BinaryExpression.Multiply>(expr);

            var binary = (BinaryExpression)expr;

            Assert.IsInstanceOf<TLeft>(binary.LValue);
            Assert.IsInstanceOf<TRight>(binary.RValue);

            Assert.IsTrue(leftChecker.Invoke((TLeft)binary.LValue));
            Assert.IsTrue(rightChecker.Invoke((TRight)binary.RValue));
        }
    }
}
