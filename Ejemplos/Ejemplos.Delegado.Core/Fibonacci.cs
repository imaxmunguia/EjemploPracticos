using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Delegado.Core
{
    public static class Fibonacci
    {
        public static Func<long, long, long, long> NumeroMayorIgualQue = (maximo, a, b) =>
        {
            if (a >= maximo)
            {
                return a;
            }
            //Recursion.
            return NumeroMayorIgualQue(maximo, a + b, a);
        };
        public static Func<long, List<long>, List<long>> PrimerosNumeros = (cantidad, numeros) =>
        {
            if (numeros.Count == cantidad)
            {
                return numeros;
            }
            else if (numeros.Count < 2)
            {
                numeros.Add(numeros.Count);
            }
            else
            {
                numeros.Add(numeros.ElementAt(numeros.Count - 2) + numeros.ElementAt(numeros.Count - 1));
            }
            //Recursion.
            return PrimerosNumeros(cantidad, numeros);
        };
        public static Func<long, long, long, List<long>, List<long>> NumerosMenoresQue = (maximo, a, b, numeros) =>
        {
            if (a > maximo)
            {
                return numeros;
            }
            numeros.Add(a);
            //Recursion.
            return NumerosMenoresQue(maximo, a + b, a, numeros);
        };

        public static Func<long, long> FibonacciNumeroEnLaSucecion = (numero) =>
        {
            if (numero == 0 || numero == 1)
                return numero;
            else
                return FibonacciNumeroEnLaSucecion(numero - 1) + FibonacciNumeroEnLaSucecion(numero - 2);
        };
    }
}
