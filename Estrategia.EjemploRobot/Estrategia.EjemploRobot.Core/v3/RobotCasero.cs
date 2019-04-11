using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v3
{
    public class RobotCasero : Robot
    {
        public RobotCasero()
        {
            Caminador = new CaminaNormal();
            Disparador = new NoDisparar();
        }
    }
}
