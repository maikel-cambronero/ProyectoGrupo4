using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupo4.Formularios;
using ProyectoGrupo4.Clases;

namespace ProyectoGrupo4.Formularios
{
    public partial class frmPagar : Form
    {

        public clArticuloServicio mListaAbarrote = frmAbarrotes.mAddArticuloAbarrote;
        public static ccArticuloServicio mColaArticulo = new ccArticuloServicio();
        cGlobal mGlobal = new cGlobal();
        public frmPagar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPagarTotal_Click(object sender, EventArgs e)
        {
            dgvListaArticulo.ColumnCount = 6;
            dgvListaArticulo.Columns[0].Name = "Código";
            dgvListaArticulo.Columns[1].Name = "Descripción";
            dgvListaArticulo.Columns[2].Name = "Marca";
            dgvListaArticulo.Columns[3].Name = "Precio";
            dgvListaArticulo.Columns[4].Name = "Cantidad";
            dgvListaArticulo.Columns[5].Name = "Total";

            dgvListaArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            clArticulo _p = new clArticulo();
            
            _p = clArticuloServicio.PrimerNodo;

            while (_p != null)
            {
                ccArticulo _l = new ccArticulo();
                _l.Codigo = _p.Codigo;
                _l.Descripcion = _p.Descripcion;
                _l.Marca = _p.Marca;
                _l.Precio = _p.Precio;
                _l.Cantidad = _p.Cantidad;
                _l.Total = _p.Total;
                mColaArticulo.Enqueue(_l);
                dgvListaArticulo.Rows.Add(_p.Codigo, _p.Descripcion, _p.Marca, _p.Precio.ToString(), _p.Cantidad, _p.Total);
                _p = _p.Siguiente;
            }
        }

        private void lstListaArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void dgvListaArticulo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvListaArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int mCodigo = Convert.ToInt32(this.dgvListaArticulo.SelectedRows[0].Cells[0].Value);
                txtCodigo.Text = mCodigo.ToString();
                string mNombre = this.dgvListaArticulo.SelectedRows[0].Cells[1].Value.ToString();
                txtNombre.Text = mNombre.ToString();
                string mMarca = this.dgvListaArticulo.SelectedRows[0].Cells[2].Value.ToString();
                txtMarca.Text = mMarca.ToString();
                int mPrecio = Convert.ToInt32(this.dgvListaArticulo.SelectedRows[0].Cells[3].Value);
                txtPrecio.Text = mPrecio.ToString();
                int mCantidad = Convert.ToInt32(this.dgvListaArticulo.SelectedRows[0].Cells[4].Value);
                txtCantidad.Text = mCantidad.ToString();
                int mTotal = Convert.ToInt32(this.dgvListaArticulo.SelectedRows[0].Cells[5].Value);
                txtSubtotal.Text = mTotal.ToString();
            }
            catch
            {
                    
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {   
            ccArticulo mCola = new ccArticulo();
            mCola.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
            mCola.Descripcion = txtNombre.Text.Trim();
            mCola.Marca = txtMarca.Text.Trim();
            mCola.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
            mCola.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
            mCola.Total = Convert.ToInt32(txtSubtotal.Text.Trim());
            mColaArticulo.Enqueue(mCola);
            fnLimpiarCampos();
        }

        public void fnLimpiarCampos()
        {
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtMarca.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtSubtotal.Text = "";
        }

        private void btnVerCola_Click(object sender, EventArgs e)
        {
            dgvColaArticulo.ColumnCount = 6;
            dgvColaArticulo.Columns[0].Name = "Código";
            dgvColaArticulo.Columns[1].Name = "Descripción";
            dgvColaArticulo.Columns[2].Name = "Marca";
            dgvColaArticulo.Columns[3].Name = "Precio";
            dgvColaArticulo.Columns[4].Name = "Cantidad";
            dgvColaArticulo.Columns[5].Name = "Total";

            dgvColaArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ccArticulo _p = new ccArticulo();
            _p = ccArticuloServicio.Primer_Item;

            while (_p != null)
            {
                dgvColaArticulo.Rows.Add(_p.Codigo, _p.Descripcion, _p.Marca, _p.Precio.ToString(), _p.Cantidad, _p.Total);
                _p = _p.Siguiente;
            }
        }

        private void dgvListaArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPagar_Load(object sender, EventArgs e)
        {

        }
    }
}
