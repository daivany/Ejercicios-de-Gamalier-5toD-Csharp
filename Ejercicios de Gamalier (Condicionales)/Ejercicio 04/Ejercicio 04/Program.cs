namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calificaciones");

            double suma = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Introduce la calificación {i}: ");
                suma += double.Parse(Console.ReadLine());
            }

            double promedio = suma / 4;
            Console.WriteLine($"El promedio de las calificaciones es: {promedio}");

            if (promedio >= 90 && promedio <= 100)
            {
                Console.WriteLine("Situación: Excelente");
            }
            else if (promedio >= 80 && promedio < 90)
            {
                Console.WriteLine("Situación: Muy bueno");
            }
            else if (promedio >= 75 && promedio < 80)
            {
                Console.WriteLine("Situación: Bueno");
            }
            else if (promedio >= 70 && promedio < 75)
            {
                Console.WriteLine("Situación: Regular");
            }
            else
            {
                Console.WriteLine("Situación: Deficiente");
            }
        }
    }
}
