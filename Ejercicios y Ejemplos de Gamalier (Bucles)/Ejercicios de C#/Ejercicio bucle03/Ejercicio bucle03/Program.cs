namespace Ejercicio_bucle03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucle");

            int sumatoria = 0;

            while (sumatoria < 100)
            {
                Console.Write("Ingresa un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                sumatoria += numero;
            }

            Console.WriteLine("La sumatoria es mayor o igual a 100.");
        }
    }
}
