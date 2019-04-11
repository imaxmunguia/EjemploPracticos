﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.EjemploSoldado.Core
{
    public class LanzaGranadas : IArma
    {
        public string Disparar()
        {
            return "BUMMM";
        }
    }
}
