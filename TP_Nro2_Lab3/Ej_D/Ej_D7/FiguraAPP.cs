using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_D.Ej_D7
{
    class FiguraAPP
    {
        static void Main(string[] args)
        {

            List<Figura> figuras = new List<Figura>();

            Rectangulo rect = new Rectangulo();
            Figura fig = new Figura();
            Circulo circ = new Circulo();
            Triangulo tria = new Triangulo();


            figuras.Add(rect);
            figuras.Add(fig);
            figuras.Add(circ);
            figuras.Add(fig);
            figuras.Add(tria);
            figuras.Add(fig);

            foreach (Figura item in figuras)
            {
                item.Dibujar();
            }
        }
    }
}
