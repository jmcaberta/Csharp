using System;
using System.Collections.Generic;


namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas {get; set; }
        public List<Alumno> Alumno {get; set; }

        public Curso()
        {
            UniqId = Guid.NewGuid().ToString();
        }
    }
}