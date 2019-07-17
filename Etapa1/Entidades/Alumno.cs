using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades {
    public class Alumno {
        public Alumno (string uniqId, string nombre) {
            this.UniqId = uniqId;
            this.Nombre = nombre;

        }
        public string UniqId { get; private set; }
        public string Nombre { get; set; }
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();

        public Alumno () => UniqId = Guid.NewGuid ().ToString ();
    }
}