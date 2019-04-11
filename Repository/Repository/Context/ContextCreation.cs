using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class ContextCreation : IDisposable
    {
        public ContextCreation()
        {
            ContextFactory.OpenConnection();
        }
        public void Dispose()
        {
            ContextFactory.CloseConnection();
        }
        ~ContextCreation()
        {
            this.Dispose();
        }
    }
}
