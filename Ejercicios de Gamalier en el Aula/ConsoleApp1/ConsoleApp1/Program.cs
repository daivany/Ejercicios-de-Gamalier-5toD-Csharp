namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca dos numeros");
            Console.WriteLine("numero 1: "); int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numeor 2: "); int numero2 = Convert.ToInt32(Console.ReadLine());

            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            double divi = numero1 / numero2;
            int multi = numero1 * numero2;

            Console.WriteLine("la suma de los dos numeros es: " + suma);
            Console.WriteLine($"la resta de {numero1} y  {numero2} es: {resta} ");
            Console.WriteLine($"la multiplicacion de {numero1} y  {numero2} es: {multi} ");
            Console.WriteLine($"la division de {numero1} y  {numero2} es: {divi} ");
        }
    }
}
