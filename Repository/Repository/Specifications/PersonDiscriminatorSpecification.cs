using System;
using System.Linq.Expressions;
using Specification.Interface;

namespace Repository.Specifications
{
    public class PersonDiscriminatorSpecification : CompositeSpecification<Person>
    {
        public PersonDiscriminatorSpecification(string discriminatorToCompare)
        {
            Expression = person => person.Discriminator.Equals(discriminatorToCompare);
        }
        public override Expression<Func<Person, bool>> Expression { get; }
    }
}