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
    public partial class frmRefrigerados : Form
    {
        clArticuloServicio AddArticulo = new clArticuloServicio();
        clArticulo newArticulo = new clArticulo();

        public frmRefrigerados()
        {
            InitializeComponent();
        }

        private void btnTofu_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 5502;
            newArticulo.Descripcion = "Tofu Firme";
            newArticulo.Marca = "Mrinaga";
            newArticulo.Precio = 2360;
            newArticulo.Cantidad = Convert.ToInt32(txtCanTofu.Text.ToString());
            txtCanTofu.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnSalchichas_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 5503;
            newArticulo.Descripcion = "Salchicha Vegana";
            newArticulo.Marca = "Linda McCarney's";
            newArticulo.Precio = 3650;
            newArticulo.Cantidad = Convert.ToInt32(txtCanSalchicha.Text.ToString());
            txtCanSalchicha.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnNuggets_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 5504;
            newArticulo.Descripcion = "Nuggets Veganos";
            newArticulo.Marca = "Fry's";
            newArticulo.Precio = 2915;
            newArticulo.Cantidad = Convert.ToInt32(txtCanNuggets.Text.ToString());
            txtCanNuggets.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnAlbondigas_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 5505;
            newArticulo.Descripcion = "Albóndigas Venganas";
            newArticulo.Marca = "Heura";
            newArticulo.Precio = 3075;
            newArticulo.Cantidad = Convert.ToInt32(txtCanAlbondigas.Text.ToString());
            txtCanAlbondigas.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnQueso_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 5506;
            newArticulo.Descripcion = "Queso Rallado Vegano";
            newArticulo.Marca = "Violife";
            newArticulo.Precio = 2480;
            newArticulo.Cantidad = Convert.ToInt32(txtCanQueso.Text.ToString());
            txtCanQueso.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }
    }
}
