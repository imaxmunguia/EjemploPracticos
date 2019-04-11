using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoASPNETMVC.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Pais { get; set; }
        public bool EstaEnCartelera { get; set; }
    }
}