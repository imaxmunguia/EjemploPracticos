using Ninject.Modules;
using Ninject.HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.HelloWorld.DI
{
    public class DependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Bind<IMessage>().To<MessageToWorld>();
        }
    }
}
