﻿namespace Mages.Core.Runtime.Functions
{
    using System;
    using System.Collections.Generic;

    static class Global
    {
        public static readonly IDictionary<String, Object> Mapping = new Dictionary<String, Object>
        {
            { "abs", StandardOperators.Abs },
            { "not", StandardOperators.Not },
            { "type", StandardOperators.Type },
            { "factorial", StandardOperators.Factorial },
            { "positive", StandardOperators.Positive },
            { "negative", StandardOperators.Negative },
            { "transpose", StandardOperators.Transpose },
            { "pow", StandardOperators.Pow },
            { "add", StandardOperators.Add },
            { "and", StandardOperators.And },
            { "eq", StandardOperators.Eq },
            { "neq", StandardOperators.Neq },
            { "leq", StandardOperators.Leq },
            { "lt", StandardOperators.Lt },
            { "geq", StandardOperators.Geq },
            { "gt", StandardOperators.Gt },
            { "mod", StandardOperators.Mod },
            { "mul", StandardOperators.Mul },
            { "or", StandardOperators.Or },
            { "div", StandardOperators.RDiv },
            { "sub", StandardOperators.Sub },
            { "ceil", StandardFunctions.Ceil },
            { "exp", StandardFunctions.Exp },
            { "floor", StandardFunctions.Floor },
            { "round", StandardFunctions.Round },
            { "log", StandardFunctions.Log },
            { "sign", StandardFunctions.Sign },
            { "gamma", StandardFunctions.Gamma },
            { "sqrt", StandardFunctions.Sqrt },
            { "rand", StandardFunctions.Rand },
            { "sin", StandardFunctions.Sin },
            { "cos", StandardFunctions.Cos },
            { "tan", StandardFunctions.Tan },
            { "cot", StandardFunctions.Cot },
            { "sec", StandardFunctions.Sec },
            { "csc", StandardFunctions.Csc },
            { "sinh", StandardFunctions.Sinh },
            { "cosh", StandardFunctions.Cosh },
            { "tanh", StandardFunctions.Tanh },
            { "coth", StandardFunctions.Coth },
            { "sech", StandardFunctions.Sech },
            { "csch", StandardFunctions.Csch },
            { "arcsin", StandardFunctions.ArcSin },
            { "arccos", StandardFunctions.ArcCos },
            { "arctan", StandardFunctions.ArcTan },
            { "arccot", StandardFunctions.ArcCot },
            { "arcsec", StandardFunctions.ArcSec },
            { "arccsc", StandardFunctions.ArcCsc },
            { "arsinh", StandardFunctions.ArSinh },
            { "arcosh", StandardFunctions.ArCosh },
            { "artanh", StandardFunctions.ArTanh },
            { "arcoth", StandardFunctions.ArCoth },
            { "arsech", StandardFunctions.ArSech },
            { "arcsch", StandardFunctions.ArCsch },
            { "isnan", StandardFunctions.IsNaN },
            { "isint", StandardFunctions.IsInt },
            { "isprime", StandardFunctions.IsPrime },
            { "isinfty", StandardFunctions.IsInfty },
            { "min", StandardFunctions.Min },
            { "max", StandardFunctions.Max },
            { "sort", StandardFunctions.Sort },
            { "reverse", StandardFunctions.Reverse },
            { "throw", StandardFunctions.Throw },
            { "catch", StandardFunctions.Catch },
            { "length", StandardFunctions.Length },
            { "keys", StandardFunctions.Keys },
            { "sum", StandardFunctions.Sum },
            { "any", StandardFunctions.Any },
            { "all", StandardFunctions.All },
            { "stringify", Stringify.Default },
            { "json", Stringify.Json },
            { "list", StandardFunctions.List },
            { "is", StandardFunctions.Is },
            { "as", StandardFunctions.As },
            { "map", StandardFunctions.Map },
            { "reduce", StandardFunctions.Reduce },
            { "where", StandardFunctions.Where },
            { "concat", StandardFunctions.Concat },
            { "zip", StandardFunctions.Zip },
            { "intersect", StandardFunctions.Intersection },
            { "union", StandardFunctions.Union },
            { "except", StandardFunctions.Except },
            { "hasKey", StandardFunctions.HasKey },
            { "getValue", StandardFunctions.GetValue },
        };
    }
}
