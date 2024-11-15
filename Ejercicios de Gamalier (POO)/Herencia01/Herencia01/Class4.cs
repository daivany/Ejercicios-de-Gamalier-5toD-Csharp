using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    internal class Tranporte
    {
        public abstract class Transporte
        {
            public string Destino { get; set; }
            public double Tiempo { get; set; } 
            public double Distancia { get; set; } 
            public double CostoBase { get; set; } 

         
            public virtual double CalcularCosto()
            {
                return Distancia * CostoBase;
            }

         
            public void MostrarBoleto()
            {
                Console.WriteLine($"Destino: {Destino}");
                Console.WriteLine($"Tiempo de viaje: {Tiempo} minutos");
                Console.WriteLine($"Distancia: {Distancia} km");
                Console.WriteLine($"Costo del boleto: ${CalcularCosto():0.00}");
            }
        }

    
        public class Taxi : Transporte
        {
            public Taxi()
            {
                CostoBase = 1.50; 
            }

            public override double CalcularCosto()
            {
             
                double tarifaAdicional = Tiempo * 0.05;
                return base.CalcularCosto() + tarifaAdicional;
            }
        }

     
        public class Metro : Transporte
        {
            public Metro()
            {
                CostoBase = 0.50; 
            }
             
            public override double CalcularCosto()
            {
               
                return 10.0;
            }
        }

        public class Teleferico : Transporte
        {
            public Teleferico()
            {
                CostoBase = 2.00; 
            }
        }

       
        public class BusUrbano : Transporte
        {
            public BusUrbano()
            {
                CostoBase = 0.75; 
            }
        }

      
        public class BusInterurbano : Transporte
        {
            public BusInterurbano()
            {
                CostoBase = 1.00; 
            }

            public override double CalcularCosto()
            {
             
                double tarifaAdicional = Distancia > 50 ? Distancia * 0.10 : 0;
                return base.CalcularCosto() + tarifaAdicional;
            }
        }


    }
}
