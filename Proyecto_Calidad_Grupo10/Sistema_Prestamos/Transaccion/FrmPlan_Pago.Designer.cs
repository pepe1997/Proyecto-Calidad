﻿namespace Sistema_Prestamos.Transaccion
{
    partial class FrmPlan_Pago
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.gbConsolidado = new System.Windows.Forms.GroupBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldoCuenta = new System.Windows.Forms.TextBox();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesConsolidado = new System.Windows.Forms.TextBox();
            this.txtIdConsolidado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPlan = new System.Windows.Forms.GroupBox();
            this.txtMesPlan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaPlan = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.txtInteresPLan = new System.Windows.Forms.TextBox();
            this.txtCapDevolver = new System.Windows.Forms.TextBox();
            this.txtCapRemanente = new System.Windows.Forms.TextBox();
            this.txtIdPlan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.gbConsolidado.SuspendLayout();
            this.gbPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnAnular);
            this.groupBox3.Location = new System.Drawing.Point(740, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 110);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(17, 32);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 49);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(17, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 49);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(162, 32);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(99, 49);
            this.btnAnular.TabIndex = 10;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dgvPlan
            // 
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(22, 385);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersWidth = 51;
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.Size = new System.Drawing.Size(1215, 380);
            this.dgvPlan.TabIndex = 32;
            this.dgvPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellDoubleClick);
            // 
            // gbConsolidado
            // 
            this.gbConsolidado.Controls.Add(this.txtMontoPrestamo);
            this.gbConsolidado.Controls.Add(this.label2);
            this.gbConsolidado.Controls.Add(this.txtSaldoCuenta);
            this.gbConsolidado.Controls.Add(this.txtIdCuenta);
            this.gbConsolidado.Controls.Add(this.label3);
            this.gbConsolidado.Controls.Add(this.txtMesConsolidado);
            this.gbConsolidado.Controls.Add(this.txtIdConsolidado);
            this.gbConsolidado.Controls.Add(this.label6);
            this.gbConsolidado.Controls.Add(this.label1);
            this.gbConsolidado.Location = new System.Drawing.Point(740, 12);
            this.gbConsolidado.Name = "gbConsolidado";
            this.gbConsolidado.Size = new System.Drawing.Size(497, 213);
            this.gbConsolidado.TabIndex = 31;
            this.gbConsolidado.TabStop = false;
            this.gbConsolidado.Text = "Consolidado";
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(282, 97);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(104, 22);
            this.txtMontoPrestamo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Monto";
            // 
            // txtSaldoCuenta
            // 
            this.txtSaldoCuenta.Location = new System.Drawing.Point(79, 152);
            this.txtSaldoCuenta.Name = "txtSaldoCuenta";
            this.txtSaldoCuenta.Size = new System.Drawing.Size(68, 22);
            this.txtSaldoCuenta.TabIndex = 16;
            this.txtSaldoCuenta.Visible = false;
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(100, 97);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(68, 22);
            this.txtIdCuenta.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID Cuenta";
            // 
            // txtMesConsolidado
            // 
            this.txtMesConsolidado.Location = new System.Drawing.Point(305, 36);
            this.txtMesConsolidado.Name = "txtMesConsolidado";
            this.txtMesConsolidado.Size = new System.Drawing.Size(112, 22);
            this.txtMesConsolidado.TabIndex = 10;
            // 
            // txtIdConsolidado
            // 
            this.txtIdConsolidado.Location = new System.Drawing.Point(79, 36);
            this.txtIdConsolidado.Name = "txtIdConsolidado";
            this.txtIdConsolidado.Size = new System.Drawing.Size(89, 22);
            this.txtIdConsolidado.TabIndex = 6;
            this.txtIdConsolidado.TextChanged += new System.EventHandler(this.txtIdConsolidado_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "# Meses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // gbPlan
            // 
            this.gbPlan.Controls.Add(this.txtMesPlan);
            this.gbPlan.Controls.Add(this.label11);
            this.gbPlan.Controls.Add(this.dtpFechaPlan);
            this.gbPlan.Controls.Add(this.btnModificar);
            this.gbPlan.Controls.Add(this.btnAgregar);
            this.gbPlan.Controls.Add(this.txtTotalPago);
            this.gbPlan.Controls.Add(this.txtInteresPLan);
            this.gbPlan.Controls.Add(this.txtCapDevolver);
            this.gbPlan.Controls.Add(this.txtCapRemanente);
            this.gbPlan.Controls.Add(this.txtIdPlan);
            this.gbPlan.Controls.Add(this.label4);
            this.gbPlan.Controls.Add(this.label5);
            this.gbPlan.Controls.Add(this.label7);
            this.gbPlan.Controls.Add(this.label8);
            this.gbPlan.Controls.Add(this.label9);
            this.gbPlan.Controls.Add(this.label10);
            this.gbPlan.Location = new System.Drawing.Point(22, 12);
            this.gbPlan.Name = "gbPlan";
            this.gbPlan.Size = new System.Drawing.Size(694, 337);
            this.gbPlan.TabIndex = 34;
            this.gbPlan.TabStop = false;
            this.gbPlan.Text = "Plan Pago";
            // 
            // txtMesPlan
            // 
            this.txtMesPlan.Enabled = false;
            this.txtMesPlan.Location = new System.Drawing.Point(248, 45);
            this.txtMesPlan.Name = "txtMesPlan";
            this.txtMesPlan.Size = new System.Drawing.Size(98, 22);
            this.txtMesPlan.TabIndex = 21;
            this.txtMesPlan.TextChanged += new System.EventHandler(this.txtMesPlan_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha";
            // 
            // dtpFechaPlan
            // 
            this.dtpFechaPlan.Location = new System.Drawing.Point(382, 191);
            this.dtpFechaPlan.Name = "dtpFechaPlan";
            this.dtpFechaPlan.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaPlan.TabIndex = 19;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(539, 259);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 49);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(382, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 49);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Location = new System.Drawing.Point(137, 190);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(106, 22);
            this.txtTotalPago.TabIndex = 11;
            this.txtTotalPago.TextChanged += new System.EventHandler(this.txtTotalPago_TextChanged);
            // 
            // txtInteresPLan
            // 
            this.txtInteresPLan.Enabled = false;
            this.txtInteresPLan.Location = new System.Drawing.Point(404, 114);
            this.txtInteresPLan.Name = "txtInteresPLan";
            this.txtInteresPLan.Size = new System.Drawing.Size(97, 22);
            this.txtInteresPLan.TabIndex = 10;
            this.txtInteresPLan.TextChanged += new System.EventHandler(this.txtInteresPLan_TextChanged);
            // 
            // txtCapDevolver
            // 
            this.txtCapDevolver.Enabled = false;
            this.txtCapDevolver.Location = new System.Drawing.Point(172, 114);
            this.txtCapDevolver.Name = "txtCapDevolver";
            this.txtCapDevolver.Size = new System.Drawing.Size(112, 22);
            this.txtCapDevolver.TabIndex = 9;
            this.txtCapDevolver.TextChanged += new System.EventHandler(this.txtCapDevolver_TextChanged);
            // 
            // txtCapRemanente
            // 
            this.txtCapRemanente.Enabled = false;
            this.txtCapRemanente.Location = new System.Drawing.Point(539, 45);
            this.txtCapRemanente.Name = "txtCapRemanente";
            this.txtCapRemanente.Size = new System.Drawing.Size(98, 22);
            this.txtCapRemanente.TabIndex = 8;
            // 
            // txtIdPlan
            // 
            this.txtIdPlan.Enabled = false;
            this.txtIdPlan.Location = new System.Drawing.Point(67, 45);
            this.txtIdPlan.Name = "txtIdPlan";
            this.txtIdPlan.Size = new System.Drawing.Size(78, 22);
            this.txtIdPlan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Interes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Capital Remanente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Capital Devolver";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id";
            // 
            // FrmPlan_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 777);
            this.Controls.Add(this.gbPlan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.gbConsolidado);
            this.Name = "FrmPlan_Pago";
            this.Text = "FrmPlan_Pago";
            this.Load += new System.EventHandler(this.FrmPlan_Pago_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.gbConsolidado.ResumeLayout(false);
            this.gbConsolidado.PerformLayout();
            this.gbPlan.ResumeLayout(false);
            this.gbPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.GroupBox gbConsolidado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPlan;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.TextBox txtInteresPLan;
        private System.Windows.Forms.TextBox txtCapDevolver;
        private System.Windows.Forms.TextBox txtCapRemanente;
        private System.Windows.Forms.TextBox txtIdPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaPlan;
        private System.Windows.Forms.TextBox txtMesPlan;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIdConsolidado;
        public System.Windows.Forms.TextBox txtMesConsolidado;
        public System.Windows.Forms.TextBox txtSaldoCuenta;
        public System.Windows.Forms.TextBox txtIdCuenta;
        public System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Label label2;
    }
}