using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.EjemploSoldado.Core
{
    public class Revolver : IArma
    {
        public string Disparar()
        {
            return "PUMMM";
        }
    }
}
