using System;

namespace Ninject.HelloWorld.Model
{
    public class MessageToWorld : IMessage
    {
        public void emit()
        {
            Console.WriteLine("Hello World");
        }
    }
}