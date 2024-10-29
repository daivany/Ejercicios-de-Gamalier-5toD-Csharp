using System;

namespace Leer__numeros.sln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio");

            int n1, n2, n3, n4, n5, p;

            Console.WriteLine("introduzca el primer numero");n1=int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el segundo numero"); n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el tercer numero"); n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el cuarto numero"); n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el quinto  numero"); n5 = int.Parse(Console.ReadLine());

            p= (n1+n2+n3+n4+n5)/5;

            Console.WriteLine("El promedio de los numeros es " + p);
        }
    }
}
