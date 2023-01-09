using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Clases
{
    public class ccArticulo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }

        public ccArticulo Siguiente { get; set; }
        public ccArticulo Anterior { get; set; }

        public ccArticulo()
        {
            Codigo = 0;
            Descripcion = "";
            Marca = "";
            Precio = 0;
            Cantidad = 0;

            Siguiente = null;
            Anterior = null;
        }

        public ccArticulo (int Codigo, string Descripcion, string Marca, int Precio, int Cantidad, int Total)
        {
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Total = Total;
            this.Siguiente = null;
            this.Anterior = null;
        }
    }
}
