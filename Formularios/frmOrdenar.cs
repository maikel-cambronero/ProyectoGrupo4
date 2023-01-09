using ProyectoGrupo4.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoGrupo4.Formularios
{
    public partial class frmOrdenar : Form
    {
        cGlobal mGlobal = new cGlobal();
        public clArticuloServicio mListaAbarrote = frmAbarrotes.mAddArticuloAbarrote;
        public static ccArticuloServicio mColaAbarrote = frmPagar.mColaArticulo;
        public static cpArticuloServicio mPilaArticulo = new cpArticuloServicio();

        public frmOrdenar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerLista_Click(object sender, EventArgs e)
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
                dgvListaArticulo.Rows.Add(_p.Codigo, _p.Descripcion, _p.Marca, _p.Precio.ToString(), _p.Cantidad, _p.Total);
                _p = _p.Siguiente;
            }
        }

        private void btnVerCola_Click(object sender, EventArgs e)
        {
            dgvColaArticulos.ColumnCount = 6;
            dgvColaArticulos.Columns[0].Name = "Código";
            dgvColaArticulos.Columns[1].Name = "Descripción";
            dgvColaArticulos.Columns[2].Name = "Marca";
            dgvColaArticulos.Columns[3].Name = "Precio";
            dgvColaArticulos.Columns[4].Name = "Cantidad";
            dgvColaArticulos.Columns[5].Name = "Total";

            dgvColaArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ccArticulo _p = new ccArticulo();
            _p = ccArticuloServicio.Primer_Item;

            while (_p != null)
            {
                cpArticulo _l = new cpArticulo();
                dgvColaArticulos.Rows.Add(_p.Codigo, _p.Descripcion, _p.Marca, _p.Precio.ToString(), _p.Cantidad, _p.Total);
                _l.Codigo = _p.Codigo;
                _l.Descripcion = _p.Descripcion;
                _l.Marca = _p.Marca;
                _l.Precio = _p.Precio;
                _l.Cantidad = _p.Cantidad;
                _l.Total = _p.Total;
                cGlobal.mPilaArticuloServicio.push(_l);
                Console.WriteLine(_l.Codigo);
                try
                {
                    mColaAbarrote.Dequeue();
                }
                catch
                {
                    MessageBox.Show("Ya no hay más articulos en la cola");
                }
                
                _p = _p.Siguiente;
            }
        }
        private void dgvColaArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int mCodigo = Convert.ToInt32(this.dgvColaArticulos.SelectedRows[0].Cells[0].Value);
                txtCodigo.Text = mCodigo.ToString();
                string mNombre = this.dgvColaArticulos.SelectedRows[0].Cells[1].Value.ToString();
                txtDescripcion.Text = mNombre.ToString();
                string mMarca = this.dgvColaArticulos.SelectedRows[0].Cells[2].Value.ToString();
                txtMarca.Text = mMarca.ToString();
                int mPrecio = Convert.ToInt32(this.dgvColaArticulos.SelectedRows[0].Cells[3].Value);
                txtPrecio.Text = mPrecio.ToString();
                int mCantidad = Convert.ToInt32(this.dgvColaArticulos.SelectedRows[0].Cells[4].Value);
                txtCantidad.Text = mCantidad.ToString();
                int mTotal = Convert.ToInt32(this.dgvColaArticulos.SelectedRows[0].Cells[5].Value);
                txtSubtotal.Text = mTotal.ToString();
                
            }
            catch
            {
                MessageBox.Show("No se pudo encontrar la lista");
                return;
            }
        }

        private void btnAgregarPila_Click(object sender, EventArgs e)
        {

            cpArticulo mPila = new cpArticulo();

            mPila.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
            mPila.Descripcion = txtDescripcion.Text.Trim();
            mPila.Marca = txtMarca.Text.Trim();
            mPila.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
            mPila.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
            mPila.Total = Convert.ToInt32(txtSubtotal.Text.Trim());
            cGlobal.mPilaArticuloServicio.push(mPila);
           
            fnLimpiarCampos();
        }
        public void fnLimpiarCampos()
        {
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtMarca.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtSubtotal.Text = "";
        }

        private void btnVerPila_Click(object sender, EventArgs e)
        {
            dgvPilaArticulo.ColumnCount = 6;
            dgvPilaArticulo.Columns[0].Name = "Código";
            dgvPilaArticulo.Columns[1].Name = "Descripción";
            dgvPilaArticulo.Columns[2].Name = "Marca";
            dgvPilaArticulo.Columns[3].Name = "Precio";
            dgvPilaArticulo.Columns[4].Name = "Cantidad";
            dgvPilaArticulo.Columns[5].Name = "Total";

            dgvPilaArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            cpArticulo _p = new cpArticulo();
            _p = cpArticuloServicio.PrimerArticulo;

            while (_p != null)
            {
                dgvPilaArticulo.Rows.Add(_p.Codigo, _p.Descripcion, _p.Marca, _p.Precio.ToString(), _p.Cantidad, _p.Total);
                
                _p = _p.ArticuloAbajo;
            }
        }
    }
}

