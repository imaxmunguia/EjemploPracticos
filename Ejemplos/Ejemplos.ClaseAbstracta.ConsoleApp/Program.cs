using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Ejemplos.Delegado.Core;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Ejemplos.ClaseAbstracta.ConsoleApp
{
    class Program
    {
        public string f<T>() => nameof(T);
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    var guid = Guid.NewGuid();
                    var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                    var seed = int.Parse(justNumbers.Substring(0, 4));

                    var random = new Random(seed);
                    var value = random.Next(2, 6);

                    Console.WriteLine($"Iteración {i} - semilla {seed} - valor {value}");
                }
                var randomNumber = new Random().Next(2, 6);

                string clave = "Grup0l321tZ";
                var tieneSecuencias = clave.Select((x, i) => new { v1 = x, v2 = clave.Skip(i + 1).Take(1).FirstOrDefault() - 1, v3 = clave.Skip(i + 2).Take(1).FirstOrDefault() - 2 })
                                           .Count(x => x.v1 == x.v2 && x.v2 == x.v3);
                var claveInversa = clave.Reverse();
                var tieneSecuenciasInv = claveInversa.Select((x, i) => new { v1 = x, v2 = claveInversa.Skip(i + 1).Take(1).FirstOrDefault() - 1, v3 = claveInversa.Skip(i + 2).Take(1).FirstOrDefault() - 2 })
                           .Count(x => x.v1 == x.v2 && x.v2 == x.v3);

                Func<string, int> eval = obj => obj.Select((x, i) => new
                {
                    v1 = x,
                    v2 = obj.Skip(i + 1).Take(1).FirstOrDefault() - 1,
                    v3 = obj.Skip(i + 2).Take(1).FirstOrDefault() - 2
                }).Count(f => f.v1 == f.v2 && f.v2 == f.v3);

                Func<List<char>, int> evalReverse = obj => obj.Select((x, i) => new
                {
                    v1 = x,
                    v2 = obj.Skip(i + 1).Take(1).FirstOrDefault() - 1,
                    v3 = obj.Skip(i + 2).Take(1).FirstOrDefault() - 2
                }).Count(f => f.v1 == f.v2 && f.v2 == f.v3);

                var uu = eval(clave) == 0 && evalReverse(clave.Reverse().ToList()) == 0;

                var tieneMayusculas = clave.Count(c => char.IsUpper(c));
                var tieneMinusculas = clave.Count(c => char.IsLower(c));
                var tieneNumeros = clave.Count(c => char.IsDigit(c));

                var dirs = ConfigurationManager.GetSection("RecargasElectronicasConfig");

                string ejemplo = "Isack";

                var funcLinqAnd = Expresion<string>.linqAnd(p => p.Equals("Isack"), p => p.Equals("Isack")).Invoke(ejemplo);

                var resultAnd = Expresion<string>.And(lexp => lexp.Equals("Munguia"), rexp => rexp.Equals("Isack")).Invoke(ejemplo);
                var resultOr = Expresion<string>.Or(lexp => lexp.Equals("Munguia"), rexp => rexp.Equals("Isack")).Invoke(ejemplo);

                var circulo1 = new Core.v1.Circulo("circulo1", 1);
                Console.WriteLine(circulo1);

                Console.WriteLine(nameof(circulo1));

                Console.WriteLine("Operaciones aritmeticas");
                Aritmetica.Operacion += Aritmetica.Dividir;
                Console.WriteLine(Aritmetica.Operacion(4, 2));
                Console.WriteLine(Aritmetica.Multiplicar(4, 2));
                Console.WriteLine(Aritmetica.Restar(4, 2));
                Console.WriteLine(Aritmetica.Sumar(4, 2));

                // Iniciamos la ejecucion.
                //Aritmetica.Fibonacci(0, 1);

                Console.WriteLine("Numeros de fibonacci");
                Console.WriteLine(Fibonacci.FibonacciNumeroEnLaSucecion(20));
                Console.WriteLine(Fibonacci.NumeroMayorIgualQue(500, 0, 1));
                Console.WriteLine(string.Join(",", Fibonacci.PrimerosNumeros(21, new List<long>())));
                Console.WriteLine(string.Join(",", Fibonacci.NumerosMenoresQue(500, 0, 1, new List<long>())));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
