using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entCuenta;
using entLogin;
using LogicaNegocio;
using Sistema_Prestamos.Mantendedor;

namespace Sistema_Prestamos.Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            
            Login log = new Login();
            log.usuario = txtUsuario.Text.Trim();
            log.contra = txtContra.Text.Trim();
            String v =logLogin.Instancia.VerificaAcceso(log);
            if (v == "")
            {
                MessageBox.Show("No se encontro al usuario");
            }
            if(v=="admin")
            {
                FrmPrincipal f = new FrmPrincipal();
                f.Show();
                this.Hide();

            }
            if (v == "asistente")
            {
                FrmConsolidado c = new FrmConsolidado();
                c.Show();
                this.Hide();

            }
           
        }
    }
}
