using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Y_Objetos02_prueba;
using static Clases_Y_Objetos02_prueba.Class07;

namespace Clases_Y_Objetos02_prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RegistroAcademico> registros = new List<RegistroAcademico>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---- Sistema de Gestión Académica ----");
                Console.WriteLine("1. Agregar Estudiante y su Registro Academico");
                Console.WriteLine("2. Ver Registros Academicos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del estudiante: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese la edad del estudiante: ");
                        int edad = int.Parse(Console.ReadLine());

                        Estudiante estudiante = new Estudiante(nombre, edad);
                        RegistroAcademico registro = new RegistroAcademico(estudiante);

                        for (int i = 1; i <= 3; i++)
                        {
                            Console.Write($"Ingrese el nombre de la asignatura {i}: ");
                            string nombreAsignatura = Console.ReadLine();

                            Console.Write($"Ingrese la calificación para {nombreAsignatura}: ");
                            double calificacion = double.Parse(Console.ReadLine());

                            registro.AgregarAsignatura(nombreAsignatura, calificacion);
                        }

                        registros.Add(registro);
                        Console.WriteLine("Registro académico agregado correctamente.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("---- Registros Académicos ----");
                        foreach (var reg in registros)
                        {
                            reg.MostrarRegistro();
                            Console.WriteLine("---------------------------------");
                        }
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del sistema...");
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}

    




