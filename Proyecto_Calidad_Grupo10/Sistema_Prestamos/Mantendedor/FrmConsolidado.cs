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
            desactivarBotonesBusqueda();
            gbPrestamo.Enabled=false;
            gbCuenta.Enabled=false; 
            gbConsolidado.Enabled=false;   
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void activarBotonesBusqueda()
        {
            btnSeleccionarCuentaBusqueda.Visible = true;
            btnSeleccionarPrestamoBusqueda.Visible = true;
        }
        private void desactivarBotonesBusqueda()
        {
            btnSeleccionarCuentaBusqueda.Visible = false;
            btnSeleccionarPrestamoBusqueda.Visible = false;
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
            cmbEstadoConsolidado.SelectedIndex = 0;
            txtIdCliente.Text = "";
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
            if((txtIdPrestamo.Text.Trim()=="") || (txtIdCuenta.Text.Trim()=="") || (txtIdConsolidado.Text.Trim() == "") )
            {
                MessageBox.Show("Falta rellenar un campo");
            }
            else
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
                listarConsolidado();
                LimpiarVariables();
                LimpiarVariableCueta();
                LimpiarVariablesPrestamo();
                gbConsolidado.Enabled = false;
                gbCuenta.Enabled = false;
                gbPrestamo.Enabled = false;
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
        public void listarCuenta()
        {
            dgvConsolidado.DataSource = logCuenta.Instancia.ListarCuenta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscarCuenta fc = new FrmBuscarCuenta();
            fc.txtBuscar.Text = txtIdCliente.Text.ToString();
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
                txtIdCuenta.Text = filaActual.Cells[7].Value.ToString();
                txtIdPrestamo.Text = filaActual.Cells[8].Value.ToString();
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbConsolidado.Enabled = true;
            gbCuenta.Enabled = true;
            gbPrestamo.Enabled = true;
            
            if ((txtIdPrestamo.Text.Trim() == "") || (txtIdCuenta.Text.Trim() == "") || (txtIdConsolidado.Text.Trim() == "") ||
                (txtSaldo.Text.Trim() == "") || (txtIdCliente.Text.Trim() == ""))
            {
                MessageBox.Show("Falta seleccionar los campos");
                activarBotonesBusqueda();
            }
            else
            {
                desactivarBotonesBusqueda();
                FrmPlan_Pago fc = new FrmPlan_Pago();
                fc.txtIdConsolidado.Text = txtIdConsolidado.Text;
                fc.txtMesConsolidado.Text = txtMeses.Text;
                fc.txtIdCuenta.Text = txtIdCuenta.Text;
                fc.txtSaldoCuenta.Text = txtSaldo.Text;
                fc.txtMontoPrestamo.Text = txtMontoPrestamo.Text;
                fc.ShowDialog();
            }
            
            listarConsolidado();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarCuentaBusqueda_Click(object sender, EventArgs e)
        {
            FrmBuscarCuenta fc = new FrmBuscarCuenta();
            fc.txtBuscar.Text = txtIdCliente.Text.ToString();
            AddOwnedForm(fc);
            fc.Show();
        }

        private void btnSeleccionarPrestamoBusqueda_Click(object sender, EventArgs e)
        {
            FrmBuscarPrestamo fc = new FrmBuscarPrestamo();
            fc.txtBuscar.Text = txtIdPrestamo.Text.ToString();
            AddOwnedForm(fc);
            fc.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var randon = new Random();
            int n = randon.Next(1,12) ;
            txtInteresConsolidado.Text = "10";
            txtMontoTotal.Text = "0";
            txtDevolucionTotal.Text = "0";
            txtInteresTotal.Text = "0";
            cmbEstadoConsolidado.SelectedIndex = 0;
            txtMeses.Text = n.ToString();
            gbConsolidado.Enabled = true;
            gbCuenta.Enabled = true;
            gbPrestamo.Enabled = true;
            btnAgregar.Visible = true;

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            listarConsolidado();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariableCueta();
            LimpiarVariablesPrestamo();
            gbConsolidado.Enabled = false;
            gbCuenta.Enabled = false;
            gbPrestamo.Enabled = false;
            listarConsolidado();
        }
    }
}
