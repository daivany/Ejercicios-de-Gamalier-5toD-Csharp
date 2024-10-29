namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero Entero");

            Console.Write("Introduce un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
          

        }
    }
}
