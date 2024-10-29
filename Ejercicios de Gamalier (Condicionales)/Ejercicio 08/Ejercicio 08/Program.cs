namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero Mayor");

            Console.Write("Introduce el primer número entero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número entero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número entero: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine($"El número {numero1} es el mayor.");
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine($"El número {numero2} es el mayor.");
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                Console.WriteLine($"El número {numero3} es el mayor.");
            }

        }
    }
}
