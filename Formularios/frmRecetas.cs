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
    public partial class frmRecetas : Form
    {
        public frmRecetas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEnsalada mfrmEnsalada = new frmEnsalada();
            mfrmEnsalada.Show();
        }

        private void btnTacos_Click(object sender, EventArgs e)
        {
            frmTacos mfrmTacos = new frmTacos();
            mfrmTacos.Show();
        }

        private void btnTrufas_Click(object sender, EventArgs e)
        {
            frmTrufas mfrmTrufas = new frmTrufas();
            mfrmTrufas.Show();
        }

    }
}
