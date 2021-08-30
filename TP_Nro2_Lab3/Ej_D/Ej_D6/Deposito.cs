using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_D.Ej_D6
{
    class Deposito
    {

        public string Nombre
        { get; set; }

        public string Domicilio
        { get; set; }

        //relación
        public List<Articulo> Articulos
        { get; set; }


        //constructores

        public Deposito()
        {
        }

        public Deposito(string nombre, string domicilio, List<Articulo> articulos)
        {
            Nombre = nombre;
            Domicilio = domicilio;
            Articulos = articulos;
        }


        public List<Articulo> articulosBajoStock() {

            List<Articulo> listaBajoStock = new List<Articulo>();

            foreach (Articulo articulo in Articulos)
            {
                if (articulo.StockTotal >= articulo.StockMinimo ) {
                    listaBajoStock.Add(articulo);
                }
            }
            return listaBajoStock;
        }
    }
}
