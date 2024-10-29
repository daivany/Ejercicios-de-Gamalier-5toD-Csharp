namespace Ejercicio_bucle01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucle");

            int positivos = 0, negativos = 0, pares = 0, impares = 0;
            Console.Write("Ingresa los numeros que desees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0) positivos++;
                else if (numero < 0) negativos++;

                if (numero % 2 == 0) pares++;
                else impares++;
            }

            Console.WriteLine($"Positivos: {positivos}, Negativos: {negativos}, Pares: {pares}, Impares: {impares}");
        
        }
    }
}
