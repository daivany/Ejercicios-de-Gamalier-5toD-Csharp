namespace Arreglo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arreglo");


            int[] arreglo1 = new int[10];
            int[] arreglo2 = new int[10];
            int[] arregloSuma = new int[10];

            Console.WriteLine("Ingrese 10 números enteros para el primer arreglo:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                arreglo1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese 10 números enteros para el segundo arreglo:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                arreglo2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                arregloSuma[i] = arreglo1[i] + arreglo2[i];
            }

           
            Console.WriteLine("\nLa suma de los elementos correspondientes de los dos arreglos es:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Suma de posición {i + 1}: {arreglo1[i]} + {arreglo2[i]} = {arregloSuma[i]}");
            }











        }
    }
}
