using entLogin;
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

namespace Sistema_Prestamos.Principal
{
    public partial class FrmRecuperarCuenta : Form
    {
        public FrmRecuperarCuenta()
        {
            InitializeComponent();
            txtCaptcha.Text = logLogin.Instancia.GenerarLetras(10);
        }

        private void FrmRecuperarCuenta_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            string usu = txtUsuario.Text.ToLower().Trim();
            int v = logLogin.Instancia.EncontrarUsuario(usu);
            int v1 = logLogin.Instancia.EncontrarCelular(usu);
            int v2 = logLogin.Instancia.EncontrarCelularDeshabilitado(usu);
            int v3 = logLogin.Instancia.EncontrarUsuarioDeshabilitado(usu);
            if ((v>0) || (v1>0) || (v2 > 0) || (v3 > 0))
            {
                lbUsuario.ForeColor = Color.Green;
                lbUsuario.Text = "Correcto";
                lbUsuario.Visible = true;
            }
            else
            {
                lbUsuario.ForeColor = Color.Red;
                lbUsuario.Text = "Incorrecto";
                lbUsuario.Visible = true;
            }

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            string cont = string.Join("", txtContra.Text.Trim()); ;
            bool v = logLogin.Instancia.VerificarPassword(cont);
            if (v == true)
            {
                lbContra.ForeColor = Color.Green;
                lbContra.Text = "Fuerte";
                lbContra.Visible = true;
            }
            else
            {
                lbContra.ForeColor = Color.Red;
                lbContra.Text = "Debil";
                lbContra.Visible = true;
            }
        }

        private void txtVerificarContra_TextChanged(object sender, EventArgs e)
        {
            string cont = txtContra.Text;


            if (cont == txtVerificarContra.Text)
            {
                lbRepetirContra.ForeColor = Color.Green;
                lbRepetirContra.Text = "Correcto";
                lbRepetirContra.Visible = true;
            }
            else
            {
                lbRepetirContra.ForeColor = Color.Red;
                lbRepetirContra.Text = "Incorrecto";
                lbRepetirContra.Visible = true;
            }
        }

        private void txtVerificarCaptcha_TextChanged(object sender, EventArgs e)
        {
            string capt = txtCaptcha.Text;


            if (capt == txtVerificarCaptcha.Text)
            {
                lbVerificarCaptcha.ForeColor = Color.Green;
                lbVerificarCaptcha.Text = "Correcto";
                lbVerificarCaptcha.Visible = true;
            }
            else
            {
                lbVerificarCaptcha.ForeColor = Color.Red;
                lbVerificarCaptcha.Text = "Incorrecto";
                lbVerificarCaptcha.Visible = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usu = txtUsuario.Text.Trim();
            string con = txtContra.Text.Trim();
            if ((lbUsuario.Text=="Correcto")&&(lbContra.Text=="Fuerte")&&(lbRepetirContra.Text=="Correcto")&&(lbVerificarCaptcha.Text=="Correcto"))
            {
                if (usu[0] == '9')
                {
                    logLogin.Instancia.CambiarContraCel(usu,con);
                    Login log = new Login();
                    log.celular = usu;
                    logLogin.Instancia.HabilitarUsuarioCel(log);
                }
                else
                {
                    logLogin.Instancia.CambiarContra(usu, con);
                    Login log = new Login();
                    log.usuario = usu;
                    logLogin.Instancia.HabilitarUsuario(log);
                }
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("Inicia sesion", "Login",
                    botones, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.Hide();
                    FrmLogin f = new FrmLogin();
                    f.Show();
                }

            }
            else
            {
                MessageBox.Show("Falta completar o corregir algun dato");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Estas seguro de salir", "Salir",
                botones, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Hide();
                FrmLogin f = new FrmLogin();
                f.Show();
            }
        }
    }
}
