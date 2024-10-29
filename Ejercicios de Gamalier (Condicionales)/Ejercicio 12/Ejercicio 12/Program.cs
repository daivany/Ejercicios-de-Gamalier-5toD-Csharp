namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo");

            Console.Write("Introduce el sueldo del empleado: ");
            double sueldo = double.Parse(Console.ReadLine());

      
            Console.Write("Introduce el número de hijos del empleado: ");
            int numeroHijos = int.Parse(Console.ReadLine());

          
            double incentivo = 0;

            if (numeroHijos > 0)
            {
                incentivo = numeroHijos * 500;
            }

           
            double sueldoTotal = sueldo + incentivo;

           
            Console.WriteLine($"Sueldo base: RD${sueldo:F2}");
            Console.WriteLine($"Número de hijos: {numeroHijos}");


            if (numeroHijos > 0)
            {
                Console.WriteLine($"Incentivo por hijos: RD${incentivo:F2}");
            }
            else
            {
                Console.WriteLine("Incentivo: N/A");
            }

            Console.WriteLine($"Sueldo total con incentivo: RD${sueldoTotal:F2}");
        }
    }
}
