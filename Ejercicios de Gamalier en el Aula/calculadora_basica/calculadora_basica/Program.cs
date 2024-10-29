using System.Numerics;

namespace calculadora_basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Basica");
            Console.WriteLine();

            //Declaracion de variables
            double valor1, valor2, valor3, suma, resta, multiplica, divide;

            //Entrada de datos
            Console.Write("Introduzca el primer valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca el tercer valor: ");
            valor3 = Convert.ToDouble(Console.ReadLine());

            //Proceso
            suma = valor1 + valor2 + valor3;
            resta = valor1 - valor2 - valor3;
            multiplica = valor1 * valor2 * valor3;
            divide = valor1 / valor2/ valor3;

            //Salida de la informacion 
            Console.WriteLine("El resultado de la suma es {0}", suma);
            Console.WriteLine("El resultado de la resta es " + resta);
            Console.WriteLine($"El resultado de la multiplicacion es {multiplica} ");
            Console.WriteLine("El resultado de la division es " + divide.ToString());


        }
    }
}
