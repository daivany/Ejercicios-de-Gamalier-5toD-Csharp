namespace Ejercicio_07
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

            
            if (numero1 > numero2)
            {
                Console.WriteLine($"El número {numero1} es mayor que {numero2}.");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine($"El número {numero2} es mayor que {numero1}.");
            }
        }
    }
}
