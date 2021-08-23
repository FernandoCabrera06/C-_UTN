using System;

namespace Practica_1
{
    class Ejercicio06
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor: ");
            decimal valor = validarValor(int.Parse(Console.ReadLine()));
            int contador = 1;

            calcularConRecursion(valor, contador);
            Console.WriteLine("Fin Recursión");
        }



        static decimal validarValor(decimal valor)
        {
            decimal valorIngresado = valor;
            while (valorIngresado <= 1)
            {
                Console.Write("Ingrese un valor mayor a 1: ");
                valorIngresado = int.Parse(Console.ReadLine());
            }
            return valorIngresado;
        }
        static void calcularConRecursion(decimal valor, int contador)
        {

            if (valor < 100000000)
            {
                Console.WriteLine($"{contador} iteración => {valor}*{valor} = {valor * valor}");
                valor = valor * valor;
                contador++;
                calcularConRecursion(valor, contador);

            }

        }
    }
}
