using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Clases
{
    public class caArticuloServicio
    {
        public static caArticulo raiz;
        int Peso;

        public caArticuloServicio()
        {
            raiz = null;
            Peso = 0;
        }

        public void AgregarNodo(caArticulo Nodo)
        {
            if (raiz == null)
            {
                raiz = Nodo;
                Peso++;
            }
            else
            {
                caArticulo mauxiliar = raiz;
                caArticulo mpadre;
                while (true)
                {
                    mpadre = mauxiliar;
                    if (Nodo.Precio <= mauxiliar.Precio)
                    {
                        mauxiliar = mauxiliar.HijoIzquierdo;
                        if (mauxiliar == null)
                        {
                            mpadre.HijoIzquierdo = Nodo;
                            Peso++;

                            return;
                        }
                    }
                    else
                    {
                        mauxiliar = mauxiliar.HijoDerecho;
                        if (mauxiliar == null)
                        {
                            mpadre.HijoDerecho = Nodo;
                            Peso++;
                            return;

                        }
                    }
                }
            }
        }

        public void preOrden(caArticulo mraiz)
        {
            if (mraiz != null)
            {
                Console.WriteLine(mraiz.Codigo + mraiz.Descripcion + " " + raiz.Precio);
                preOrden(mraiz.HijoIzquierdo);
                preOrden(mraiz.HijoDerecho);
            }
        }

        public caArticulo BuscarxPrecio(int Precio)
        {
            caArticulo Aux = raiz;
            while (Aux.Precio != Precio)
            {
                if (Precio < Aux.Precio)
                {
                    Aux = Aux.HijoIzquierdo;
                }
                else
                {
                    Aux = Aux.HijoDerecho;
                }
                if (Aux == null)
                {
                    return null;
                }
            }
            return Aux;
        }

    } // Fin de código
}
