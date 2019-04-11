using System;
using System.Linq.Expressions;
using Specification.Utils;

namespace Specification.v2
{
    public class PropertyEqualsSpecification<T> : Specification<T>
    {
        Expression<Func<T, bool>> expression;
        public PropertyEqualsSpecification(string propertyName, object propertyValue)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                throw new ArgumentNullException("propertyName");
            if (propertyValue == null)
                throw new ArgumentNullException("propertyValue");

            this.expression = p => Utilities.FindProperty(p, propertyName).GetValue(p).Equals(propertyValue);
        }
        public override Expression<Func<T, bool>> ToExpression()
        {
            return this.expression;
        }
    }
}