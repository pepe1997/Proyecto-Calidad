using entCliente;
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
using entLogin;
using System.Reflection;

namespace Sistema_Prestamos.Principal
{

    public partial class FrmRegistro : Form
    {
        char[] usuario = new char[8];
        public FrmRegistro()
        {
            InitializeComponent();
            txtCaptcha.Text = logLogin.Instancia.GenerarLetras(10);
            


        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            
        }
        private void LimpiarVariable()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
            txtCaptcha.Text = "";
            txtVerificarCaptcha.Text = "";
        }
       

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ((lbNombre.Text == "Correcto") && (lbApellido.Text == "Correcto") && (lbCelular.Text == "Correcto") && (lbContraseña.Text == "Fuerte") && (lbVerificarCaptcha.Text=="Correcto")&&((lbUsuario.Text == "Correcto")))
            {
                InsertarUsuario();
                LimpiarVariable();
                lbNombre.Visible = false;
                lbApellido.Visible = false;
                lbCelular.Visible = false;
                lbContraseña.Visible = false;
                lbVerificarCaptcha.Visible = false;
                lbUsuario.Visible = false;
                MessageBox.Show("Se registro correctamente");
                this.Hide();
                FrmLogin f = new FrmLogin();
                f.Show();
                
                
            }
            else
            {
                MessageBox.Show("Presenta error en al campo");
            }

        }
        private void InsertarUsuario()
        {
            try
            {
                Login log = new Login();
                log.nombre = txtNombre.Text.Trim();
                log.apellido = txtApellido.Text.Trim();
                log.celular = txtCelular.Text.Trim();
                log.usuario = txtUsuario.Text.Trim();
                log.contra = txtContra.Text.Trim();
                log.rol = cmbRol.SelectedItem.ToString();
                logLogin.Instancia.InsertarUsuario(log);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }

        }

        private void txtUsuario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Estas seguro de salir","Salir",
                botones,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Hide();
                FrmLogin f = new FrmLogin();
                f.Show();
            }

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            GenerarUsurio();
            string cadena = string.Join("", usuario);
            txtUsuario.Text = cadena;
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void GenerarUsurio()
        {
            if ((lbNombre.Text == "Correcto") && (lbApellido.Text == "Correcto") && (lbCelular.Text == "Correcto"))
            {
                string nombre = txtNombre.Text.Replace(" ", "").ToLower();
                string apelldo = txtApellido.Text.Replace(" ", "").ToLower();
                string celular = txtCelular.Text.Replace(" ", "").Trim();
                int c = 0;
                int j = 0;


                for (int i = 0; i < 3; i++)
                {
                    if (usuario.Length == 0)
                    {
                        usuario[0] = nombre[i];
                    }
                    else
                    {
                        usuario[i] = nombre[i];
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    usuario[3 + i] = apelldo[i];

                }
                for (int i = 0; i < 2; i++)
                {
                    usuario[6 + i] = celular[i];

                }
                lbUsuario.ForeColor = Color.Green;
                lbUsuario.Text = "Correcto";
                lbUsuario.Visible = true;
            }
            else
            {
                lbUsuario.ForeColor = Color.Red;
                lbUsuario.Text = "Falta llenar un campo";
                lbUsuario.Visible = true;
            }
            
        }
        private void ValidadCelular()
        {
            string cel = txtCelular.Text;
            bool v = logLogin.Instancia.VerificarCelular(cel);

            if (v == true)
            {
                lbCelular.ForeColor = Color.Green;
                lbCelular.Text = "Correcto";
                lbCelular.Visible = true;
            }
            else
            {
                lbCelular.ForeColor = Color.Red;
                lbCelular.Text = "Incorrecto";
                lbCelular.Visible = true;
            }
        }

        private void txtContra_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void txtCelular_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCelular_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            ValidadCelular();
        }

        private void txtContra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            
            string cont = string.Join("", txtContra.Text);
            bool v = logLogin.Instancia.VerificarPassword(cont);
            if (v == true)
            {
                lbContraseña.ForeColor = Color.Green;
                lbContraseña.Text = "Fuerte";
                lbContraseña.Visible = true;
            }
            else
            {
                lbContraseña.ForeColor = Color.Red;
                lbContraseña.Text = "Debil";
                lbContraseña.Visible = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nomb = string.Join("", txtNombre.Text);
            bool v = logLogin.Instancia.ValidarNombres(nomb);
            if (v == true)
            {
                lbNombre.ForeColor = Color.Green;
                lbNombre.Text = "Correcto";
                lbNombre.Visible = true;
            }
            else
            {
                lbNombre.ForeColor = Color.Red;
                lbNombre.Text = "Incorrecto";
                lbNombre.Visible = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            string apell = string.Join("", txtApellido.Text);
            bool v = logLogin.Instancia.ValidarNombres(apell);
            if (v == true)
            {
                lbApellido.ForeColor = Color.Green;
                lbApellido.Text = "Correcto";
                lbApellido.Visible = true;
            }
            else
            {
                lbApellido.ForeColor = Color.Red;
                lbApellido.Text = "Incorrecto";
                lbApellido.Visible = true;
            }
        }

        private void txtVerificarCaptcha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
