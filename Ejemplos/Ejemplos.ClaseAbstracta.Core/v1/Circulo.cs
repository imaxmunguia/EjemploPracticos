using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.ClaseAbstracta.Core.v1
{
    public class Circulo : FiguraGeometrica
    {
        public Circulo(string nombre,int radio)
        {
            Lado1 = radio;
        }

        public override decimal Area()
        {
            return Convert.ToDecimal(3.141516F) * Lado1 * Lado1;
        }

        public override decimal Perimetro()
        {
            return Convert.ToDecimal(3.141516F) * 2 * Lado1;
        }
    }
}
