namespace Bucle01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo de empleado");
            Console.WriteLine();

            double sueldo, total, promedio;
            total = 0;

            for (int i = 1; i <=3; i++)
            {
                Console.Write("Sueldo del empleado" + i);
                sueldo = Convert.ToDouble(Console.ReadLine());
                total = total + sueldo;
            }

            Console.WriteLine();

            promedio = total / 3;

            Console.WriteLine("El sueldo del empleado es" + promedio);    
        }  
            
            
    }
}
