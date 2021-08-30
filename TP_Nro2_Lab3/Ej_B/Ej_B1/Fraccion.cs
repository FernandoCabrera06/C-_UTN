using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_B1
{
    class Fraccion
    {
        //PROPIEDAD Y ATRIBUTO EN LA MISMA DECLARACION
        public int Numerador
        { get; set; }
        public int Denominador
        { get; set; }


        //atributos
        //private int numerador;
        //private int denominador;

        //2 FORMAS DE METODOS GET Y SET PARA CUANDO DECLARO ATRIBUTOS

        //FORMA 1
        //public int Numerador
        //{
        //    get { return numerador; }
        //    set { numerador = value; }
        //}

        //FORMA 2 (insertada con el IDE)
        //public int Numerador { get => numerador; set => numerador = value; }
        //public int Denominador { get => denominador; set => denominador = value; }

        public Fraccion() { }
        public Fraccion(int numerador, int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion fraccion)
        {

            if (fraccion.Numerador == 0 || this.Numerador == 0 || fraccion.Denominador == 0 || this.Denominador == 0)
            {
                throw new FraccionException();
            }
            Fraccion resultado = new Fraccion();


            if (fraccion.Denominador == this.Denominador)
            {
                resultado.Numerador = this.Numerador + fraccion.Numerador;
                resultado.Denominador = this.Denominador;
            }
            else
            {
                int num = 1;
                while (!(((this.Denominador * num) % fraccion.Denominador) == 0))
                {
                    num++;
                }
                int nuevoDenom = num * this.Denominador;

                resultado.Numerador = (((nuevoDenom / this.Denominador) * this.Numerador) + ((nuevoDenom / fraccion.Denominador) * fraccion.Numerador));
                resultado.Denominador = (nuevoDenom);
            }


            return resultado;

        }

        public Fraccion Restar(Fraccion fraccion)
        {
            Fraccion resultado = new Fraccion();


            if (fraccion.Numerador == 0 || this.Numerador == 0 || fraccion.Denominador == 0 || this.Denominador == 0)
            {
                throw new FraccionException();
            }

            if (fraccion.Denominador == this.Denominador)
            {
                resultado.Numerador = this.Numerador - fraccion.Numerador;
                resultado.Denominador = this.Denominador;
            }
            else
            {
                int num = 1;
                while (!(((this.Denominador * num) % fraccion.Denominador) == 0))
                {
                    num++;
                }
                int nuevoDenom = num * this.Denominador;

                resultado.Numerador = (((nuevoDenom / this.Denominador) * this.Numerador) - ((nuevoDenom / fraccion.Denominador) * fraccion.Numerador));
                resultado.Denominador = (nuevoDenom);
            }

            return resultado;

        }

        public Fraccion Multiplicar(Fraccion fraccion)
        {

            if (fraccion.Numerador == 0 || this.Numerador == 0 || fraccion.Denominador == 0 || this.Denominador == 0)
            {
                throw new FraccionException();
            }
            Fraccion resultado = new Fraccion();
            resultado.Numerador = this.Numerador * fraccion.Numerador;
            resultado.Denominador = this.Denominador * fraccion.Denominador;
            return resultado;
        }

        public Fraccion Dividir(Fraccion fraccion)
        {

            if (fraccion.Numerador == 0 || this.Numerador == 0 || fraccion.Denominador == 0 || this.Denominador == 0)
            {
                throw new FraccionException();
            }
            Fraccion resultado = new Fraccion();
            resultado.Numerador = this.Numerador * fraccion.Denominador;
            resultado.Denominador = this.Denominador * fraccion.Numerador;
            return resultado;
        }
    }
}
