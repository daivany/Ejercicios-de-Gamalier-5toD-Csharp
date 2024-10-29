namespace Bucle05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero entero");

            int numero;

            do
            {
                Console.Write("Introduzca un numero entero ");
                numero = Convert.ToInt32(Console.ReadLine());
            }while (numero > 0);  
        }
    }
}