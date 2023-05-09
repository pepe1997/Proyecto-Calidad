using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entConsolidado;
using entCuenta;
using LogicaNegocio;
using Sistema_Prestamos.Buscadores;
using Sistema_Prestamos.Mantendedor;
using Sistema_Prestamos.Transaccion;

namespace Sistema_Prestamos.Mantendedor
{
    public partial class FrmConsolidado : Form
    {
        public FrmConsolidado()
        {
            InitializeComponent();
            listarConsolidado();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsolidado_Load(object sender, EventArgs e)
        {

        }
        public void listarConsolidado()
        {
            dgvConsolidado.DataSource = logConsolidado.Instancia.ListarConsolidado();
        }
        private void LimpiarVariables()
        {
            txtIdConsolidado.Text = "";
            txtMeses.Text = "";
            txtInteresConsolidado.Text = "";
            txtDevolucionTotal.Text = "";
            txtInteresTotal.Text = "";
            txtMontoTotal.Text = "";
            cmbEstadoConsolidado.SelectedIndex = 0;
            txtIdConsolidado.Focus();
        }
        private void LimpiarVariablesPrestamo()
        {
            txtIdPrestamo.Text = "";
            txtMontoPrestamo.Text = "";
            cmbEstadoPrestamo.SelectedIndex = 0;
            txtIdPrestamo.Focus();
        }
        private void LimpiarVariableCueta()
        {
            txtIdCuenta.Text = "";
            txtNroCuenta.Text = "";
            txtIdCuenta.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Consolidado c = new Consolidado();
                c.idConsolidado = txtIdConsolidado.Text.Trim();
                c.numMes = Convert.ToInt32(txtMeses.Text.Trim());
                c.interes = Convert.ToInt32(txtInteresConsolidado.Text);
                c.devolucionTotal = Convert.ToDouble(txtDevolucionTotal.Text);
                c.interesesTotal = Convert.ToDouble(txtInteresTotal.Text);
                c.montoTotal = Convert.ToDouble(txtMontoTotal.Text);
                c.estConsolidado = cmbEstadoConsolidado.SelectedItem.ToString();
                c.idPrestamo = txtIdPrestamo.Text.Trim();
                c.idCuenta = txtIdCuenta.Text.Trim();
                logConsolidado.Instancia.InsertarConsolidado(c);
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
                Consolidado c = new Consolidado();
                c.idConsolidado = txtIdConsolidado.Text.Trim();
                c.numMes = Convert.ToInt32(txtMeses.Text.Trim());
                c.interes = Convert.ToInt32(txtInteresConsolidado.Text);
                c.devolucionTotal = Convert.ToDouble(txtDevolucionTotal.Text);
                c.interesesTotal = Convert.ToDouble(txtInteresTotal.Text);
                c.montoTotal = Convert.ToDouble(txtMontoTotal.Text);
                c.estConsolidado = cmbEstadoConsolidado.SelectedItem.ToString();
                logConsolidado.Instancia.EditaConsolidado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
        }

        private void btnSeleccionarPrestamo_Click(object sender, EventArgs e)
        {
            FrmBuscarPrestamo fc = new FrmBuscarPrestamo();
            AddOwnedForm(fc);
            fc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscarCuenta fc = new FrmBuscarCuenta();
            AddOwnedForm(fc);
            fc.Show();
        }

        private void dgvConsolidado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvConsolidado.Rows[e.RowIndex];
            txtIdConsolidado.Text = filaActual.Cells[0].Value.ToString();
            txtMeses.Text = filaActual.Cells[1].Value.ToString();
            txtInteresConsolidado.Text = filaActual.Cells[2].Value.ToString();
            txtDevolucionTotal.Text = filaActual.Cells[3].Value.ToString();
            txtInteresTotal.Text = filaActual.Cells[4].Value.ToString();
            txtMontoTotal.Text = filaActual.Cells[5].Value.ToString();
            cmbEstadoConsolidado.SelectedItem = Convert.ToString(filaActual.Cells[6].Value.ToString());
            txtIdPrestamo.Text = filaActual.Cells[7].Value.ToString();
            txtIdCuenta.Text = filaActual.Cells[8].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPlan_Pago fc = new FrmPlan_Pago();
            fc.txtIdCuenta.Text = txtIdCuenta.Text;
            fc.txtSaldoCuenta.Text = txtSaldo.Text;
            fc.ShowDialog();
        }
    }
}
