using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Clases_y_Objetos;
namespace Clases_y_Objetos
{
     internal class Clases_y_Objetos_   
    {
       static void Main(string[] args)
       {
            Dispositivo dispositivo = new Dispositivo();
            Console.WriteLine("Escriba el tipo del dispositivo");
            dispositivo.Tipo = (Console.ReadLine());

            Console.WriteLine("Escriba el color del dispositivo");
            dispositivo.Color = (Console.ReadLine());

            Console.WriteLine("Escriba la marca del dispositivo");
            dispositivo.Marca = (Console.ReadLine());

            dispositivo.prender();
            dispositivo.llamar();

       }
     }
}
