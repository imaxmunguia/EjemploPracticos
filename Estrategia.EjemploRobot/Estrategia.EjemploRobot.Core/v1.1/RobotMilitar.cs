using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v1._1
{
    public class RobotMilitar : Robot
    {
        public override string Caminar()
        {
            return "Marcha militar";
        }
    }
}
