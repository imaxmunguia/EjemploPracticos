using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ninject.HelloWorld.Model
{
    public class Person
    {
        private IMessage Message;

        public Person(IMessage Message)
        {
            this.Message = Message;
        }

        public void greet()
        {
            Message.emit();
        }
    }
}
