using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Clases
{
    public class ccArticuloServicio
    {
        public static ccArticulo Primer_Item { get; set; }
        public int Cantidad { get; set; }

        public void Enqueue(ccArticulo NuevoArticulo) // Agregar
        {
            ccArticulo mNodo = Primer_Item;
            if (mNodo == null)
            {
                Primer_Item = NuevoArticulo;
                Primer_Item.Anterior = null;
                Primer_Item.Siguiente = null;
                Cantidad++;
            }
            else
            {
                for (mNodo = Primer_Item; mNodo.Siguiente != null; mNodo = mNodo.Siguiente)
                {

                }
                NuevoArticulo.Anterior = mNodo;
                mNodo.Siguiente = NuevoArticulo;
                Cantidad++;
            }
        }

        public bool Dequeue() // Quitar
        {
            if (Primer_Item != null)
            {
                Primer_Item = Primer_Item.Siguiente;
                Primer_Item.Anterior = null;
                Cantidad--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ccArticulo Peek() // Mostrar 
        {
            return Primer_Item;
        }

    } // Fin Código 
}
