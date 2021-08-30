using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_E
{
    class HilosAPP
    {
        static void Main(string[] args)
        {

            Thread t = new Thread(ejecutarHiloCincoSeg);
            Thread t2 = new Thread(ejecutarHiloDiezSeg);

            t.Start();
            t2.Start();

            t.Join();
            t2.Join();

        }

        public static void ejecutarHiloCincoSeg()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HILO EJECUTADO 5");
                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }

        public static void ejecutarHiloDiezSeg()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HILO EJECUTADO 10");
                Thread.Sleep(TimeSpan.FromSeconds(10));
            }
        }
    }
}
