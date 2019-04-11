using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia.EjemploRobot.Core.v3
{
    public class CaminaMarchaMilitar : ICaminarBehavior
    {
        public string Caminar()
        {
            return "Marcha militar";
        }
    }
}
