using System;
using System.Linq.Expressions;
using Specification.Utils;

namespace Specification.Interface
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        public OrSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            Expression = createOrExpression(leftSpecification.Expression, rightSpecification.Expression);
        }
        public override Expression<Func<T, bool>> Expression { get; }

        private Func<Expression<Func<T, bool>>, Expression<Func<T, bool>>, Expression<Func<T, bool>>> createOrExpression = (leftExpression, rightExpression) =>
        {
            var paramExpr = System.Linq.Expressions.Expression.Parameter(typeof(T));
            var exprBody = System.Linq.Expressions.Expression.OrElse(leftExpression.Body, rightExpression.Body);
            exprBody = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(exprBody);
            var finalExpr = System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);

            return finalExpr;
        };
    }
}
