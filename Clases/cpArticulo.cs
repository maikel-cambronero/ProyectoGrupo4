using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Clases
{
    public  class cpArticulo
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }

        public String Marca { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }
        public int Total { get; set; }


        public cpArticulo ArticuloArriba { get; set; }

        public cpArticulo ArticuloAbajo { get; set; }

        public cpArticulo()
        {
            Codigo = 0;
            Descripcion = "";
            Marca = "";
            Precio = 0;
            Cantidad = 0;
            Total = 0;
            ArticuloArriba = null;
            ArticuloAbajo = null;
        }

        public cpArticulo(int Codigo, string Descripcion, string Marca, int Precio, int Cantidad, int Total)
        {
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Total = Total;
            this.ArticuloArriba = null;
            this.ArticuloAbajo = null;
        }
    }
}
