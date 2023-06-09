﻿namespace Sistema_Prestamos.Mantendedor
{
    partial class FrmConsolidado
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
            this.dgvConsolidado = new System.Windows.Forms.DataGridView();
            this.gbConsolidado = new System.Windows.Forms.GroupBox();
            this.cmbEstadoConsolidado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtInteresTotal = new System.Windows.Forms.TextBox();
            this.txtDevolucionTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtInteresConsolidado = new System.Windows.Forms.TextBox();
            this.txtIdConsolidado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCuenta = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNroCuenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSeleccionarPrestamo = new System.Windows.Forms.Button();
            this.gbPrestamo = new System.Windows.Forms.GroupBox();
            this.cmbEstadoPrestamo = new System.Windows.Forms.ComboBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSeleccionarPrestamoBusqueda = new System.Windows.Forms.Button();
            this.btnSeleccionarCuentaBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsolidado)).BeginInit();
            this.gbConsolidado.SuspendLayout();
            this.gbCuenta.SuspendLayout();
            this.gbPrestamo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsolidado
            // 
            this.dgvConsolidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsolidado.Location = new System.Drawing.Point(22, 362);
            this.dgvConsolidado.Name = "dgvConsolidado";
            this.dgvConsolidado.RowHeadersWidth = 51;
            this.dgvConsolidado.RowTemplate.Height = 24;
            this.dgvConsolidado.Size = new System.Drawing.Size(1050, 445);
            this.dgvConsolidado.TabIndex = 18;
            this.dgvConsolidado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsolidado_CellDoubleClick);
            // 
            // gbConsolidado
            // 
            this.gbConsolidado.Controls.Add(this.cmbEstadoConsolidado);
            this.gbConsolidado.Controls.Add(this.label10);
            this.gbConsolidado.Controls.Add(this.txtMontoTotal);
            this.gbConsolidado.Controls.Add(this.txtInteresTotal);
            this.gbConsolidado.Controls.Add(this.txtDevolucionTotal);
            this.gbConsolidado.Controls.Add(this.label7);
            this.gbConsolidado.Controls.Add(this.label5);
            this.gbConsolidado.Controls.Add(this.label3);
            this.gbConsolidado.Controls.Add(this.txtMeses);
            this.gbConsolidado.Controls.Add(this.btnCancelar);
            this.gbConsolidado.Controls.Add(this.btnAgregar);
            this.gbConsolidado.Controls.Add(this.txtInteresConsolidado);
            this.gbConsolidado.Controls.Add(this.txtIdConsolidado);
            this.gbConsolidado.Controls.Add(this.label6);
            this.gbConsolidado.Controls.Add(this.label2);
            this.gbConsolidado.Controls.Add(this.label1);
            this.gbConsolidado.Location = new System.Drawing.Point(22, 191);
            this.gbConsolidado.Name = "gbConsolidado";
            this.gbConsolidado.Size = new System.Drawing.Size(1215, 165);
            this.gbConsolidado.TabIndex = 13;
            this.gbConsolidado.TabStop = false;
            this.gbConsolidado.Text = "Consolidado";
            this.gbConsolidado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbEstadoConsolidado
            // 
            this.cmbEstadoConsolidado.Enabled = false;
            this.cmbEstadoConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoConsolidado.FormattingEnabled = true;
            this.cmbEstadoConsolidado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoConsolidado.Location = new System.Drawing.Point(321, 118);
            this.cmbEstadoConsolidado.Name = "cmbEstadoConsolidado";
            this.cmbEstadoConsolidado.Size = new System.Drawing.Size(160, 24);
            this.cmbEstadoConsolidado.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Estado";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(122, 118);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 22);
            this.txtMontoTotal.TabIndex = 24;
            // 
            // txtInteresTotal
            // 
            this.txtInteresTotal.Enabled = false;
            this.txtInteresTotal.Location = new System.Drawing.Point(1004, 42);
            this.txtInteresTotal.Name = "txtInteresTotal";
            this.txtInteresTotal.Size = new System.Drawing.Size(100, 22);
            this.txtInteresTotal.TabIndex = 23;
            // 
            // txtDevolucionTotal
            // 
            this.txtDevolucionTotal.Enabled = false;
            this.txtDevolucionTotal.Location = new System.Drawing.Point(744, 42);
            this.txtDevolucionTotal.Name = "txtDevolucionTotal";
            this.txtDevolucionTotal.Size = new System.Drawing.Size(100, 22);
            this.txtDevolucionTotal.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Monto Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Interese Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Devolucion Total";
            // 
            // txtMeses
            // 
            this.txtMeses.Enabled = false;
            this.txtMeses.Location = new System.Drawing.Point(280, 42);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(134, 22);
            this.txtMeses.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1085, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 31);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(963, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 31);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtInteresConsolidado
            // 
            this.txtInteresConsolidado.Enabled = false;
            this.txtInteresConsolidado.Location = new System.Drawing.Point(529, 42);
            this.txtInteresConsolidado.Name = "txtInteresConsolidado";
            this.txtInteresConsolidado.Size = new System.Drawing.Size(69, 22);
            this.txtInteresConsolidado.TabIndex = 9;
            // 
            // txtIdConsolidado
            // 
            this.txtIdConsolidado.Location = new System.Drawing.Point(75, 42);
            this.txtIdConsolidado.Name = "txtIdConsolidado";
            this.txtIdConsolidado.Size = new System.Drawing.Size(89, 22);
            this.txtIdConsolidado.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "# Meses";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // gbCuenta
            // 
            this.gbCuenta.Controls.Add(this.btnSeleccionarCuentaBusqueda);
            this.gbCuenta.Controls.Add(this.txtSaldo);
            this.gbCuenta.Controls.Add(this.label13);
            this.gbCuenta.Controls.Add(this.button2);
            this.gbCuenta.Controls.Add(this.txtNroCuenta);
            this.gbCuenta.Controls.Add(this.label12);
            this.gbCuenta.Controls.Add(this.txtIdCuenta);
            this.gbCuenta.Controls.Add(this.label8);
            this.gbCuenta.Location = new System.Drawing.Point(740, 12);
            this.gbCuenta.Name = "gbCuenta";
            this.gbCuenta.Size = new System.Drawing.Size(497, 173);
            this.gbCuenta.TabIndex = 28;
            this.gbCuenta.TabStop = false;
            this.gbCuenta.Text = "Cuenta";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(84, 111);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(90, 22);
            this.txtSaldo.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Saldo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Seleccionar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNroCuenta
            // 
            this.txtNroCuenta.Enabled = false;
            this.txtNroCuenta.Location = new System.Drawing.Point(267, 48);
            this.txtNroCuenta.Name = "txtNroCuenta";
            this.txtNroCuenta.Size = new System.Drawing.Size(186, 22);
            this.txtNroCuenta.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nro Cuenta";
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Enabled = false;
            this.txtIdCuenta.Location = new System.Drawing.Point(64, 48);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(90, 22);
            this.txtIdCuenta.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "id";
            // 
            // btnSeleccionarPrestamo
            // 
            this.btnSeleccionarPrestamo.Location = new System.Drawing.Point(529, 102);
            this.btnSeleccionarPrestamo.Name = "btnSeleccionarPrestamo";
            this.btnSeleccionarPrestamo.Size = new System.Drawing.Size(110, 46);
            this.btnSeleccionarPrestamo.TabIndex = 3;
            this.btnSeleccionarPrestamo.Text = "Seleccionar ";
            this.btnSeleccionarPrestamo.UseVisualStyleBackColor = true;
            this.btnSeleccionarPrestamo.Click += new System.EventHandler(this.btnSeleccionarPrestamo_Click);
            // 
            // gbPrestamo
            // 
            this.gbPrestamo.Controls.Add(this.btnSeleccionarPrestamoBusqueda);
            this.gbPrestamo.Controls.Add(this.label14);
            this.gbPrestamo.Controls.Add(this.txtIdCliente);
            this.gbPrestamo.Controls.Add(this.cmbEstadoPrestamo);
            this.gbPrestamo.Controls.Add(this.btnSeleccionarPrestamo);
            this.gbPrestamo.Controls.Add(this.txtMontoPrestamo);
            this.gbPrestamo.Controls.Add(this.txtIdPrestamo);
            this.gbPrestamo.Controls.Add(this.label4);
            this.gbPrestamo.Controls.Add(this.label9);
            this.gbPrestamo.Controls.Add(this.label11);
            this.gbPrestamo.Location = new System.Drawing.Point(22, 12);
            this.gbPrestamo.Name = "gbPrestamo";
            this.gbPrestamo.Size = new System.Drawing.Size(694, 173);
            this.gbPrestamo.TabIndex = 29;
            this.gbPrestamo.TabStop = false;
            this.gbPrestamo.Text = "Prestamo";
            // 
            // cmbEstadoPrestamo
            // 
            this.cmbEstadoPrestamo.Enabled = false;
            this.cmbEstadoPrestamo.FormattingEnabled = true;
            this.cmbEstadoPrestamo.Items.AddRange(new object[] {
            "Pendiente",
            "Aprobado",
            "Denegado"});
            this.cmbEstadoPrestamo.Location = new System.Drawing.Point(477, 45);
            this.cmbEstadoPrestamo.Name = "cmbEstadoPrestamo";
            this.cmbEstadoPrestamo.Size = new System.Drawing.Size(162, 24);
            this.cmbEstadoPrestamo.TabIndex = 8;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Enabled = false;
            this.txtMontoPrestamo.Location = new System.Drawing.Point(242, 48);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(112, 22);
            this.txtMontoPrestamo.TabIndex = 7;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Enabled = false;
            this.txtIdPrestamo.Location = new System.Drawing.Point(75, 48);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(78, 22);
            this.txtIdPrestamo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnAnular);
            this.groupBox3.Location = new System.Drawing.Point(1093, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 341);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 49);
            this.button4.TabIndex = 13;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 49);
            this.button3.TabIndex = 12;
            this.button3.Text = "Pagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(18, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 49);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(18, 107);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(99, 49);
            this.btnAnular.TabIndex = 10;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(122, 129);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(78, 22);
            this.txtIdCliente.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Id Cliente";
            // 
            // btnSeleccionarPrestamoBusqueda
            // 
            this.btnSeleccionarPrestamoBusqueda.Location = new System.Drawing.Point(529, 102);
            this.btnSeleccionarPrestamoBusqueda.Name = "btnSeleccionarPrestamoBusqueda";
            this.btnSeleccionarPrestamoBusqueda.Size = new System.Drawing.Size(110, 46);
            this.btnSeleccionarPrestamoBusqueda.TabIndex = 12;
            this.btnSeleccionarPrestamoBusqueda.Text = "Seleccionar ";
            this.btnSeleccionarPrestamoBusqueda.UseVisualStyleBackColor = true;
            this.btnSeleccionarPrestamoBusqueda.Visible = false;
            this.btnSeleccionarPrestamoBusqueda.Click += new System.EventHandler(this.btnSeleccionarPrestamoBusqueda_Click);
            // 
            // btnSeleccionarCuentaBusqueda
            // 
            this.btnSeleccionarCuentaBusqueda.Location = new System.Drawing.Point(343, 102);
            this.btnSeleccionarCuentaBusqueda.Name = "btnSeleccionarCuentaBusqueda";
            this.btnSeleccionarCuentaBusqueda.Size = new System.Drawing.Size(110, 46);
            this.btnSeleccionarCuentaBusqueda.TabIndex = 18;
            this.btnSeleccionarCuentaBusqueda.Text = "Seleccionar ";
            this.btnSeleccionarCuentaBusqueda.UseVisualStyleBackColor = true;
            this.btnSeleccionarCuentaBusqueda.Visible = false;
            this.btnSeleccionarCuentaBusqueda.Click += new System.EventHandler(this.btnSeleccionarCuentaBusqueda_Click);
            // 
            // FrmConsolidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 885);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbPrestamo);
            this.Controls.Add(this.gbCuenta);
            this.Controls.Add(this.dgvConsolidado);
            this.Controls.Add(this.gbConsolidado);
            this.Name = "FrmConsolidado";
            this.Text = "FrmConsolidado";
            this.Load += new System.EventHandler(this.FrmConsolidado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsolidado)).EndInit();
            this.gbConsolidado.ResumeLayout(false);
            this.gbConsolidado.PerformLayout();
            this.gbCuenta.ResumeLayout(false);
            this.gbCuenta.PerformLayout();
            this.gbPrestamo.ResumeLayout(false);
            this.gbPrestamo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsolidado;
        private System.Windows.Forms.GroupBox gbConsolidado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCuenta;
        public System.Windows.Forms.TextBox txtNroCuenta;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSeleccionarPrestamo;
        private System.Windows.Forms.GroupBox gbPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtMontoPrestamo;
        public System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbEstadoPrestamo;
        public System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtInteresConsolidado;
        public System.Windows.Forms.TextBox txtIdConsolidado;
        public System.Windows.Forms.TextBox txtMeses;
        public System.Windows.Forms.TextBox txtMontoTotal;
        public System.Windows.Forms.TextBox txtInteresTotal;
        public System.Windows.Forms.TextBox txtDevolucionTotal;
        public System.Windows.Forms.ComboBox cmbEstadoConsolidado;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnSeleccionarPrestamoBusqueda;
        private System.Windows.Forms.Button btnSeleccionarCuentaBusqueda;
    }
}