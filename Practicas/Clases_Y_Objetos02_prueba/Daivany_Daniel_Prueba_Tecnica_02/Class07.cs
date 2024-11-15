using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Y_Objetos02_prueba
{
    internal class Class07
    {

        public class Estudiante
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Estudiante(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }
        }

        public class Asignatura
        {
            public string Nombre { get; set; }
            public double Calificacion { get; set; }

            public Asignatura(string nombre, double calificacion)
            {
                Nombre = nombre;
                Calificacion = calificacion;
            }
        }

        public class RegistroAcademico
        {
            public Estudiante Estudiante { get; set; }
            private List<Asignatura> asignaturas;

            public RegistroAcademico(Estudiante estudiante)
            {
                Estudiante = estudiante;
                asignaturas = new List<Asignatura>();
            }

            public void AgregarAsignatura(string nombre, double calificacion)
            {
                asignaturas.Add(new Asignatura(nombre, calificacion));
            }

            public void MostrarRegistro()
            {
                Console.WriteLine($"Estudiante: {Estudiante.Nombre} (Edad: {Estudiante.Edad})");
                Console.WriteLine("Asignaturas:");
                foreach (var asignatura in asignaturas)
                {
                    Console.WriteLine($"- {asignatura.Nombre}: {asignatura.Calificacion}");
                }
                Console.WriteLine($"Promedio de Calificaciones: {CalcularPromedio():F2}");
            }

            public double CalcularPromedio()
            {
                double suma = 0;
                foreach (var asignatura in asignaturas)
                {
                    suma += asignatura.Calificacion;
                }
                return asignaturas.Count > 0 ? suma / asignaturas.Count : 0;
            }
        }
    }
}
