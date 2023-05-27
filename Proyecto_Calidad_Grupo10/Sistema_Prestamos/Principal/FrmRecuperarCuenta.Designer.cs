namespace Sistema_Prestamos.Principal
{
    partial class FrmRecuperarCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.MaskedTextBox();
            this.txtVerificarContra = new System.Windows.Forms.MaskedTextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContra = new System.Windows.Forms.Label();
            this.lbRepetirContra = new System.Windows.Forms.Label();
            this.txtCaptcha = new System.Windows.Forms.MaskedTextBox();
            this.txtVerificarCaptcha = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbVerificarCaptcha = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(244, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Repetir Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(244, 110);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(149, 22);
            this.txtContra.TabIndex = 4;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtVerificarContra
            // 
            this.txtVerificarContra.Location = new System.Drawing.Point(244, 169);
            this.txtVerificarContra.Name = "txtVerificarContra";
            this.txtVerificarContra.PasswordChar = '*';
            this.txtVerificarContra.Size = new System.Drawing.Size(149, 22);
            this.txtVerificarContra.TabIndex = 5;
            this.txtVerificarContra.TextChanged += new System.EventHandler(this.txtVerificarContra_TextChanged);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(432, 56);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(0, 16);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Visible = false;
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Location = new System.Drawing.Point(432, 116);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(0, 16);
            this.lbContra.TabIndex = 7;
            this.lbContra.Visible = false;
            // 
            // lbRepetirContra
            // 
            this.lbRepetirContra.AutoSize = true;
            this.lbRepetirContra.Location = new System.Drawing.Point(432, 175);
            this.lbRepetirContra.Name = "lbRepetirContra";
            this.lbRepetirContra.Size = new System.Drawing.Size(0, 16);
            this.lbRepetirContra.TabIndex = 8;
            this.lbRepetirContra.Visible = false;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(244, 227);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.ReadOnly = true;
            this.txtCaptcha.Size = new System.Drawing.Size(149, 22);
            this.txtCaptcha.TabIndex = 9;
            // 
            // txtVerificarCaptcha
            // 
            this.txtVerificarCaptcha.Location = new System.Drawing.Point(244, 293);
            this.txtVerificarCaptcha.Name = "txtVerificarCaptcha";
            this.txtVerificarCaptcha.Size = new System.Drawing.Size(149, 22);
            this.txtVerificarCaptcha.TabIndex = 10;
            this.txtVerificarCaptcha.TextChanged += new System.EventHandler(this.txtVerificarCaptcha_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Captcha";
            // 
            // lbVerificarCaptcha
            // 
            this.lbVerificarCaptcha.AutoSize = true;
            this.lbVerificarCaptcha.Location = new System.Drawing.Point(432, 299);
            this.lbVerificarCaptcha.Name = "lbVerificarCaptcha";
            this.lbVerificarCaptcha.Size = new System.Drawing.Size(0, 16);
            this.lbVerificarCaptcha.TabIndex = 12;
            this.lbVerificarCaptcha.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(190, 385);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 33);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRecuperarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 575);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbVerificarCaptcha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVerificarCaptcha);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.lbRepetirContra);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtVerificarContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecuperarCuenta";
            this.Text = "FrmRecuperarCuenta";
            this.Load += new System.EventHandler(this.FrmRecuperarCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtContra;
        private System.Windows.Forms.MaskedTextBox txtVerificarContra;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.Label lbRepetirContra;
        private System.Windows.Forms.MaskedTextBox txtCaptcha;
        private System.Windows.Forms.MaskedTextBox txtVerificarCaptcha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbVerificarCaptcha;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}