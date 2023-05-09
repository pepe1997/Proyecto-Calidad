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
using Sistema_Prestamos.Mantendedor;
using LogicaNegocio;

namespace Sistema_Prestamos.Buscadores
{
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
            listarCliente();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {

        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(txtFormulario.Text == "Cuenta")
            {
                FrmCuenta fr = Owner as FrmCuenta;
                fr.txtIdCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                fr.txtDniCliente.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                fr.txtApellidoCliente.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                fr.txtNombreCliente.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                fr.txtDireccionCliente.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                fr.txtCelCliente.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                Close();
            }
            else if( txtFormulario.Text == "Prestamo")
            {
                FrmPrestamo fp = Owner as FrmPrestamo;
                fp.txtIdCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                fp.txtDniCliente.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                fp.txtApellidoCliente.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                fp.txtNombreCliente.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                fp.txtDireccionCliente.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                fp.txtCelCliente.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                Close();
            }
            
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                listarCliente();
            }
            else
            {
                string dato = txtDni.Text.Trim(); // se obtiene el valor de una celda 
                dgvCliente.DataSource = logCliente.Instancia.BuscarCliente(dato);

            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
