namespace Ejercicio_bucle09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucle");


            Console.Write("Ingrese la altura del triángulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
