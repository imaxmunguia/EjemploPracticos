using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v1
{
    public abstract class Robot
    {
        public abstract string Caminar();
        public abstract string Disparar();
    }
}
