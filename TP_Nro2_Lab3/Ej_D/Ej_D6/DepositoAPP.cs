using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_D.Ej_D6
{
    class DepositoAPP
    {

        static void Main(string[] args)
        {

            Articulo articulo1 = new Articulo("A001_Harina", 120, 120);
            Articulo articulo2 = new Articulo("A002_Aceite", 120, 200);
            Articulo articulo3 = new Articulo("A003_Gaseosa", 120, 20);
            Articulo articulo4 = new Articulo("A004_Fideos", 120, 50);
            Articulo articulo5 = new Articulo("A005_Queso", 120, 300);

            List<Articulo> listaArticulos = new List<Articulo>();

            listaArticulos.Add(articulo1);
            listaArticulos.Add(articulo2);
            listaArticulos.Add(articulo3);
            listaArticulos.Add(articulo4);
            listaArticulos.Add(articulo5);


            Deposito deposito1 = new Deposito("Deposito Alem","Alem 320",listaArticulos);

            List<Articulo> listaBajoStock = deposito1.articulosBajoStock();
            Console.WriteLine($"-------Articulos con bajo Stock en Deposito {deposito1.Nombre}--------");
            foreach (Articulo item in listaBajoStock)
            {
                Console.WriteLine(item.Codigo);
            }
        }
    }
}
