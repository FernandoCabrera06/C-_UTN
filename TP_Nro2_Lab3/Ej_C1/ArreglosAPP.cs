using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_C1
{
    class ArreglosAPP
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese cantidad de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            string[,] matriz = new string[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (((i+1) + (j+1)) == (filas + columnas))
                    {
                        matriz[i, j] = "X";
                    }
                    else
                    {
                        matriz[i, j] = "0";
                    }
                }
            }
            MostrarMatriz(matriz,filas,columnas);

        }
        public static void MostrarMatriz(string[,] matriz, int filas, int columnas) {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
