using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HolaMundo.Models;

namespace HolaMundo.Services
{
    public class PeliculaService
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "IT",
                Pais = "USA",
                Publicacion = DateTime.Now,
                Duracion = 96
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula> {
                new Pelicula(){
                    Titulo = "IT",
                    Pais = "USA",
                    Publicacion = DateTime.Now,
                    Duracion = 96
                },
                new Pelicula(){
                    Titulo = "Gol",
                    Pais = "Spain",
                    Publicacion = new DateTime(2005,12,24),
                    Duracion = 120
                }
        };
        }
    }
}