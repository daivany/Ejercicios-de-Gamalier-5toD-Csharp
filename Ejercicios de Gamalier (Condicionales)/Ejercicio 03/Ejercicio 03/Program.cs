namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio");

            Console.WriteLine("Ingrese la primera nota:");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota:");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cuarta nota:");
            double nota4 = Convert.ToDouble(Console.ReadLine());


            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;


            if (promedio >= 70)
            {
                Console.WriteLine($"El promedio del estudiante es: {promedio}");
                Console.WriteLine("El estudiante aprobó.");
            }
            else
            {
                Console.WriteLine($"El promedio del estudiante es: {promedio}");
                Console.WriteLine("El estudiante reprobó.");
            }
        }
    }
}
