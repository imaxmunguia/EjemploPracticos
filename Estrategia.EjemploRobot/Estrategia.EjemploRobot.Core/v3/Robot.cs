using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v3
{
    public abstract class Robot
    {
        private IDispararBehavior disparador;
        private ICaminarBehavior caminador;

        public IDispararBehavior Disparador
        {
            get { return disparador; }
            set
            {
                disparador = value ?? throw new ArgumentNullException("Disparador", "Especifique un valor no nulo como argumento");
            }
        }
        public ICaminarBehavior Caminador
        {
            get { return caminador; }
            set
            {
                caminador = value ?? throw new ArgumentNullException("Caminador", "Especifique un valor no nulo como argumento");
            }
        }

        public Robot()
        {

        }
        public string Caminar()
        {
            return caminador.Caminar();
        }
        public string Disparar()
        {
            return disparador.Disparar();
        }
        public virtual void Activar()
        {
            //TODO
        }
        public virtual void Desactivar()
        {
            //TODO
        }
    }
}
