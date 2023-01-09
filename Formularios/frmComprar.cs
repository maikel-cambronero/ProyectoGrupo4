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
    public partial class frmComprar : Form
    {
        public frmComprar()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbarrotes mfrmAbarrotes = new frmAbarrotes();
            mfrmAbarrotes.Show();
        }

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBebidas mfrmBebidas = new frmBebidas();
            mfrmBebidas.Show();
        }

        private void acomodarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRefrigerados mfrmRefrigerados = new frmRefrigerados();
            mfrmRefrigerados.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRefrigerados mfrmRefrigerados = new frmRefrigerados();
            mfrmRefrigerados.Show();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerdurasyFrutas mfrmVerdurasyFrutas = new frmVerdurasyFrutas();
            mfrmVerdurasyFrutas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerdurasyFrutas mfrmVerdurasyFrutas = new frmVerdurasyFrutas();
            mfrmVerdurasyFrutas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPanaderiayReposteria mfrmPanaderiayReposteria = new frmPanaderiayReposteria();
            mfrmPanaderiayReposteria.Show();
        }

        private void panaderíaYReposteríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPanaderiayReposteria mfrmPanaderiayReposteria = new frmPanaderiayReposteria();
            mfrmPanaderiayReposteria.Show();
        }
    }
}
