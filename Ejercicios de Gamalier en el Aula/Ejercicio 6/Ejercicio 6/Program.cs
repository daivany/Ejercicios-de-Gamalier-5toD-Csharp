using System.Runtime.InteropServices;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo");

            decimal importe, itbis, descuento, totalGeneral, precio;
           
            Console.Write("Introduzca el importe del articulo: ");
             importe = Convert.ToDecimal(Console.ReadLine());


            itbis = importe * 0.18m;

           
             descuento = importe * 0.10m;

            
             totalGeneral = (importe - descuento) + itbis;

            Console.WriteLine("\nImporte del artículo: {0:C}", importe);
            Console.WriteLine("ITBIS (18%): {0:C}", itbis);
            Console.WriteLine("Descuento (10%): {0:C}", descuento);
            Console.WriteLine("Total general: {0:C}", totalGeneral);


        }
    }
}
