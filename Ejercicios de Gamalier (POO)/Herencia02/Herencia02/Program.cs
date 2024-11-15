using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Herencia02.Prodcutos;

namespace Herencia02
{
    internal class Productos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("obtener datos del papel:");
            Console.Write("Nombre: ");
            string nombrePapel = Console.ReadLine();
            Console.Write("Precio: ");
            double precioPapel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tipo de Papel: ");
            string tipoPapel = Console.ReadLine();

            Papel papel = new Papel(nombrePapel, precioPapel, tipoPapel);

            
            Console.WriteLine("\nObtener datos del utensilio:");
            Console.Write("Nombre: ");
            string nombreUtensilio = Console.ReadLine();
            Console.Write("Precio: ");
            double precioUtensilio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Material: ");
            string material = Console.ReadLine();

            Utensilio utensilio = new Utensilio(nombreUtensilio, precioUtensilio, material);

            Console.WriteLine("\nDatos obtenidos de los productos:");
            papel.MostrarDatos();
            Console.WriteLine();
            utensilio.MostrarDatos();
        }
    }
}

        
