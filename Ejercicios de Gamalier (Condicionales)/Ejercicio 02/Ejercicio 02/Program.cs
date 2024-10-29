namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precio");

            Console.Write("Introduce el precio del artículo: ");

            double precio = double.Parse(Console.ReadLine());
            double descuento = 0;

            if (precio >= 1000 && precio <= 5000)
            {
                descuento = precio * 0.03;
            }
            else if (precio >= 5001 && precio <= 10000)
            {
                descuento = precio * 0.05;
            }
            else if (precio >= 10001 && precio <= 15000)
            {
                descuento = precio * 0.08;
            }
            else if (precio >= 15001 && precio <= 20000)
            {
                descuento = precio * 0.10;
            }

            double precioFinal = precio - descuento;

            Console.WriteLine($"El precio del artículo es: {precio:C}");
            Console.WriteLine($"El descuento aplicado es: {descuento:C}");
            Console.WriteLine($"El precio final es: {precioFinal:C}");
        }
    }
}
