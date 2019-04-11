using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Delegado.Core
{
    public static class Aritmetica
    {
        // Declaramos el Generic
        public static Func<decimal, decimal, decimal> Operacion;
        public static Func<decimal, decimal, decimal> Sumar = (a, b) => a + b;
        public static Func<decimal, decimal, decimal> Restar = (a, b) => a - b;
        public static Func<decimal, decimal, decimal> Multiplicar = (a, b) => a * b;
        public static Func<decimal, decimal, decimal> Dividir = (dividendo, divisor) => dividendo / divisor;
    }
}
