using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.ClaseAbstracta.Core.v1
{
    public class Rectangulo : FiguraGeometrica
    {
        private decimal lado2;
        public Rectangulo(string nombre,decimal a, decimal b)
        {
            Lado1 = a;
            Lado2 = b;
        }

        public decimal Lado2
        {
            get { return lado2; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Lado2), value, "Valor no puede ser menor que 0");
                }
                lado2 = value;
            }
        }

        public override decimal Area()
        {
            return Lado1*Lado2;
        }

        public override decimal Perimetro()
        {
            return 2 * Lado1 + 2 * Lado2;
        }
    }
}
