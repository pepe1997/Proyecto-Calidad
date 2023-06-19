using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entCliente;
using LogicaNegocio;

namespace Sistema_Prestamos.Mantendedor
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            listarCliente();
            groupBox1.Enabled = false;

        }

        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }
        private void LimpiarVariables()
        {
            txtId.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtId.Focus();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void generarId()
        {
            char[] id = {'C','L','0','0','0'};
            int Num = logCliente.Instancia.CalcularNumCliente();
            
            string n = (Num+1).ToString();
            if(Num== 0)
            {

                id[4] = '1';
            }
            else if (Num < 9)
            {
                id[4]=n[0];

            }else if((Num>9) && (Num < 100))
            {
                
                id[3] = n[0];
                id[4]= n[1];
            }
            else
            {
                id[2] = n[0];
                id[3] = n[1];
                id[4] = n[2];
            }
            string cadena = string.Join("",id);
            txtId.Text = cadena;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
            txtId.Enabled = true;
            txtId.Enabled = false;
            generarId();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.idCliente = txtId.Text.Trim();
                c.dniCliente = txtDni.Text.Trim();
                c.apellCliente = txtApellido.Text.Trim();
                c.nombCliente = txtNombre.Text.Trim();
                c.direCliente = txtDireccion.Text.Trim();
                c.celCliente = txtCelular.Text.Trim();
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.InsertarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBox1.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.idCliente = txtId.Text.Trim();
                c.dniCliente = txtDni.Text.Trim();
                c.apellCliente = txtApellido.Text.Trim();
                c.nombCliente = txtNombre.Text.Trim();
                c.direCliente = txtDireccion.Text.Trim();
                c.celCliente = txtCelular.Text.Trim();
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCliente();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.idCliente = txtId.Text.Trim();
                cbkEstadoCliente.Checked = false;
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtId.Enabled = false;           
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtDni.Text = filaActual.Cells[1].Value.ToString();
            txtApellido.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            txtDireccion.Text = filaActual.Cells[4].Value.ToString();
            txtCelular.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                listarCliente();
            }
            else
            {
                string dato = txtBuscar.Text.Trim(); // se obtiene el valor de una celda 
                dgvCliente.DataSource = logCliente.Instancia.BuscarCliente(dato);

            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            listarCliente();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
