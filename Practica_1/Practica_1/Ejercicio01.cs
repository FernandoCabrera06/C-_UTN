using System;

namespace Practica_1
{
    class Ejercicio01
    {
        static void Main(string[] args) {

            //-----------------------WHILE-------------------------
            int numero = 1;
    
            while (numero <= 100){
                if ((numero % 2 == 0) && (numero % 5 == 0))
                {
                    Console.Write($"{numero} ");
                }
                         numero++;
          }
            Console.WriteLine();


            //-----------------------FOR-------------------------
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2 == 0) && (i % 5 == 0))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();


            //-----------------------DO WHILE-------------------------
            int num = 1;
            do
            {
                if ((num % 2 == 0) && (num % 5 == 0))
                {
                    Console.Write($"{num} ");
                }
                num++;
            } while (num <= 100);
            Console.WriteLine();
        }
    }
}
