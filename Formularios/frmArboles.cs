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
    public partial class frmArboles : Form
    {
        cGlobal mGlobal = new cGlobal();
        public clArticuloServicio mListaAbarrote = frmAbarrotes.mAddArticuloAbarrote;
        public static ccArticuloServicio mColaAbarrote = frmPagar.mColaArticulo;
        public static cpArticuloServicio mPilaAbarrote = frmOrdenar.mPilaArticulo;
        cpArticuloServicio mPilaArticulo = new cpArticuloServicio();
        public static caArticuloServicio mArbolArticulo = new caArticuloServicio();

        public frmArboles()
        {
            InitializeComponent();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
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

        private void btnMostrarCola_Click(object sender, EventArgs e)
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
                dgvColaArticulos.Rows.Add(_p.Codigo, _p.Descripcion, _p.Marca, _p.Precio.ToString(), _p.Cantidad, _p.Total);
                _p = _p.Siguiente;
            }
        }
        
        private void btnMostrarPila_Click(object sender, EventArgs e)
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
                caArticulo _l = new caArticulo();
                dgvPilaArticulo.Rows.Add(_p.Codigo, _p.Descripcion, _p.Marca, _p.Precio.ToString(), _p.Cantidad, _p.Total);
                _l.Codigo = _p.Codigo;
                _l.Descripcion = _p.Descripcion;
                _l.Marca = _p.Marca;
                _l.Precio = _p.Precio;
                _l.Cantidad = _p.Cantidad;
                _l.Total = _p.Total;
                mArbolArticulo.AgregarNodo(_l);
                try
                {
                    cGlobal.mPilaArticuloServicio.pop();
                }
                catch
                {
                    MessageBox.Show("Ya no hay más articulos en la Pila");
                }
                _p = _p.ArticuloAbajo;
                fnPreoOrden(_l);
            }
        }

        private void dgvPilaArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int mCodigo = Convert.ToInt32(this.dgvPilaArticulo.SelectedRows[0].Cells[0].Value);
                txtCodigo.Text = mCodigo.ToString();
                string mNombre = this.dgvPilaArticulo.SelectedRows[0].Cells[1].Value.ToString();
                txtDescripcion.Text = mNombre.ToString();
                string mMarca = this.dgvPilaArticulo.SelectedRows[0].Cells[2].Value.ToString();
                txtMarca.Text = mMarca.ToString();
                int mPrecio = Convert.ToInt32(this.dgvPilaArticulo.SelectedRows[0].Cells[3].Value);
                txtPrecio.Text = mPrecio.ToString();
                int mCantidad = Convert.ToInt32(this.dgvPilaArticulo.SelectedRows[0].Cells[4].Value);
                txtCantidad.Text = mCantidad.ToString();
                int mTotal = Convert.ToInt32(this.dgvPilaArticulo.SelectedRows[0].Cells[5].Value);
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
            caArticulo mArbol = new caArticulo();

            mArbol.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
            mArbol.Descripcion = txtDescripcion.Text.Trim();
            mArbol.Marca = txtMarca.Text.Trim();
            mArbol.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
            mArbol.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
            mArbol.Total = Convert.ToInt32(txtSubtotal.Text.Trim());
            mArbolArticulo.AgregarNodo(mArbol);

            fnLimpiarCampos();
            fnPreoOrden(mArbol);
        }

        public void fnPreoOrden(caArticulo _raiz)
        {
            dgvArbolArticulo.ColumnCount = 6;
            dgvArbolArticulo.Columns[0].Name = "Código";
            dgvArbolArticulo.Columns[1].Name = "Descripción";
            dgvArbolArticulo.Columns[2].Name = "Marca";
            dgvArbolArticulo.Columns[3].Name = "Precio";
            dgvArbolArticulo.Columns[4].Name = "Cantidad";
            dgvArbolArticulo.Columns[5].Name = "Total";

            dgvArbolArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            caArticulo _p = new caArticulo();
            _p = caArticuloServicio.raiz;

            if (_raiz != null)
            {
                dgvArbolArticulo.Rows.Add(_raiz.Codigo, _raiz.Descripcion, _raiz.Marca, _p.Precio.ToString(), _raiz.Cantidad, _raiz.Total);
                fnPreoOrden(_raiz.HijoIzquierdo);
                fnPreoOrden(_raiz.HijoDerecho);
            }
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

        private void btnMostrarArbol_Click(object sender, EventArgs e)
        {
            
        }
    }
}
