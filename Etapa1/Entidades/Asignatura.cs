using System;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqId { get; private set; }
        public string Nombre { get; set; }

        public Asignatura() => UniqId = Guid.NewGuid().ToString();
    }
}