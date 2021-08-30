using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_C2
{
    class Arreglos2APP
    {

        static void Main(string[] args) {

            Console.WriteLine("Ingrese cadenad de numeros separados por coma: ");
            string listaNumeros = Console.ReadLine();

            string[]  vectorNumeros = listaNumeros.Split(',');
            int sumaValores = 0;
            for (int i = 0; i < vectorNumeros.Length; i++)
            {
               sumaValores += int.Parse(vectorNumeros[i]);
            }

            Console.WriteLine($"Suma total: {sumaValores}");
        }
    }
}
