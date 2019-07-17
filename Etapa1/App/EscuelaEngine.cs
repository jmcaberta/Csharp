using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela {get; set; }

        public EscuelaEngine()
        {
            

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Universidad, ciudad: "San Fransisco", pais: "USA");

            CargarCursos();           
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()        
        {
            var lista = new List<Evaluación>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumno)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++) 
                        {
                            var ev = new Evaluación
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };

                            alumno.Evaluaciones.Add(ev);                            
                        }                        
                    }
                }
            }
            
        }

        private void CargarAsignaturas()
        {
             
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matematicas para Programacion"}, 
                    new Asignatura{Nombre = "Fisica Cuantica"},
                    new Asignatura{Nombre = "Economia"},
                    new Asignatura{Nombre = "Desarrollo de Software"}
                };               
                curso.Asignaturas = (listaAsignaturas);
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string [] nombre1 = {"Frank", "Gumaro", "Hans", "Federica", "Eutilio", "Mafalda"};
            string [] apellido1 = {"Patiño", "Memelas", "Perez", "Donatelo", "Zapata", "Schmidt", "Sabas"};
            string [] nombre2 = {"Rosita", "Selena", "Martinico", "Tobias", "Artemio", "Peter"};

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno{Nombre=$"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy((al)=> al.UniqId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Noche},
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Tarde},
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana}
            };

            Random rnd = new Random();
            

            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumno = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}