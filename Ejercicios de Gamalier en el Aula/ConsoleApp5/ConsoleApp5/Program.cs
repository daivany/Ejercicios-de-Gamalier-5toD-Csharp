namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad");

            double cantidad, precio, importe;

            Console.WriteLine("introduzca la cantidad del articulo"); cantidad = double.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el precio del articulo"); precio = double.Parse(Console.ReadLine());

            importe = cantidad * precio;

            Console.WriteLine("El calculo del importe es " + importe);
        }
    }
}
