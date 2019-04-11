using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;

namespace Ejemplos.CustomConfiguration
{
    public class RecargaElectronicaSection : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            List<RecargaElectronicaConfig> recargasElectronicasConfig = new List<RecargaElectronicaConfig>();

            foreach (XmlNode item in section.ChildNodes)
            {
                recargasElectronicasConfig.Add(Util.ConvertNode<RecargaElectronicaConfig>(item));
            }
            
            return recargasElectronicasConfig;
        }
    }
}