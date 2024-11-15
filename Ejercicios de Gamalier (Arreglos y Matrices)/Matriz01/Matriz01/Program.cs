namespace Matriz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz");

            int[,] inventario = {
            { 10, 15, 12 }, // Televisores
            { 8, 25, 5 },   // Laptops
            { 20, 7, 9 },   // Teléfonos
            { 14, 30, 6 }   // Tablets
        };

            string[] dispositivos = { "Televisores", "Laptops", "Teléfonos", "Tablets" };

            int numDispositivos = inventario.GetLength(0);
            int numAlmacenes = inventario.GetLength(1);

            for (int j = 0; j < numAlmacenes; j++)
            {
                int totalPorAlmacen = 0;
                int maxCantidad = int.MinValue;
                int minCantidad = int.MaxValue;
                int indiceMax = -1;
                int indiceMin = -1;

                for (int i = 0; i < numDispositivos; i++)
                {
                    totalPorAlmacen += inventario[i, j];

                    if (inventario[i, j] > maxCantidad)
                    {
                        maxCantidad = inventario[i, j];
                        indiceMax = i;
                    }

                    if (inventario[i, j] < minCantidad)
                    {
                        minCantidad = inventario[i, j];
                        indiceMin = i;
                    }
                }

                Console.WriteLine($"Almacén {j + 1}:");
                Console.WriteLine($"  Total de dispositivos: {totalPorAlmacen}");
                Console.WriteLine($"  Dispositivo con mayor cantidad: {dispositivos[indiceMax]} (Cantidad: {maxCantidad})");
                Console.WriteLine($"  Dispositivo con menor cantidad: {dispositivos[indiceMin]} (Cantidad: {minCantidad})");
                Console.WriteLine();
            }
        }
    }
}
    
