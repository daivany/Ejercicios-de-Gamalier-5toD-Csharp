namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo");

            Console.Write("Introduce el sueldo del empleado: ");
            double sueldo = double.Parse(Console.ReadLine());

            
            double descuentoAFP = sueldo * 0.0287; 
            double descuentoSFS = sueldo * 0.0304; 
            double sueldoBruto = sueldo - (descuentoAFP + descuentoSFS);

            double isr = 0;

            if (sueldoBruto <= 416220)
            {
                isr = 0;
            }
            else if (sueldoBruto <= 624329)
            {
                isr = (sueldoBruto - 416220) * 0.15;
            }
            else if (sueldoBruto <= 867123)
            {
                isr = 31216 + (sueldoBruto - 624329) * 0.20;
            }
            else
            {
                isr = 79776 + (sueldoBruto - 867123) * 0.25;
            }

        
            double sueldoNeto = sueldoBruto - isr;

           
            Console.WriteLine($"Sueldo: RD${sueldo}");
            Console.WriteLine($"Descuento AFP: RD${descuentoAFP:F2}");
            Console.WriteLine($"Descuento SFS: RD${descuentoSFS:F2}");
            Console.WriteLine($"ISR: RD${isr:F2}");
            Console.WriteLine($"Sueldo Neto: RD${sueldoNeto:F2}");
        }
    }
}
