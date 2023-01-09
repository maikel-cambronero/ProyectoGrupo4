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
    public partial class frmAbarrotes : Form
    {
        public static clArticuloServicio mAddArticuloAbarrote = new clArticuloServicio();
        
        public frmAbarrotes()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAceiteCoco_Click(object sender, EventArgs e)
        {
            fnAceite();
        }
        public void fnAceite()
        {
            clArticulo mNewArticuloAbarrote = new clArticulo();
            mNewArticuloAbarrote.Codigo = 1981;
            mNewArticuloAbarrote.Descripcion = "Aceite De Coco";
            mNewArticuloAbarrote.Marca = "Natur Green";
            mNewArticuloAbarrote.Precio = 4950;
            mNewArticuloAbarrote.Cantidad = Convert.ToInt32(txtCantidadAceite.Text.ToString());
            mNewArticuloAbarrote.Total = mNewArticuloAbarrote.Precio * mNewArticuloAbarrote.Cantidad;
            txtCantidadAceite.Text = "";

            mAddArticuloAbarrote.AgregarArticulo(mNewArticuloAbarrote);
            
        }
        private void btnGarbanzos_Click(object sender, EventArgs e)
        {
            clArticulo mNewArticuloAbarrote = new clArticulo();
            mNewArticuloAbarrote.Codigo = 9431;
            mNewArticuloAbarrote.Descripcion = "Garbanzos Ecólogicos";
            mNewArticuloAbarrote.Marca = "Eco Sana";
            mNewArticuloAbarrote.Precio = 1645;
            mNewArticuloAbarrote.Cantidad = Convert.ToInt32(txtcanGarbanzos.Text.ToString());
            mNewArticuloAbarrote.Total = mNewArticuloAbarrote.Precio * mNewArticuloAbarrote.Cantidad;
            txtcanGarbanzos.Text = "";

            mAddArticuloAbarrote.AgregarArticulo(mNewArticuloAbarrote);
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            clArticulo mNewArticuloAbarrote = new clArticulo();
            mNewArticuloAbarrote.Codigo = 0743;
            mNewArticuloAbarrote.Descripcion = "Pasta Penne";
            mNewArticuloAbarrote.Marca = "Sarchio Integrale";
            mNewArticuloAbarrote.Precio = 1880;
            mNewArticuloAbarrote.Cantidad = Convert.ToInt32(txtCanPasta.Text.ToString());
            mNewArticuloAbarrote.Total = mNewArticuloAbarrote.Precio * mNewArticuloAbarrote.Cantidad;
            txtCanPasta.Text = "";

            mAddArticuloAbarrote.AgregarArticulo(mNewArticuloAbarrote);
        }

        private void btnCarlota_Click(object sender, EventArgs e)
        {
            clArticulo mNewArticuloAbarrote = new clArticulo();
            mNewArticuloAbarrote.Codigo = 6574;
            mNewArticuloAbarrote.Descripcion = "Quinoa Con Kale";
            mNewArticuloAbarrote.Marca = "Carlota";
            mNewArticuloAbarrote.Precio = 2915;
            mNewArticuloAbarrote.Cantidad = Convert.ToInt32(txtCanQuinoa1.Text.ToString());
            mNewArticuloAbarrote.Total = mNewArticuloAbarrote.Precio * mNewArticuloAbarrote.Cantidad;
            txtCanQuinoa1.Text = "";

            mAddArticuloAbarrote.AgregarArticulo(mNewArticuloAbarrote);
        }

        private void btnMantequilla_Click(object sender, EventArgs e)
        {
            clArticulo mNewArticuloAbarrote = new clArticulo();
            mNewArticuloAbarrote.Codigo = 8761;
            mNewArticuloAbarrote.Descripcion = "Mantequilla Maní";
            mNewArticuloAbarrote.Marca = "Natruly";
            mNewArticuloAbarrote.Precio = 2915;
            mNewArticuloAbarrote.Cantidad = Convert.ToInt32(txtCanMantequilla.Text.ToString());
            mNewArticuloAbarrote.Total = mNewArticuloAbarrote.Precio * mNewArticuloAbarrote.Cantidad;
            txtCanMantequilla.Text = "";

            mAddArticuloAbarrote.AgregarArticulo(mNewArticuloAbarrote);
        }

        private void frmAbarrotes_Load(object sender, EventArgs e)
        {

        }
    }
}
