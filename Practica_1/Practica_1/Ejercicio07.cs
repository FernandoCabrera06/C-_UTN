using System;
using System.Text;

namespace Practica_1
{
    class Ejercicio07
    {
        static void Main(string[] args) {

            string cadena="Programación en C#";
            Console.WriteLine($"Cadena ingresada: {cadena}\n");

            //metodo Lenght: devuelve la cantidad de caracteres de una cadena incluidos los espacios.
            Console.WriteLine($"Cantidad de caracteres: {cadena.Length}\n");

            //metodo Contains: devuelve true o false si una cadena contiene a la que le pasemos por parametro.
            Console.WriteLine($"La cadena contiene el texto \"C#\" ?: {cadena.Contains("C#")}\n");

            //metodo IndexOf: Devuelve la posicion donde encuentra por primera vez a un
            //caracter que le pasemos como parametro.
            Console.WriteLine($"El primer caracter 'a' se encuentra en la posición : {cadena.IndexOf('a')}\n");

            //metodo Remove: remueve los caracteres a partir de la posicion indicada (contando desde 1) como primer
            //entero como parametro hasta el final o tambien podemos indicarle la cantidad de caracteres a borrar
            //con un segundo entero como parametro.
            Console.WriteLine($"A partir del 4 caracter, Remover 8 caracteres: {cadena.Remove(4,8)}\n");

            //metodo Replace: reemplaza el primer caracter que coincida con el parametro char por otro
            //caracter que indicamos en el segundo parametro.
            Console.WriteLine($"reemplaza el primer caracter 'o' por 'A': {cadena.Replace('o','A')}\n");

            //metodo Substring: devuelve la cadena desde y hasta el indice que le indiquemos con un parametro
            //entero para el inicio y un parametro para el fin. tambien podemos indicar solo un indice de inicio
            //y devolvera desde ahí hasta el final 
            Console.WriteLine($"Cadena desde el indice 3 al 12: {cadena.Substring(3,12)}\n");

            //metodo Append pertenece a StringBuilder (sirve para la construccion de strings modificando
            //las cadenas en la misma posición de memoria en la que se encuentran ya que string no tiene
            //esa capacidad por ser inmutable). Append 1 de las cosas que hace es concatenar la cadena que
            //le pasemos por parametro con la cadena original y guardarla en su posición de memoria.

            StringBuilder cadenaBuilder = new StringBuilder(cadena);
            Console.WriteLine($"Cadena builder, metodo Append: {cadenaBuilder.Append(", metodos de cadenas.")}\n");

            //metodo ToUpper: convierte toda la cadena a mayúsculas.
            Console.WriteLine($"Cadena en mayúsculas: {cadena.ToUpper()}\n");

            //metodo ToLower: convierte toda la cadena a minúsculas.
            Console.WriteLine($"Cadena en minúsculas: {cadena.ToLower()}\n");
        }
    }
}
