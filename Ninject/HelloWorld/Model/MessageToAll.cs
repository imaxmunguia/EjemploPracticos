using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.HelloWorld.Model
{
    public class MessageToAll : IMessage
    {
        public void emit()
        {
            Console.WriteLine("Hello all");
        }
    }
}
