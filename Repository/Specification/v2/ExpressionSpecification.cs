using System;
using System.Linq.Expressions;

namespace Specification.v2
{
    public class ExpressionSpecification<T> : Specification<T>
    {
        Expression<Func<T, bool>> expression;
        public ExpressionSpecification(Expression<Func<T, bool>> expression)
        {
            this.expression = expression ?? throw new ArgumentNullException("Expression<Func<T, bool>> expression");
        }
        public override Expression<Func<T, bool>> ToExpression()
        {
            return this.expression;
        }
    }
}