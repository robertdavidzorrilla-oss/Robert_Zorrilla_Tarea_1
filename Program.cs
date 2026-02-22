namespace SueldoEmpleado1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo  e  ISR");
            Console.WriteLine();

            Console.WriteLine("Ingrese el sueldo anual del empleado:");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine ("El sueldo del empleado es: " + sueldo);
            Console.WriteLine();

            if (sueldo >= 416220 && sueldo <= 634329)
            
            
            {

                double ISR = CalcularElISR(sueldo);

                Console.WriteLine("El ISR a pagar anualmente es: " + ISR);
                Console.WriteLine();

                double ISRM = CalcularISRmensual(ISR);
                Console.WriteLine("El ISR a pagar mensualmente es: " + ISRM);
            }
            else if  (sueldo >= 634329 && sueldo <= 867123)
            {
                double ISR = CalcularISR(sueldo);

                Console.WriteLine("El ISR a pagar anualmente es: " + ISR);
                Console.WriteLine();

                double ISRM = CalcularISRmensual(ISR);
                Console.WriteLine("El ISR a pagar mensualmente es: " + ISRM);


            }

            else if (sueldo >= 867123)
            {
                double ISR = CalcularISR2(sueldo);

                Console.WriteLine("El ISR a pagar anualmente es: " + ISR);
                Console.WriteLine();

                double ISRM = CalcularISRmensual(ISR);
                Console.WriteLine("El ISR a pagar mensualmente es: " + ISRM);

            }
            else
            {
                Console.WriteLine("ISR a pagar: No aplica ");

            }





        }


        static double CalcularElISR(double sueldo )
        {



            double ISR = (sueldo - 416222) * 0.15;
            return ISR;

        }

        static double CalcularISR(double sueldo)
        {
            double ISR = (sueldo - 634329) * 0.20;
            return ISR;

        }

        static double CalcularISR2(double sueldo)
        {
            double ISR = (sueldo - 867123) * 0.25;
            return ISR;


        }

        static double CalcularISRmensual(double ISR) 
        {
            double ISRM = ISR / 12;
            return ISRM;

        }
    }



}
