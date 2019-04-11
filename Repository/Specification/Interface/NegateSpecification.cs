using System;
using System.Linq.Expressions;

namespace Specification.Interface
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        public NotSpecification(ISpecification<T> specification)
        {
            Expression = negateExpression(specification.Expression);
        }
        public override Expression<Func<T, bool>> Expression { get; }

        private Func<Expression<Func<T, bool>>, Expression<Func<T, bool>>> negateExpression = (expression) =>
        {
            var paramExpr = expression.Parameters[0];
            var exprBody = System.Linq.Expressions.Expression.Not(expression.Body);

            return System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);
        };
    }
}
