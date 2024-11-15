using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia02
{
    internal class Prodcutos
    {
        public class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }

            public Producto(string nombre, double precio)
            {
                Nombre = nombre;
                Precio = precio;
            }

            public virtual void MostrarDatos()
            {
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Precio: {Precio}");
            }
        }

       
        public class Papel : Producto
        {
            public string TipoPapel { get; set; }

            public Papel(string nombre, double precio, string tipoPapel) : base(nombre, precio)
            {
                TipoPapel = tipoPapel;
            }

            public override void MostrarDatos()
            {
                base.MostrarDatos();
                Console.WriteLine($"Tipo de Papel: {TipoPapel}");
            }
        }

       
        public class Utensilio : Producto
        {
            public string Material { get; set; }

            public Utensilio(string nombre, double precio, string material) : base(nombre, precio)
            {
                Material = material;
            }

            public override void MostrarDatos()
            {
                base.MostrarDatos();
                Console.WriteLine($"Material: {Material}");
            }
        }

    }
}
