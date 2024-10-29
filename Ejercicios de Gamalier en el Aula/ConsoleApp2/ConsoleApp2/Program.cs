namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Introduzca su edad");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("Eres mayor de edad");

                }
                else
                {
                    Console.WriteLine("Eres menor de edad");
                }
            }
        }
    }
}
