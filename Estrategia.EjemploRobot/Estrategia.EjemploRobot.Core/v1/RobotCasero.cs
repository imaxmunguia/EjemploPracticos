using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v1
{
    public class RobotCasero : Robot
    {
        public override string Caminar()
        {
            return "Camina normal";
        }

        public override string Disparar()
        {
            throw new NotImplementedException();
        }
    }
}
