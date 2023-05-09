using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entPrestamo;
using Sistema_Prestamos.Mantendedor;
using LogicaNegocio;
using entCuenta;
using Sistema_Prestamos.Buscadores;

namespace Sistema_Prestamos.Mantendedor
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
            listarPrestamo();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {

        }
        public void listarPrestamo()
        {
            dgvPrestamo.DataSource = logPrestamo.Instancia.ListarPrestamo();
        }
        private void LimpiarVariables()
        {
            txtIdPrestamo.Text = "";
            txtMontoPrestamo.Text = "";
            cmbEstadoPrestamo.SelectedIndex = 0;
            txtIdPrestamo.Focus();
        }
        private void LimpiarVariabllesCliente()
        {
            txtIdCliente.Text = "";
            txtDniCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtCelCliente.Text = "";
            txtIdCliente.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo p = new Prestamo();
                p.idPrestamo = txtIdPrestamo.Text.Trim();
                p.montPrestamo = Convert.ToDouble(txtMontoPrestamo.Text.Trim());
                p.estPrestamo = cmbEstadoPrestamo.SelectedItem.ToString();
                p.idCliente = txtIdCliente.Text.Trim();
                logPrestamo.Instancia.InsertarPrestamo(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo p = new Prestamo();
                p.idPrestamo = txtIdPrestamo.Text.Trim();
                p.montPrestamo = Convert.ToDouble(txtMontoPrestamo.Text.Trim());
                p.estPrestamo = cmbEstadoPrestamo.SelectedItem.ToString();
                logPrestamo.Instancia.EditaPrestamo(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                listarPrestamo();
            }
            else
            {
                string dato = txtBuscar.Text.Trim(); // se obtiene el valor de una celda 
                dgvPrestamo.DataSource = logPrestamo.Instancia.BuscarPrestamo(dato);

            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            listarPrestamo();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente fp = new FrmBuscarCliente();
            fp.txtFormulario.Text = "Prestamo";
            AddOwnedForm(fp);
            fp.Show();
        }

        private void dgvPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPrestamo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPrestamo.Rows[e.RowIndex];
            txtIdPrestamo.Text = filaActual.Cells[0].Value.ToString();
            txtMontoPrestamo.Text = filaActual.Cells[1].Value.ToString();
            cmbEstadoPrestamo.SelectedItem = Convert.ToString(filaActual.Cells[2].Value.ToString());
            txtIdCliente.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
