namespace Calculo_sueldo.sln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de sueldo");
            Console.WriteLine();

            double pagoXHora, horasTrabajadas, afp = 0.0287, sfs = 0.0304,sueldoNeto, sueldoBruto;

            Console.Write("Introduzca el pago por hora: "); pagoXHora = double.Parse(Console.ReadLine());
            Console.Write("Introduzca horas trabajadas: "); horasTrabajadas = double.Parse(Console.ReadLine());

            sueldoBruto= pagoXHora * horasTrabajadas;

            double descuentos;

            afp = afp * sueldoBruto;
            sfs = sfs * sueldoBruto;
            descuentos = afp + sfs;

            sueldoNeto= sueldoBruto - descuentos;

            Console.WriteLine("El sueldo neto es " + Math.Round(sueldoNeto));




        }
    }
}
