using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_B2
{
    class Cadenas
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese una cadena: ");
            string cadena1 = Console.ReadLine();
            Console.Write("Ingrese una cadena a buscar: ");
            string cadena2 = validarExtensionCadena(cadena1, Console.ReadLine());

            if (cadena1.Contains(cadena2))
            {
                Console.WriteLine("ENCONTRADO");
            }
            else
            {
                Console.WriteLine("NO ENCONTRADO");
            }

        }
        private static string validarExtensionCadena(string cadena1, string cadena2)
        {
            while (cadena2.Length > cadena1.Length)
            {
                Console.Write($"Ingrese una cadena menor o igual a {cadena1.Length} caracteres: ");
                cadena2 = Console.ReadLine();
            }
            return cadena2;
        }
    }
}
