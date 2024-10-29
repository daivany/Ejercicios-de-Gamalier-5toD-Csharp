namespace Ejercicio_bucle04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucle");
            Console.WriteLine();

            int suma = 0;

            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los primeros 100 números naturales es: {suma}");

        }
    }
}
