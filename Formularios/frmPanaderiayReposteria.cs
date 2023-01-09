using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupo4.Clases;

namespace ProyectoGrupo4.Formularios
{
    public partial class frmPanaderiayReposteria : Form
    {
        clArticuloServicio AddArticulo = new clArticuloServicio();
        clArticulo newArticulo = new clArticulo();

        public frmPanaderiayReposteria()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBarquillos_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 2209;
            newArticulo.Descripcion = "Barquillos de Frambuesa";
            newArticulo.Marca = "Diet Radisson";
            newArticulo.Precio = 1225;
            newArticulo.Cantidad = Convert.ToInt32(txtCanBarquillos.Text.ToString());
            txtCanBarquillos.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnTartaletas_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 2208;
            newArticulo.Descripcion = "Tartaletas de Frutas";
            newArticulo.Marca = "Pitahaya Market";
            newArticulo.Precio = 900;
            newArticulo.Cantidad = Convert.ToInt32(txtCanTartaletas.Text.ToString());
            txtCanTartaletas.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnPieManzana_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 2207;
            newArticulo.Descripcion = "Pie de Manzana Vegano";
            newArticulo.Marca = "Pitahaya Market";
            newArticulo.Precio = 1200;
            newArticulo.Cantidad = Convert.ToInt32(txtCanPie.Text.ToString());
            txtCanPie.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void bnPanCaibatta_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 2206;
            newArticulo.Descripcion = "Pan Cibatta Vegano";
            newArticulo.Marca = "Pitahaya Market";
            newArticulo.Precio = 1450;
            newArticulo.Cantidad = Convert.ToInt32(txtCanCiabatta.Text.ToString());
            txtCanCiabatta.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnPanCaja_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 2205;
            newArticulo.Descripcion = "Pan de Caja Vegano";
            newArticulo.Marca = "Pitahaya Market";
            newArticulo.Precio = 1450;
            newArticulo.Cantidad = Convert.ToInt32(txtCanPanCaja.Text.ToString());
            txtCanPanCaja.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }
    }
}
