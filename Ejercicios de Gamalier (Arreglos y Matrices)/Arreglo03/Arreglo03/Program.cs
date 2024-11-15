namespace Arreglo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arreglo");

            List<int> numeros = new List<int>();
            int suma = 0;

            Console.WriteLine("Ingresa números. Para terminar e imprimir el resultado, ingresa un número que haga que la suma sea >= 100.");

            while (suma < 100)
            {
                Console.Write("Ingresa un número: ");
                int numero = int.Parse(Console.ReadLine());

                numeros.Add(numero); 
                suma += numero; 
                Console.WriteLine("Suma actual: " + suma);
            }

            Console.WriteLine("\nLa suma de los números es: " + suma);
        }

        }
      }
   

