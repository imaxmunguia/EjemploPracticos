using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.ClaseAbstracta.Core.v1
{
    public abstract class FiguraGeometrica
    {
        private decimal lado1;
        public string f<T>() => nameof(T);
        public decimal Lado1
        {
            get { return lado1; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Lado1), value, "Valor no puede ser menor que 0");
                }
                lado1 = value;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} Area={Area()}, Perimetro={Perimetro()}";
        }
        public abstract decimal Area();
        public abstract decimal Perimetro();
    }
}
