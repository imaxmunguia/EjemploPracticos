using System;
using System.Linq.Expressions;

namespace Specification.Interface
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Expression { get; }
        bool IsSatisfiedBy(T obj);
        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> Or(ISpecification<T> specification);
        ISpecification<T> Negate();
    }
}
