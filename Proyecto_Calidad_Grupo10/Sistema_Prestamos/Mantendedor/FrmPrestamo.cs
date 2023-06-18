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
            gbCliente.Enabled = false;
            gbPrestamo.Enabled = false;
            
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
            cmbEstadoPrestamo.SelectedIndex=0;
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
            if((txtIdPrestamo.Text=="") || (txtMontoPrestamo.Text == "") || (txtIdCliente.Text == ""))
            {

                MessageBox.Show("Falta llenar algun casillero");
            }
            else
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
                listarPrestamo();
                gbCliente.Enabled = false;
                gbPrestamo.Enabled = false;
                LimpiarVariables();
                LimpiarVariabllesCliente();
                btnAgregar.Visible = true;
                btnModificar.Visible = true;
            }
            
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdPrestamo.Text == "")
            {
                MessageBox.Show("No se selecciono ningun ID");
            }
            else
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
                listarPrestamo();
                gbCliente.Enabled = false;
                gbPrestamo.Enabled = false;
                LimpiarVariables();
                LimpiarVariabllesCliente();
                btnAgregar.Visible = true;
                btnModificar.Visible = true;
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

        private void generarId()
        {
            char[] id = { 'P', 'R', '0', '0', '0' };
            int Num = logPrestamo.Instancia.CalcularNumPrestamo();

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
            txtIdPrestamo.Text = cadena;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbEstadoPrestamo.SelectedIndex = 0;
            gbCliente.Enabled = true;
            gbPrestamo.Enabled = true;
            listarPrestamo();
            btnAgregar.Visible = true;
            LimpiarVariables();
            LimpiarVariabllesCliente();
            btnModificar.Visible = false;
            txtIdPrestamo.Enabled=false;
            generarId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariabllesCliente();
            listarPrestamo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                txtIdPrestamo.Enabled = false;
                gbCliente.Enabled = false;
                gbPrestamo.Enabled = true;
                LimpiarVariables();
                LimpiarVariabllesCliente();
                btnAgregar.Visible = false;
                btnModificar.Visible = true;
            
            
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariabllesCliente();
            gbPrestamo.Enabled=false;
            gbCliente.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            listarPrestamo();
        }
    }
}
