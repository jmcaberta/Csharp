
using System;
using System.Collections.Generic;

namespace  CoreEscuela.Entidades
{
        public class Escuela 
        {
            public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
            string nombre;
            public string Nombre
            {
                get{ return "copia: " + nombre; }
                set{nombre = value.ToUpper(); }
            }

            public int añoDeCreacion {get; set; }
            public string Pais { get; set; }
            public string Ciudad { get; set; }
            public TiposEscuela TiposEscuela{get; set; }
            // Codigo de la array
            //public Curso[] Cursos {get; set; }

            //codigo de la colleccion
            public List<Curso> Cursos {get; set; }


            // public Escuela(string nombre, int año)
            // {
            //     this.nombre = nombre;
            //     añoDeCreacion = año;
            // }

            public Escuela(string nombre, int año) => (Nombre, añoDeCreacion) = (nombre, año);
            public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
            {
                (Nombre, añoDeCreacion) = (nombre, año);
                Pais = pais;
                Ciudad = ciudad;

            }

            public override string ToString()
            {
                return $"Nombre: \"{Nombre}\", Tipo: { TiposEscuela + " "} \nPais: { Pais + " "}, Ciudad: { Ciudad + " "}";
            }
        }
}