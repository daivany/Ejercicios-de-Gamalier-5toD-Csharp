namespace Ejercicio_13
{
    internal class Program
    {
        static double nota1, nota2, nota3, nota4, completivo, promedio_completivo;
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
                Console.WriteLine("Promedio: " + promedio + ", Aprobado. ");
            else
                Console.WriteLine("Promedio: " + promedio + ", Reprobado. ");
        }
    }
}