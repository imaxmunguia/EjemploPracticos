using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v2
{
    public class RobotCasero : Robot, ICaminador
    {
        public string Caminar()
        {
            return "Camina normal";
        }
    }
}
