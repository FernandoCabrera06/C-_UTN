using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_B1
{
    public class FraccionException : Exception
    {
        public FraccionException()

        {
            Console.WriteLine("El numerador y/o denominador no pueden ser cero");
        }


    }
}

