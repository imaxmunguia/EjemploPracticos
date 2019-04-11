using System;
using System.Linq.Expressions;

namespace Specification.v2
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();
        public bool IsSatisfiedBy(T obj)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(obj);
        }
        public Specification<T> And(Specification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
        public Specification<T> Or(Specification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
        public Specification<T> Negate()
        {
            return new NotSpecification<T>(this);
        }
    }
}
