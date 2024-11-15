namespace Matriz_Teatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tecnica");

            char[,] asientos = new char[10, 10];
            InicializarAsientos(asientos);

            while (true)
            {
                Console.Clear();
                MostrarAsientos(asientos);

                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Reservar asiento");
                Console.WriteLine("2. Ver mapa de asientos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)

                {
                    case "1":
                        ReservarAsiento(asientos);
                        break;
                    case "2":
                        MostrarAsientos(asientos);
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }

        static void InicializarAsientos(char[,] asientos)
        {
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    asientos[i, j] = 'L'; 
                }
            }
        }

        static void MostrarAsientos(char[,] asientos)
        {
            Console.WriteLine("Mapa de asientos:");
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    Console.Write(asientos[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ReservarAsiento(char[,] asientos)
        {
            Console.Write("Ingrese la fila (1-10): ");
            int fila = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Ingrese el asiento (1-10): ");
            int asiento = Convert.ToInt32(Console.ReadLine()) - 1;

          
            if (asientos[fila, asiento] == 'L')
            {
                asientos[fila, asiento] = 'X';
                Console.WriteLine("Asiento reservado con éxito.");
            }
            else
            {
                Console.WriteLine("El asiento ya está ocupado. Intente con otro asiento.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
    

