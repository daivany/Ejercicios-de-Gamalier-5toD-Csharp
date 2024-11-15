using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Herencia03.Operaciones;

namespace Herencia03
{
    internal class Operaciones
    {
        static void Main(string[] args)
        {
            Operacion suma = new Suma(10, 5);
            Operacion resta = new Resta(10, 5);
            Operacion multiplicacion = new Multiplicacion(10, 5);

            // Ejecutar y mostrar resultados
            Console.WriteLine("Suma: " + suma.Ejecutar());
            Console.WriteLine("Resta: " + resta.Ejecutar());
            Console.WriteLine("Multiplicación: " + multiplicacion.Ejecutar());
        }
    }
}
    