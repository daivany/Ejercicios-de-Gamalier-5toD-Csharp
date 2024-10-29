namespace Ejercicio_bucle07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucle");

            Console.Write("Ingresa un número para mostrar su tabla de multiplicar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
