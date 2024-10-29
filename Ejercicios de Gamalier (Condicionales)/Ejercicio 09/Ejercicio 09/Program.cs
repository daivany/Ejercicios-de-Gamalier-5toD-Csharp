namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Introduce el primer número entero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número entero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número entero: ");
            int numero3 = int.Parse(Console.ReadLine());

          
            int mayor, menor, centro;

            if (numero1 >= numero2 && numero1 >= numero3)
            {
                mayor = numero1;
                if (numero2 <= numero3)
                {
                    menor = numero2;
                    centro = numero3;
                }
                else
                {
                    menor = numero3;
                    centro = numero2;
                }
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
                if (numero1 <= numero3)
                {
                    menor = numero1;
                    centro = numero3;
                }
                else
                {
                    menor = numero3;
                    centro = numero1;
                }
            }
            else
            {
                mayor = numero3;
                if (numero1 <= numero2)
                {
                    menor = numero1;
                    centro = numero2;
                }
                else
                {
                    menor = numero2;
                    centro = numero1;
                }
            }

            
            Console.WriteLine($"El número mayor es: {mayor}");
            Console.WriteLine($"El número menor es: {menor}");
            Console.WriteLine($"El número del medio es: {centro}");
        }
    }
}
