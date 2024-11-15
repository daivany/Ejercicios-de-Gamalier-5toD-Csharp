using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia03
{
    internal class Operaciones 
    {
        public abstract class Operacion
        {
            // Propiedades para los números a operar
            public double Numero1 { get; set; }
            public double Numero2 { get; set; }

            // Constructor que inicializa los números
            public Operacion(double numero1, double numero2)
            {
                Numero1 = numero1;
                Numero2 = numero2;
            }

            // Método abstracto para ejecutar la operación
            public abstract double Ejecutar();
        }

        public class Suma : Operacion
        {
            // Constructor que usa el constructor de la clase base
            public Suma(double numero1, double numero2) : base(numero1, numero2) { }

            // Implementación del método abstracto para sumar
            public override double Ejecutar()
            {
                return Numero1 + Numero2;
            }
        }

        public class Resta : Operacion
        {
            // Constructor que usa el constructor de la clase base
            public Resta(double numero1, double numero2) : base(numero1, numero2) { }

            // Implementación del método abstracto para restar
            public override double Ejecutar()
            {
                return Numero1 - Numero2;
            }
        }

        public class Multiplicacion : Operacion
        {
            // Constructor que usa el constructor de la clase base
            public Multiplicacion(double numero1, double numero2) : base(numero1, numero2) { }

            // Implementación del método abstracto para multiplicar
            public override double Ejecutar()
            {
                return Numero1 * Numero2;
            }
        }
    }
}