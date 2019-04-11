using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stumasys.Model
{
    public class ResponseModel
    {
        public bool State { get; set; }
        public string Redirect { get; set; }
        public string Error { get; set; }

    }
}
