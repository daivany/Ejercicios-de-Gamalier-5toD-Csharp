namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edad");


            Console.Write("Introduce tu edad: ");
            int edad = int.Parse(Console.ReadLine());


            Console.Write("Introduce tu sexo (M para masculino, F para femenino): ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());


            if (edad >= 18)
            {
                if (sexo == 'F')
                {
                    Console.WriteLine("Puedes entrar gratis."); 
                }
                else if (sexo == 'M')
                {
                    Console.WriteLine("Puedes entrar, pero tienes que pagar.");
                }
                else
                {
                    Console.WriteLine("Sexo no valido. Solo se acepta 'M' o 'F'.");
                }
            }
            else
            {
                Console.WriteLine("No puedes entrar, eres menor de edad.");
            }
        }
    }
}

            
            
        

    
