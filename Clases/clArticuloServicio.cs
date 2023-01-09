using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGrupo4.Clases;

namespace ProyectoGrupo4.Clases
{
    public class clArticuloServicio 
    {
        public static clArticulo PrimerNodo { get; set; }
        private int Contador { get; set; } = 0;

        public int size()
        {
            return Contador;
        }

        public void AgregarArticulo(clArticulo Nodo)
        {
            clArticulo Aux = PrimerNodo;

            if (Aux == null)
            {
                PrimerNodo = Nodo;
                PrimerNodo.Siguiente = null;
                PrimerNodo.Anterior = null;
                Contador++;
            }
            else
            {
                for (Aux = PrimerNodo; Aux.Siguiente != null; Aux = Aux.Siguiente)
                {

                }

                Nodo.Anterior = Aux;
                Aux.Siguiente = Nodo;
                Nodo.Siguiente = null;
                Contador++;
            }
        }

        public  void Print()
        {
            clArticulo mL = new clArticulo();
            mL = PrimerNodo;
            while (mL != null)
            {
                Console.WriteLine(mL.Codigo + " "+ mL.Descripcion + " " + mL.Precio + " " + mL.Cantidad + "\n" );
                mL = mL.Siguiente;
            }
        }

        
    } // Fin de código
}
