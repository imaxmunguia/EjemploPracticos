using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Specification.Interface
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract Expression<Func<T, bool>> Expression { get; }
        public bool IsSatisfiedBy(T obj)
        {
            return Expression.Compile()(obj);
        }
        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
        public ISpecification<T> Negate()
        {
            return new NotSpecification<T>(this);
        }
    }
}
