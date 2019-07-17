using System;
using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
// Me ayuda a eliminar la escritura del console cada vez que llamo a una accion con console
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            // var escuela = new Escuela("Universidad Regiomontana", 1954, TiposEscuela.Universidad,
            // pais: "Mexico");
            // escuela.Pais = "Mexico";
            // escuela.Ciudad = "Monterrey";       
            
            // esta es una coleccion     
            // escuela.Cursos = new List<Curso>() {
            //      new Curso() { Nombre = "101"},
            //     new Curso() { Nombre = "201"},
            //     new Curso() { Nombre = "301"}
            // };

            // escuela.Cursos.Add( new Curso{ Nombre = "102", Jornada = TiposJornada.Tarde});
            // escuela.Cursos.Add( new Curso { Nombre = "202", Jornada = TiposJornada.Noche});

            // var otrColeccion = new List<Curso>(){
            //         new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana},
            //         new Curso(){ Nombre = "501", Jornada = TiposJornada.Tarde},
            //         new Curso(){ Nombre = "502", Jornada = TiposJornada.Noche}
            // };
            //Curso tmp = new Curso(){ Nombre = "101 - Vacacional", Jornada = TiposJornada.Mañana};
            //otrColeccion.Clear();
            //escuela.Cursos.AddRange(otrColeccion);
            // escuela.Cursos.Add(tmp);
            // ImprimirCursosEscuela(escuela);
            //WriteLine("Curso.Hash " + tmp.GetHashCode());

            
            // escuela.Cursos.RemoveAll(delegate(Curso cur)
            // {
            //     return cur.Nombre == "301";
            // });

            // escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "501");
            //escuela.Cursos.Remove(tmp);
            Printer.DibujarLinea(25);
            
            //Esta es la forma original de los arreglos al inicio del curso,a continuacion trataremos-
            // de hacer mas compacto el codigo.
            // arregloCursos [0] = new Curso()
            //                     {
            //                         Nombre = "101"
            //                     };
            // var curso2 = new Curso()
            // {
            //     Nombre = "201"
            // };
            // arregloCursos [1] = curso2;           

            // arregloCursos [2] = new Curso            
            // {
            //     Nombre = "301"
            // };

            // Esta es otra forma de arreglos
            // var arregloCursos = new Curso[3]{
            //     new Curso() { Nombre = "101"},
            //     new Curso() { Nombre = "201"},
            //     new Curso() { Nombre = "301"}
            //     };
            
            // Forma mas compacta 
            // Curso[] arregloCursos = {
            //     new Curso() { Nombre = "101"},
            //     new Curso() { Nombre = "201"},
            //     new Curso() { Nombre = "301"}
            //     };

            //Otra forma compacta  de Array o arreglo 
            // escuela.Cursos = new Curso[] {
            //     new Curso() { Nombre = "101"},
            //     new Curso() { Nombre = "201"},
            //     new Curso() { Nombre = "301"}
            //     };
            
                                  
            
            // WriteLine(escuela);
            // WriteLine("=============================");
            // System.Console.WriteLine(curso1.Nombre + "," + curso1.UniqId);
            // Console.WriteLine($"{curso2.Nombre} , {curso2.UniqId}");
            // Console.WriteLine($"{curso3.Nombre} , {curso3.UniqId}");
            // Console.WriteLine(arregloCursos[0].Nombre);
            // Console.WriteLine("Presione ENTER para continuar");
            // Console.ReadLine();
            // Console.WriteLine(arregloCursos[5].Nombre);

            // ImprimirCursosWhile(arregloCursos);
            // System.Console.WriteLine("=============================");
            // ImprimirCursosDoWhile(arregloCursos);
            // System.Console.WriteLine("=============================");
            // ImprimirCursosFor(arregloCursos);
            // System.Console.WriteLine("=============================");
            // ImprimirCursosForEach(arregloCursos);

            
            ImprimirCursosEscuela(engine.Escuela);

            // bool rta = 10 == 10; 
            // int cantidad = 10;
            // if(rta == false)
            // {
            //     WriteLine("Se cumplio la condicion #1");
            // } else if(cantidad > 15){
            //     WriteLine("Se cumplio la condicion #2");
            // }else
            // {
            //     WriteLine("No se cumplio ninguna de las dos condiciones");
            // }

            // if(cantidad > 5 && rta == false)
            // {
            //     WriteLine("Se cumplio la condicion #3");
            // }

            // if(cantidad > 5 && rta != false)
            // {
            //     WriteLine("Se cumplio la condicion #4");
            // }
            // if(cantidad > 5 || !rta )
            // {
            //     WriteLine("Se cumplio la condicion #5");
            // }
            // if(cantidad > 15 || rta )
            // {
            //     WriteLine("Se cumplio la condicion #6");
            // }
            // if((cantidad > 15 || rta) && (cantidad % 5 == 0) )
            // {
            //     WriteLine("Se cumplio la condicion #7");
            // }
        }
        
        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo("Bienvenidos a la escuela");
            Printer.DibujarTitulo("Cursos de la Escuela");
            Printer.Beep(10000, cantidad: 10);
            //forma simplicada que dice que no verificara cursos si escuela es diferente de null
            if(escuela?.Cursos != null)
            {                
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id {curso.UniqId}");
                }            
            }

            //  if(escuela != null && escuela.Cursos != null)
            // {                
            //     foreach (var curso in escuela.Cursos)
            //     {
            //         WriteLine($"Nombre {curso.Nombre  }, Id {curso.UniqId}");
            //     }            
            // }
        }

        // private static void ImprimirCursosWhile(Curso[] arregloCursos)
        // {
        //     int contador = 0;
        //     while (contador < arregloCursos.Length)
        //     {
        //         WriteLine($"Nombre {arregloCursos[contador].Nombre }, Id {arregloCursos[contador].UniqId}");
        //         contador++;
        //     }
        // }

        // private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        // {
        //     int contador = 0;
        //     do 
        //     {
        //         WriteLine($"Nombre {arregloCursos[contador].Nombre }, Id {arregloCursos[contador].UniqId}");
        //         contador++;
        //     } while (contador < arregloCursos.Length);
        // }

        // private static void ImprimirCursosFor(Curso[] arregloCursos)
        // {
        //     for( int i = 0; i < arregloCursos.Length; i++)
        //     {
        //         WriteLine($"Nombre {arregloCursos[i].Nombre }, Id {arregloCursos[i].UniqId}");
                
        //     } 
        // }

        // private static void ImprimirCursosForEach(Curso[] arregloCursos)
        // {
        //     foreach( var curso in arregloCursos)
        //     {
        //         WriteLine($"Nombre {curso.Nombre }, Id {curso.UniqId}");
                
        //     } 
        // }
    }
}
