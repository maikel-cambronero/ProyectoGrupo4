using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo4.Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComprar mfrmComprar = new frmComprar();
            mfrmComprar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBebidas mfrmBebidas = new frmBebidas();
            mfrmBebidas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRefrigerados mfrmRefrigerados = new frmRefrigerados();
            mfrmRefrigerados.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRecetas mfrmRecetas = new frmRecetas();
            mfrmRecetas.Show();
        }

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagar mfrmPagar = new frmPagar();
            mfrmPagar.Show();
        }

        private void acomodarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenar mfrmOrdenar = new frmOrdenar();
            mfrmOrdenar.Show();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            
            mArboles.Show();
        }
    }
}
