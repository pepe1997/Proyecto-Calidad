using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entCliente;
using entCuenta;
using LogicaNegocio;
using Sistema_Prestamos.Buscadores;

namespace Sistema_Prestamos.Mantendedor
{
    public partial class FrmCuenta : Form
    {
        public FrmCuenta()
        {
            InitializeComponent();
            listarCuenta();
            gbCliente.Enabled = false;
            gbTipoCuenta.Enabled = false;
            gbCuenta.Enabled = false;

        }
        public void gbActivos()
        {
            gbCliente.Enabled = true;
            gbCuenta.Enabled = true;
            gbTipoCuenta.Enabled=true;
        }
        public void gbInactivos()
        {
            gbCliente.Enabled = false;
            gbCuenta.Enabled = false;
            gbTipoCuenta.Enabled = false;
        }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {

        }
        public void listarCuenta()
        {
            dgvCuenta.DataSource = logCuenta.Instancia.ListarCuenta();
        }
        private void LimpiarVariables()
        {
            txtIdCuenta.Text = "";
            txtNroCuenta.Text = "";
            txtSaldoCuenta.Text = "";
            dtpFechaCuenta.Text = "";
            txtIdCuenta.Focus();
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
        private void LimpiarVariablesTip()
        {
            txtIdTipCuenta.Text = "";
            txtNombTip.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta c = new Cuenta();
                c.idCuenta = txtIdCuenta.Text.Trim();
                c.nroCuenta = txtNroCuenta.Text.Trim();
                c.salCuenta = Convert.ToDouble(txtSaldoCuenta.Text);
                c.fechCreacion = Convert.ToDateTime(dtpFechaCuenta.Text);
                c.idCliente = txtIdCliente.Text.Trim();
                c.idTipo = txtIdTipCuenta.Text.Trim();
                logCuenta.Instancia.InsertarCuenta(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            LimpiarVariablesTip();
            LimpiarVariabllesCliente();
            gbCuenta.Enabled = false;

            listarCuenta();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta c = new Cuenta();
                c.idCuenta = txtIdCuenta.Text.Trim();
                c.nroCuenta = txtNroCuenta.Text.Trim();
                c.salCuenta = Convert.ToDouble(txtSaldoCuenta.Text);
                c.fechCreacion = Convert.ToDateTime(dtpFechaCuenta.Text);
                logCuenta.Instancia.EditaCuenta(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            LimpiarVariablesTip();
            LimpiarVariabllesCliente();
            gbCuenta.Enabled = false;
            listarCuenta();
        }

        private void dgvCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCuenta.Rows[e.RowIndex];
            txtIdCuenta.Text = filaActual.Cells[0].Value.ToString();
            txtNroCuenta.Text = filaActual.Cells[1].Value.ToString();
            txtSaldoCuenta.Text = filaActual.Cells[2].Value.ToString();
            dtpFechaCuenta.Text = filaActual.Cells[3].Value.ToString();
            txtIdCliente.Text = filaActual.Cells[4].Value.ToString();
            txtIdTipCuenta.Text = filaActual.Cells[5].Value.ToString();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                listarCuenta();
            }
            else
            {
                string dato = txtBuscar.Text.Trim(); // se obtiene el valor de una celda 
                dgvCuenta.DataSource = logCuenta.Instancia.BuscarCuenta(dato);

            }
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
                FrmBuscarCliente fc = new FrmBuscarCliente();
                fc.txtFormulario.Text = "Cuenta";
                AddOwnedForm(fc);
                fc.Show();
                
        }

        private void btnSeleccionarTip_Click(object sender, EventArgs e)
        {
            FrmBuscarTipCuenta fx = new FrmBuscarTipCuenta();
            AddOwnedForm(fx);
            fx.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            listarCuenta();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            listarCuenta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariabllesCliente();
            LimpiarVariablesTip();
            gbCliente.Enabled = false;
            gbTipoCuenta.Enabled = false;
            gbCuenta.Enabled = false;
            btnModificar.Visible = true;
            listarCuenta();
        }

        private void generarId()
        {
            char[] id = { 'C', 'U', '0', '0', '0' };
            int Num = logCuenta.Instancia.CalcularNumCuenta();

            string n = (Num + 1).ToString();
            if (Num == 0)
            {

                id[4] = '1';
            }
            else if (Num < 9)
            {
                id[4] = n[0];

            }
            else if ((Num > 9) && (Num < 100))
            {

                id[3] = n[0];
                id[4] = n[1];
            }
            else
            {
                id[2] = n[0];
                id[3] = n[1];
                id[4] = n[2];
            }
            string cadena = string.Join("", id);
            txtIdCuenta.Text = cadena;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbCliente.Enabled = true;
            gbTipoCuenta.Enabled = true;
            gbCuenta.Enabled = true;
            btnModificar.Visible =false ;
            btnAgregar.Visible = true;
            txtIdCuenta.Enabled = false;
            generarId();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtIdCuenta.Text = "";
            gbCliente.Enabled = false;
            gbTipoCuenta.Enabled = false;
            gbCuenta.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }
    }
}
