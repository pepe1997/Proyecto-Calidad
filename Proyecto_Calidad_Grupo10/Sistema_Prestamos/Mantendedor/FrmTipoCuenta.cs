using entCliente;
using entTipo_Cuenta;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Prestamos.Mantendedor
{
    public partial class FrmTipoCuenta : Form
    {
        public FrmTipoCuenta()
        {
            InitializeComponent();
            listarTipoCuenta();
        }

        private void FrmTipoCuenta_Load(object sender, EventArgs e)
        {

        }
        public void listarTipoCuenta()
        {
            dgvTipo.DataSource = logTipo_Cuenta.Instancia.ListarTipo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo_Cuenta c = new Tipo_Cuenta();
                c.idTipo = txtIdTip.Text.Trim();
                c.nombTipo = txtNombreTip.Text.Trim();
                
                logTipo_Cuenta.Instancia.InsertarTipo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            listarTipoCuenta();
            
        }

        private void dgvTipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipo.Rows[e.RowIndex];
            txtIdTip.Text = filaActual.Cells[0].Value.ToString();
            txtNombreTip.Text = filaActual.Cells[1].Value.ToString();
            
        }
    }
    }

