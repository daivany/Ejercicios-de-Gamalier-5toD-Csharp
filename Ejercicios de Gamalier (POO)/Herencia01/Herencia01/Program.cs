using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Herencia01.Tranporte;
namespace Herencia01
{
    internal class Transporte
    {
        static void Main(string[] args)
        {

            Taxi taxi = new Taxi { Destino = "Barrio lindo", Tiempo = 30, Distancia = 10 };
            Console.WriteLine("Taxi:");
            taxi.MostrarBoleto();

            Metro metro = new Metro { Destino = "Santa Fe", Tiempo = 15, Distancia = 5 };
            Console.WriteLine("\nMetro:");
            metro.MostrarBoleto();

            Teleferico teleferico = new Teleferico { Destino = "Palo de azucar", Tiempo = 20, Distancia = 3 };
            Console.WriteLine("\nTeleférico:");
            teleferico.MostrarBoleto();

            BusUrbano busUrbano = new BusUrbano { Destino = "Miramar", Tiempo = 25, Distancia = 7 };
            Console.WriteLine("\nBus Urbano:");
            busUrbano.MostrarBoleto();

            BusInterurbano busInterurbano = new BusInterurbano { Destino = "Villa Faro", Tiempo = 60, Distancia = 100 };
            Console.WriteLine("\nBus Interurbano:");
            busInterurbano.MostrarBoleto();
        }
    }
}
    

