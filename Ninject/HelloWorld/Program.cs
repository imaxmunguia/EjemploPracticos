using Ninject.HelloWorld.Model;
using Ninject.HelloWorld.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.HelloWorld
{
    class Program
    {
        private static IKernel kernel;

        static void Main(string[] args)
        {
            //kernel = new StandardKernel();
            //kernel.Bind<IMessage>().To<MessageToAll>();

            kernel = new StandardKernel(new DependencyResolver());

            sendGreeting();
            Console.ReadKey();
        }

        private static void sendGreeting()
        {
            Person person = kernel.Get<Person>();
            person.greet();
        }
    }
}
