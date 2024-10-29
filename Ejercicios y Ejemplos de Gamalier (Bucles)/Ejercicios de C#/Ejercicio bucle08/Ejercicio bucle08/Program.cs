namespace Ejercicio_bucle08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucle");


            int suma = 0;

            while (true)
            {
                Console.Write("Ingresa un número (0 para terminar): ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                    break;

                suma += numero;
            }

            Console.WriteLine($"La sumatoria es: {suma}");
        }
    }
}
