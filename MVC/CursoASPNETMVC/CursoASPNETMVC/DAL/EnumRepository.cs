using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CursoASPNETMVC.DAL
{
    public class EnumRepository
    {
        /* public List<SelectListItem> ToListSelectListItem<T>()
         {
             var t = typeof(T);

             var x = Enum.GetValues(typeof(T));

             if (!t.IsEnum) { throw new ApplicationException("Tipo debe ser enum"); }

             var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);

             var result = new List<SelectListItem>();

             foreach (var member in members)
             {
                 var attributeDescription = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute),
                     false);
                 var descripcion = member.Name;

                 if (attributeDescription.Any())
                 {
                     descripcion = ((System.ComponentModel.DescriptionAttribute)attributeDescription[0]).Description;
                 }

                 var valor = ((int)Enum.Parse(t, member.Name));
                 result.Add(new SelectListItem()
                 {
                     Text = descripcion,
                     Value = valor.ToString()
                 });
             }
             return result;
         }

         public List<object> ToListSelectListItem<T>()
         {
             var t = typeof(T);

             if (!t.IsEnum) { throw new ApplicationException("Tipo debe ser enum"); }

             var estados = Enum.GetValues(typeof(T))
                   .Cast<T>()
                   .ToList().Select(s => new
                   {
                       Value = ((int)Enum.Parse(t, s.ToString())),
                       Text = s.ToString()
                   });

             Enum.Parse()

             return estados;
         }*/
    }
}