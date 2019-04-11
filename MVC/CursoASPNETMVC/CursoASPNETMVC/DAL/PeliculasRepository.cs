using CursoASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoASPNETMVC.DAL
{
    public class PeliculasRepository
    {
        
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                 Titulo ="Argo",
                 Pais = "USA",
                 FechaEstreno=new DateTime(2018,5,29),
                 Duracion=130,
                 EstaEnCartelera =false
            };
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula> {
                new Pelicula(){
                    Titulo = "IT",
                    Pais = "USA",
                    FechaEstreno = DateTime.Now,
                    Duracion = 96,
                    EstaEnCartelera=false
                },
                new Pelicula(){
                    Titulo = "Gol",
                    Pais = "Spain",
                    FechaEstreno = new DateTime(2005,12,24),
                    Duracion = 120,
                    EstaEnCartelera = true
                },
                new Pelicula(){
                    Titulo = "300",
                    Pais = "USA",
                    FechaEstreno = new DateTime(2001,6,16),
                    Duracion = 145,
                    EstaEnCartelera = true
                }
            };
        }
    }
}