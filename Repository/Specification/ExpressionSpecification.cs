using System;
using System.Linq.Expressions;
using Specification.Interface;

namespace Specification
{
    public class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        public ExpressionSpecification(Expression<Func<T,bool>> expression)
        {
            Expression = expression;
        }
        public override Expression<Func<T, bool>> Expression { get; }
    }
}