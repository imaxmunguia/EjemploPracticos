using System;
using System.Linq.Expressions;
using Specification.Utils;

namespace Specification.Interface
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            Expression = createAndExpression(leftSpecification.Expression, rightSpecification.Expression);
        }
        public override Expression<Func<T, bool>> Expression { get; }

        private Func<Expression<Func<T, bool>>, Expression<Func<T, bool>>, Expression<Func<T, bool>>> createAndExpression = (leftExpression, rightExpression) =>
        {
            var paramExpr = System.Linq.Expressions.Expression.Parameter(typeof(T));
            var exprBody = System.Linq.Expressions.Expression.AndAlso(leftExpression.Body, rightExpression.Body);
            exprBody = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(exprBody);

            return System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);
        };
    }
}
