using System;
using System.Linq.Expressions;
using Specification.Interface;

namespace Repository.Specifications
{
    public class PersonFirstNameSpecification : CompositeSpecification<Person>
    {
        public PersonFirstNameSpecification(string nameToCompare)
        {
            if (string.IsNullOrWhiteSpace(nameToCompare))
                throw new ArgumentNullException("nameToCompare");
            Expression = person => person.FirstName.Equals(nameToCompare);
        }
        public override Expression<Func<Person, bool>> Expression { get; }
    }
}