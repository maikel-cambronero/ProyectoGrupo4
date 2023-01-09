using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Clases
{
    public class cpArticuloServicio
    {
        public static cpArticulo PrimerArticulo { get; set; }
        public int Cantidad = 0;

        public void push(cpArticulo NuevoArticulo)
        {
            if (PrimerArticulo == null)
            {
                PrimerArticulo = NuevoArticulo;
                NuevoArticulo.ArticuloAbajo = null;
                NuevoArticulo.ArticuloArriba = null;
                Cantidad++;
            }
            else
            {
                NuevoArticulo.ArticuloAbajo = PrimerArticulo;
                PrimerArticulo.ArticuloArriba = NuevoArticulo;
                PrimerArticulo = NuevoArticulo;
                PrimerArticulo.ArticuloArriba = null;
                Cantidad++;
            }
        }

        public bool pop()
        {
            if (Cantidad > 0)
            {
                PrimerArticulo = PrimerArticulo.ArticuloAbajo;
                PrimerArticulo.ArticuloArriba = null;
                Cantidad--;
                return true;
                Console.WriteLine("Hola Mundo");
            }
            else
            {
                return false;
            }
        }

        public cpArticulo peek()
        {
            return PrimerArticulo;
        }
    }
}
