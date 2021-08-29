using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_B1
{
    class FracionAPP
    {

        static void Main(string[] args)
        {

            Fraccion fraccion1 = new Fraccion(0, 8); //cambiar el 0 por 3 para probar funcionamiento.
            Fraccion fraccion2 = new Fraccion(1, 6);

            Fraccion resultanteSuma = fraccion1.Sumar(fraccion2);
            Fraccion resultanteResta = fraccion1.Restar(fraccion2);
            Fraccion resultanteMultiplicacion = fraccion1.Multiplicar(fraccion2);
            Fraccion resultanteDivision = fraccion1.Dividir(fraccion2);

            Console.WriteLine($"Resultado suma: {resultanteSuma.Numerador}/{resultanteSuma.Denominador}");
            Console.WriteLine($"Resultado resta: {resultanteResta.Numerador}/{resultanteResta.Denominador}");
            Console.WriteLine($"Resultado multiplicación: {resultanteMultiplicacion.Numerador}/{resultanteMultiplicacion.Denominador}");
            Console.WriteLine($"Resultado división: {resultanteDivision.Numerador}/{resultanteDivision.Denominador}");

        }
    }
}
