using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_B1
{
    class Fraccion
    {

        //atributos
        private int numerador;
        private int denominador;

        public Fraccion() { }
        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }


        //3 FORMAS DE METODOS GET Y SET

        //FORMA 1
        //public int Numerador
        //{
        //    get { return numerador; }
        //    set { numerador = value; }
        //}

        //FORMA 2 (insertada con el IDE)
        public int Numerador { get => numerador; set => numerador = value; }
        public int Denominador { get => denominador; set => denominador = value; }

        //FORMA 3 (no me funciona!)
        //public int Numerador
        //{ get; set; }
        //public int Denominador
        //{ get; set; }


        public Fraccion Sumar(Fraccion fraccion)
        {

            if (fraccion.numerador == 0 || this.numerador == 0 || fraccion.denominador == 0 || this.denominador == 0)
            {
                throw new FraccionException();
            }
            Fraccion resultado = new Fraccion();


            if (fraccion.denominador == this.denominador)
            {
                resultado.numerador = this.numerador + fraccion.numerador;
                resultado.denominador = this.denominador;
            }
            else
            {
                int num = 1;
                while (!(((this.denominador * num) % fraccion.denominador) == 0))
                {
                    num++;
                }
                int nuevoDenom = num * this.denominador;

                resultado.numerador = (((nuevoDenom / this.denominador) * this.numerador) + ((nuevoDenom / fraccion.denominador) * fraccion.numerador));
                resultado.denominador = (nuevoDenom);
            }


            return resultado;

        }

        public Fraccion Restar(Fraccion fraccion)
        {
            Fraccion resultado = new Fraccion();


            if (fraccion.numerador == 0 || this.numerador == 0 || fraccion.denominador == 0 || this.denominador == 0)
            {
                throw new FraccionException();
            }

            if (fraccion.denominador == this.denominador)
            {
                resultado.numerador = this.numerador - fraccion.numerador;
                resultado.denominador = this.denominador;
            }
            else
            {
                int num = 1;
                while (!(((this.denominador * num) % fraccion.denominador) == 0))
                {
                    num++;
                }
                int nuevoDenom = num * this.denominador;

                resultado.numerador = (((nuevoDenom / this.denominador) * this.numerador) - ((nuevoDenom / fraccion.denominador) * fraccion.numerador));
                resultado.denominador = (nuevoDenom);
            }

            return resultado;

        }

        public Fraccion Multiplicar(Fraccion fraccion)
        {

            if (fraccion.numerador == 0 || this.numerador == 0 || fraccion.denominador == 0 || this.denominador == 0)
            {
                throw new FraccionException();
            }
            Fraccion resultado = new Fraccion();
            resultado.numerador = this.numerador * fraccion.numerador;
            resultado.denominador = this.denominador * fraccion.denominador;
            return resultado;
        }

        public Fraccion Dividir(Fraccion fraccion)
        {

            if (fraccion.numerador == 0 || this.numerador == 0 || fraccion.denominador == 0 || this.denominador == 0)
            {
                throw new FraccionException();
            }
            Fraccion resultado = new Fraccion();
            resultado.numerador = this.numerador * fraccion.denominador;
            resultado.denominador = this.denominador * fraccion.numerador;
            return resultado;
        }
    }
}
