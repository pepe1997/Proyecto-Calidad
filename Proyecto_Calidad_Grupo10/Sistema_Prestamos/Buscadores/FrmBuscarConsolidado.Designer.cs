namespace Sistema_Prestamos.Buscadores
{
    partial class FrmBuscarConsolidado
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
            this.dgvConsolidado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsolidado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(23, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 22);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // dgvConsolidado
            // 
            this.dgvConsolidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsolidado.Location = new System.Drawing.Point(23, 59);
            this.dgvConsolidado.Name = "dgvConsolidado";
            this.dgvConsolidado.RowHeadersWidth = 51;
            this.dgvConsolidado.RowTemplate.Height = 24;
            this.dgvConsolidado.Size = new System.Drawing.Size(756, 401);
            this.dgvConsolidado.TabIndex = 6;
            this.dgvConsolidado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsolidado_CellDoubleClick);
            // 
            // FrmBuscarConsolidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvConsolidado);
            this.Name = "FrmBuscarConsolidado";
            this.Text = "FrmBuscarConsolidado";
            this.Load += new System.EventHandler(this.FrmBuscarConsolidado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsolidado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.DataGridView dgvConsolidado;
    }
}