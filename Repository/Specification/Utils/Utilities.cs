using System;
using System.Reflection;

namespace Specification.Utils
{
    public static class Utilities
    {
        public static Func<object, string, PropertyInfo> FindProperty = (obj, propertyName) =>
        {
            return obj.GetType().GetProperty(propertyName) ?? throw new ArgumentOutOfRangeException("propertyName", propertyName, $"El objeto de tipo {obj.GetType()} no contine la propiedad especificada.");
        };
    }
}