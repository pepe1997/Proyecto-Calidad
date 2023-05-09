namespace Sistema_Prestamos.Buscadores
{
    partial class FrmBuscarTipCuenta
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dgvTipCuenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(78, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 22);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(22, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(20, 16);
            this.id.TabIndex = 7;
            this.id.Text = "ID";
            // 
            // dgvTipCuenta
            // 
            this.dgvTipCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipCuenta.Location = new System.Drawing.Point(12, 90);
            this.dgvTipCuenta.Name = "dgvTipCuenta";
            this.dgvTipCuenta.RowHeadersWidth = 51;
            this.dgvTipCuenta.RowTemplate.Height = 24;
            this.dgvTipCuenta.Size = new System.Drawing.Size(432, 401);
            this.dgvTipCuenta.TabIndex = 6;
            this.dgvTipCuenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipCuenta_CellDoubleClick);
            // 
            // FrmBuscarTipCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 512);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgvTipCuenta);
            this.Name = "FrmBuscarTipCuenta";
            this.Text = "FrmBuscarTipCuenta";
            this.Load += new System.EventHandler(this.FrmBuscarTipCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label id;
        public System.Windows.Forms.DataGridView dgvTipCuenta;
    }
}