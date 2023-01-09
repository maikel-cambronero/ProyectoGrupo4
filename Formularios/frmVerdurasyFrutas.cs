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
    public partial class frmVerdurasyFrutas : Form
    {
        clArticuloServicio AddArticulo = new clArticuloServicio();
        clArticulo newArticulo = new clArticulo();

        public frmVerdurasyFrutas()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnFrambuesas_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 0010;
            newArticulo.Descripcion = "Caja de Frambuesas";
            newArticulo.Marca = "Pithaya 100% Orgánica";
            newArticulo.Precio = 3550;
            newArticulo.Cantidad = Convert.ToInt32(txtCanFrambuesa.Text.ToString());
            txtCanFrambuesa.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnGranada_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 0011;
            newArticulo.Descripcion = "Granada Real Importada";
            newArticulo.Marca = "Pithaya 100% Orgánica";
            newArticulo.Precio = 5950;
            newArticulo.Cantidad = Convert.ToInt32(txtCanGranada.Text.ToString());
            txtCanGranada.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnAlcachofa_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 0012;
            newArticulo.Descripcion = "Alcachofa Importada";
            newArticulo.Marca = "Pithaya 100% Orgánica";
            newArticulo.Precio = 2915;
            newArticulo.Cantidad = Convert.ToInt32(txtCanAlcachofa.Text.ToString());
            txtCanAlcachofa.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnLechuga_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 0013;
            newArticulo.Descripcion = "Lechuga Aruluga";
            newArticulo.Marca = "Pithaya 100% Orgánica";
            newArticulo.Precio = 1200;
            newArticulo.Cantidad = Convert.ToInt32(txtCanLechuga.Text.ToString());
            txtCanLechuga.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnPiña_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 0014;
            newArticulo.Descripcion = "Piña Deshidratada";
            newArticulo.Marca = "Todo Natural";
            newArticulo.Precio = 720;
            newArticulo.Cantidad = Convert.ToInt32(txtCanPiña.Text.ToString());
            txtCanPiña.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }
    }
}
