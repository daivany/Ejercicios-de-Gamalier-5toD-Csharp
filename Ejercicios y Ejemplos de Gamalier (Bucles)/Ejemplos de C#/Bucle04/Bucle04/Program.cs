namespace Bucle04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros enteros");
            Console.WriteLine();

            int numero;

            Console.WriteLine("Introduzca un numero entero");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                Console.WriteLine("Introduzca un numero entero: ");
                numero = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Ha introducido un numero negativo");
        }
    }
}
