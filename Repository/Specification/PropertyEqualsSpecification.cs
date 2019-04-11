using System;
using System.Linq.Expressions;
using Specification.Utils;
using Specification.Interface;

namespace Specification
{
    public class PropertyEqualsSpecification<T> : CompositeSpecification<T>
    {
        public PropertyEqualsSpecification(string propertyName, object propertyValue)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                throw new ArgumentNullException("propertyName");
            if (propertyValue == null)
                throw new ArgumentNullException("propertyValue");

            Expression = t => Utilities.FindProperty(t, propertyName).GetValue(t).Equals(propertyValue);
        }
        public override Expression<Func<T, bool>> Expression { get; }
    }
}