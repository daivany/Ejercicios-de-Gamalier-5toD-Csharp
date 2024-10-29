namespace Arreglo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz2");


            int[,] inventario = {
            { 50, 30, 20 },  
            { 25, 40, 10 },  
            { 60, 20, 15 }, 
            { 10, 15, 25 }   
        };

            int numDispositivos = inventario.GetLength(0);
            int numAlmacenes = inventario.GetLength(1);

            for (int j = 0; j < numAlmacenes; j++)
            {
                int totalAlmacen = 0;
                int maxCantidad = int.MinValue;
                int minCantidad = int.MaxValue;
                int dispositivoMax = 0;
                int dispositivoMin = 0;

                for (int i = 0; i < numDispositivos; i++)
                {
                    totalAlmacen += inventario[i, j];

                   
                    if (inventario[i, j] > maxCantidad)
                    {
                        maxCantidad = inventario[i, j];
                        dispositivoMax = i;
                    }

                    if (inventario[i, j] < minCantidad)
                    {
                        minCantidad = inventario[i, j];
                        dispositivoMin = i;
                    }
                }

                Console.WriteLine($"\nAlmacén {j + 1}:");
                Console.WriteLine($"Total de dispositivos: {totalAlmacen}");
                Console.WriteLine($"Dispositivo con mayor cantidad: {ObtenerNombreDispositivo(dispositivoMax)} ({maxCantidad})");
                Console.WriteLine($"Dispositivo con menor cantidad: {ObtenerNombreDispositivo(dispositivoMin)} ({minCantidad})");
            }
        }


        static string ObtenerNombreDispositivo(int indice)
        {
            switch (indice)
            {
                case 0: return "Televisores";
                case 1: return "Laptops";
                case 2: return "Teléfonos";
                case 3: return "Tablets";
                default: return "Desconocido";
            }
        }
    }

}
