using System;

namespace Practica_1
{
    class Ejercicio05
    {
        static void Main(string[] args)
        {

            double horaIngreso, minIngreso, ingresoEnMin, horaSalida, minSalida, salidaEnMin;

            Console.WriteLine("----INGRESO----");
            Console.Write("Hora: ");
            horaIngreso = double.Parse(Console.ReadLine());
            Console.Write($"Minutos: ");
            minIngreso = double.Parse(Console.ReadLine());
            Console.WriteLine("**********************");
            Console.WriteLine($"*  Ingreso: {horaIngreso}:{minIngreso}hs  *");
            Console.WriteLine("**********************");
            Console.WriteLine("\n----SALIDA----");

            Console.Write("Hora: ");
            horaSalida = double.Parse(Console.ReadLine());
            horaSalida = validarHoraSalida(horaIngreso, horaSalida);


            Console.Write($"Minutos: ");
            minSalida = double.Parse(Console.ReadLine());
            minSalida = validarMinSalida(horaIngreso, minIngreso, horaSalida, minSalida);

            Console.WriteLine("*********************");
            Console.WriteLine($"*  Salida: {horaSalida}:{minSalida}hs  *");
            Console.WriteLine("*********************");
            ingresoEnMin = (horaIngreso * 60) + minIngreso;
            salidaEnMin = (horaSalida * 60) + minSalida;
            double totalMinutos = (salidaEnMin - ingresoEnMin);
            calcularMontoAPagar(salidaEnMin, ingresoEnMin, horaIngreso, horaSalida, totalMinutos);




        }


        public static void calcularMontoAPagar(double salidaEnMin, double ingresoEnMin, double horaIngreso, double horaSalida, double totalMinutos)
        {



            if ((salidaEnMin - ingresoEnMin) > (8 * 60))
            {
                Console.WriteLine("Los horarios ingresados superan las 8 horas maximas permitidas!\n");
            }
            else
            {
                if ((horaIngreso >= 8) && (horaSalida < 20))
                {
                    Console.WriteLine($"El monto total a pagar por {totalMinutos / 60.0} hs Diurnas es: ${(totalMinutos / 60) * 10}");
                }
                else
                {
                    Console.WriteLine($"El monto total a pagar por {totalMinutos / 60.0} hs Nocturnas es: ${(totalMinutos / 60) * 15}");

                }
            }
        }
        public static double validarHoraSalida(double horaIN, double horaOUT)
        {

            while (horaIN > horaOUT)
            {
                Console.WriteLine("Hora no puede ser menor a la de ingreso!");
                Console.Write("Hora: ");
                horaOUT = double.Parse(Console.ReadLine());
            }
            return horaOUT;

        }
        public static double validarMinSalida(double horaIN, double minIN, double horaOUT, double minOUT)
        {

            while ((minIN > minOUT) && (horaIN == horaOUT))
            {
                Console.WriteLine("La hora es igual a la de ingreso, ingrese mas minutos!");
                Console.Write($"Minutos: ");
                minOUT = double.Parse(Console.ReadLine());
            }
            return minOUT;
        }
    }
}

