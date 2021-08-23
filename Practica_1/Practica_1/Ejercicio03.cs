using System;

namespace Practica_1
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero: ");
            if (esPar(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("El numero ingresado es PAR");
            }
            else {
                Console.WriteLine("Incorrecto, NO es PAR");
            }
        
        }
        static bool esPar(int num) {

            return (num % 2 == 0);
        }
        }
}
