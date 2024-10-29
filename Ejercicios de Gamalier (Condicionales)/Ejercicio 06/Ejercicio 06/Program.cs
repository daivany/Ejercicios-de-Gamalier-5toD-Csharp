namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero entero");

            Console.Write("Introduce un número entero: ");
            int numero = int.Parse(Console.ReadLine());

           
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
    }
}
