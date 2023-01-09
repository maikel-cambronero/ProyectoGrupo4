using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Clases
{
    public class caArticulo
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }

        public String Marca { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }
        public int Total { get; set; }


        public caArticulo HijoIzquierdo { get; set; }

        public caArticulo HijoDerecho { get; set; }

        public caArticulo()
        {
            Codigo = 0;
            Descripcion = "";
            Marca = "";
            Precio = 0;
            Cantidad = 0;
            Total = 0;
            HijoIzquierdo = null;
            HijoDerecho = null;
        }

        public caArticulo(int Codigo, string Descripcion, string Marca, int Precio, int Cantidad, int Total)
        {
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Total = Total;
            this.HijoIzquierdo = null;
            this.HijoDerecho = null;
        }
    }
}
