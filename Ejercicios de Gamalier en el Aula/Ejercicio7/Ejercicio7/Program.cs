namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo");


               Console.Write("Introduzca el sueldo del empleado: "); 

                decimal sueldoAnterior = Convert.ToDecimal(Console.ReadLine());

            
                decimal aumento = sueldoAnterior * 0.15m;

                decimal nuevoSueldo = sueldoAnterior + aumento;

                Console.WriteLine("\nSueldo anterior: {0:C}", sueldoAnterior);
                Console.WriteLine("Aumento que se le aplico: {0:C}", aumento);
                Console.WriteLine("Nuevo sueldo: {0:C}", nuevoSueldo);
            }
        }

    }
