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
    public partial class frmBebidas : Form
    {
        clArticuloServicio AddArticulo = new clArticuloServicio();
        clArticulo newArticulo = new clArticulo();

        public frmBebidas()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnLeche_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 4563;
            newArticulo.Descripcion = "Leche De Almendras";
            newArticulo.Marca = "Natura";
            newArticulo.Precio = 970;
            newArticulo.Cantidad = Convert.ToInt32(txtCanLeche.Text.ToString());
            txtCanLeche.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnNectar_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 9813;
            newArticulo.Descripcion = "Néctar De Melocotón";
            newArticulo.Marca = "Diet Radisson";
            newArticulo.Precio = 1860;
            newArticulo.Cantidad = Convert.ToInt32(txtCanNectar.Text.ToString());
            txtCanNectar.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnAvena_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 4532;
            newArticulo.Descripcion = "Avena Con Chocolate";
            newArticulo.Marca = "Riso Scotti";
            newArticulo.Precio = 1260;
            newArticulo.Cantidad = Convert.ToInt32(txtCanAvena.Text.ToString());
            txtCanAvena.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnCacao_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 3402;
            newArticulo.Descripcion = "Chocolate En Polvo";
            newArticulo.Marca = "Natruly";
            newArticulo.Precio = 4250;
            newArticulo.Cantidad = Convert.ToInt32(txtCanCacao.Text.ToString());
            txtCanCacao.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void btnTrVerde_Click(object sender, EventArgs e)
        {
            newArticulo.Codigo = 2201;
            newArticulo.Descripcion = "Té Verde Con Menta";
            newArticulo.Marca = "Twinings";
            newArticulo.Precio = 2360;
            newArticulo.Cantidad = Convert.ToInt32(txtCanTeVerde.Text.ToString());
            txtCanTeVerde.Text = "";

            AddArticulo.AgregarArticulo(newArticulo);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
