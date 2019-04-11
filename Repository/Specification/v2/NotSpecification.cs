using System;
using System.Linq.Expressions;

namespace Specification.v2
{
    public class NotSpecification<T> : Specification<T>
    {
        private Specification<T> specification;
        public NotSpecification(Specification<T> specification)
        {
            this.specification = specification ?? throw new ArgumentNullException(nameof(specification));
        }
        public override Expression<Func<T, bool>> ToExpression()
        {
            var expression = specification.ToExpression();
            var paramExpr = expression.Parameters[0];
            var exprBody = Expression.Not(expression.Body);

            return Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);
        }
    }
}