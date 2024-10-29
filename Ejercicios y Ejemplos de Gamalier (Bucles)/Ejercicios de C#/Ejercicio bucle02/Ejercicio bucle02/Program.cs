namespace Ejercicio_bucle02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucle");

            string contraseñaCorrecta = "daniels";
            int intentos = 3;

            while (intentos > 0)
            {
                Console.Write("Introduce la contraseña: ");
                string contraseña = (Console.ReadLine());

                if (contraseña == contraseñaCorrecta)
                {
                    Console.WriteLine("Contraseña correcta.");
                    return;
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Contraseña incorrecta. Intentos restantes: {intentos}");
                }
            }

            Console.WriteLine("Has agotado el número de intentos.");
        }
    }
}
    

