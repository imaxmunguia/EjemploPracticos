using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.EjemploSoldado.Core;

namespace DI.EjemploSoldado.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldado = new Soldado(new Revolver());
            Console.WriteLine(soldado.Disparar());

            soldado = new Soldado(new Rifle());
            Console.WriteLine(soldado.Disparar());

            soldado = new Soldado(new LanzaGranadas());
            Console.WriteLine(soldado.Disparar());

            Console.ReadKey();
        }
    }
}
