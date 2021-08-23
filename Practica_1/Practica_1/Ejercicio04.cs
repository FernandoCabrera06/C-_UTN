using System;
namespace Practica_1
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {

            decimal valor1, valor2;
            string opcion;
            Console.Write("Ingrese valor 1: ");
            valor1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese valor 2: ");
            valor2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Elija opción de calculo: ");
            Console.WriteLine("[a]- Suma +" +
                " \n[b] - Resta –" +
                " \n[c] - Multiplicación *" +
                " \n[d] - División /" +
                " \n[e] - Modulo %");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "a":
                    {
                        Console.WriteLine($"Resultado: {sumar(valor1, valor2)}");
                        break;
                    }
                case "b":
                    {
                        Console.WriteLine($"Resultado: {restar(valor1, valor2)}");
                        break;
                    }
                case "c":
                    {
                        Console.WriteLine($"Resultado: {multiplicar(valor1, valor2)}");
                        break;
                    }
                case "d":
                    {
                        Console.WriteLine($"Resultado: {dividir(valor1, valor2)}");
                        break;
                    }
                case "e":
                    {
                        Console.WriteLine($"Resultado: {calcularModulo(valor1, valor2)}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("La opción ingresada no es válida");
                        break;
                    }

            }
        }

        static decimal sumar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        static decimal restar(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        static decimal multiplicar(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        static decimal dividir(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        static decimal calcularModulo(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
    }
}
