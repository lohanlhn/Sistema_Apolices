namespace Sistema_Apolices
{
    partial class Principal
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
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.cdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRenavam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdId,
            this.cdMarca,
            this.clModelo,
            this.cl,
            this.clPlaca,
            this.clRenavam});
            this.dgvCarros.Location = new System.Drawing.Point(38, 78);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.RowHeadersVisible = false;
            this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarros.Size = new System.Drawing.Size(674, 184);
            this.dgvCarros.TabIndex = 0;
            // 
            // cdId
            // 
            this.cdId.DataPropertyName = "id";
            this.cdId.HeaderText = "Código";
            this.cdId.Name = "cdId";
            this.cdId.ReadOnly = true;
            // 
            // cdMarca
            // 
            this.cdMarca.DataPropertyName = "Marca.nome";
            this.cdMarca.HeaderText = "Marca";
            this.cdMarca.Name = "cdMarca";
            this.cdMarca.ReadOnly = true;
            // 
            // clModelo
            // 
            this.clModelo.DataPropertyName = "Entities.Modelo.nome";
            this.clModelo.HeaderText = "Modelo";
            this.clModelo.Name = "clModelo";
            this.clModelo.ReadOnly = true;
            // 
            // cl
            // 
            this.cl.DataPropertyName = "chassi";
            this.cl.HeaderText = "Chassi";
            this.cl.Name = "cl";
            this.cl.ReadOnly = true;
            // 
            // clPlaca
            // 
            this.clPlaca.DataPropertyName = "placa";
            this.clPlaca.HeaderText = "Placa";
            this.clPlaca.Name = "clPlaca";
            this.clPlaca.ReadOnly = true;
            // 
            // clRenavam
            // 
            this.clRenavam.DataPropertyName = "renavam";
            this.clRenavam.HeaderText = "Renavam";
            this.clRenavam.Name = "clRenavam";
            this.clRenavam.ReadOnly = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarros);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRenavam;
    }
}

