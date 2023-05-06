using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Prestamos.Mantendedor;
using LogicaNegocio;

namespace Sistema_Prestamos.Buscadores
{
    public partial class FrmBuscarTipCuenta : Form
    {
        public FrmBuscarTipCuenta()
        {
            InitializeComponent();
            listarTipo();
        }

        private void FrmBuscarTipCuenta_Load(object sender, EventArgs e)
        {

        }
        public void listarTipo()
        {
            dgvTipCuenta.DataSource = logTipo_Cuenta.Instancia.ListarTipo();
        }

        private void dgvTipCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCuenta fr = Owner as FrmCuenta;
            fr.txtIdTipCuenta.Text = dgvTipCuenta.CurrentRow.Cells[0].Value.ToString();
            fr.txtNombTip.Text = dgvTipCuenta.CurrentRow.Cells[1].Value.ToString();
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                listarTipo();
            }
            else
            {
                string dato = txtBuscar.Text.Trim(); // se obtiene el valor de una celda 
                dgvTipCuenta.DataSource = logTipo_Cuenta.Instancia.BuscarTipo(dato);

            }
        }
    }
}
