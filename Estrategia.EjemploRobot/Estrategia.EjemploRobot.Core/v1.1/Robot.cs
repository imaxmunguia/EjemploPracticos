using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v1._1
{
    public class Robot
    {
        public virtual string Caminar()
        {
            return "Caminar normal";
        }

        public virtual string Disparar()
        {
            return "Disparar normal";
        }
    }
}
