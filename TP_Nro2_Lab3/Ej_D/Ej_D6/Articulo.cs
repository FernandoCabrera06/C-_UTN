using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_D.Ej_D6
{
    class Articulo
    {
        public string Codigo
        { get; set; }

        public double StockTotal
        { get; set; }
        public double StockMinimo
        { get; set; }

        //relación
        public Deposito Deposito
        { get; set; }

        //constructores
        public Articulo()
        {
        }

        public Articulo(string codigo, double stockTotal, double stockMinimo)
        {
            Codigo = codigo;
            StockTotal = stockTotal;
            StockMinimo = stockMinimo;
        }

       
    }
}
