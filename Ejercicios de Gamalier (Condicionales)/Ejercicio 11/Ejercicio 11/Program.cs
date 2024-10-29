namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incentivo");

            const int diasLaborales = 5; 
            double[] produccion = new double[diasLaborales];
            double totalProduccion = 0;

            for (int i = 0; i < diasLaborales; i++)
            {
                Console.Write($"Introduce la producción del día {i + 1} (lunes a viernes): ");
                produccion[i] = double.Parse(Console.ReadLine());
                totalProduccion += produccion[i];
            }

            double promedioProduccion = totalProduccion / diasLaborales;
            double incentivo = 0;

          
            if (promedioProduccion >= 20000)
            {
                incentivo = 3000; 
            }
            else
            {
                Console.WriteLine("Incentivo: N/A");
            }

           
            Console.WriteLine($"Total de producción de la semana: RD${totalProduccion:F2}");
            Console.WriteLine($"Promedio de producción: RD${promedioProduccion:F2}");

            if (incentivo > 0)
            {
                Console.WriteLine($"Incentivo: RD${incentivo:F2}");
            }  
        }
    }
}
