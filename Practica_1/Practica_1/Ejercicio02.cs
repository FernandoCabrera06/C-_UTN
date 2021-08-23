using System;

namespace Practica_1
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int numero = r.Next(0, 101);
            int contador = 1;
            Console.WriteLine($"Número aleatorio generado: {numero}");
            Console.WriteLine("Ingrese un número entre 0 y 100.");
            int numeroIngresado = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numero Ingresado: {numeroIngresado}");

            while (numero != numeroIngresado)
            {

                if (numero > numeroIngresado)
                {
                    Console.WriteLine("Respuesta: Es muy bajo");
                }
                else
                {
                    Console.WriteLine("Respuesta: Es muy alto");
                }
                Console.WriteLine("\nIngrese un número entre 0 y 100.");
                numeroIngresado = int.Parse(Console.ReadLine());
                contador++;
            }
            Console.WriteLine($"Respuesta: Correcto, numero encontrado, cantidad de intentos {contador}");
        }
    }
}

