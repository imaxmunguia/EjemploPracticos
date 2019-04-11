using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.EjemploSoldado.Core
{
    public class Soldado
    {
        protected IArma arma;
        public Soldado(IArma arma)
        {
            this.arma = arma; 
        }

        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }
}