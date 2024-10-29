using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Objetos
{
    public class Dispositivo
    {
        public string Tipo { get; set; }

        public string Color { get; set; }

        public string Marca { get; set; }


        public void prender()
        {
            Console.WriteLine($"el dispositivo se prendio");

        }

        public void llamar()
        {
            Console.WriteLine($"el dispositivo llama");
        }
    }
}
