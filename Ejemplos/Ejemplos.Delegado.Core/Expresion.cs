using System;
using System.Linq.Expressions;

namespace Ejemplos.Delegado.Core
{
    public static class Expresion<T>
    {

        public static Func<Func<T, bool>, Func<T, bool>, Func<T, bool>> Or = (lexp, rexp) =>
        {
            return (x) => lexp.Invoke(x) || rexp.Invoke(x);
        };

        public static Func<Func<T, bool>, Func<T, bool>, Func<T, bool>> And = (lexp, rexp) =>
        {
            return (x) => lexp.Invoke(x) && rexp.Invoke(x);
        };

        public static Func<Expression<Func<T, bool>>, Expression<Func<T, bool>>, Func<T, bool>> linqAnd = (lexp, rexp) =>
        {
            var paramExpr = Expression.Parameter(typeof(T));
            var exprBody = Expression.AndAlso(lexp.Body, rexp.Body);
            exprBody = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(exprBody);
            var finalExpr = Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);

            return finalExpr.Compile();
        };
    }
}
