namespace Sistema_Apolices
{
    partial class frmListaDeVeiculos
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
            this.btnNovoVeiculo = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(12, 58);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.RowHeadersVisible = false;
            this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarros.Size = new System.Drawing.Size(674, 184);
            this.dgvCarros.TabIndex = 0;
            // 
            // btnNovoVeiculo
            // 
            this.btnNovoVeiculo.Image = global::Sistema_Apolices.Properties.Resources.Adicionar;
            this.btnNovoVeiculo.Location = new System.Drawing.Point(12, 12);
            this.btnNovoVeiculo.Name = "btnNovoVeiculo";
            this.btnNovoVeiculo.Size = new System.Drawing.Size(48, 40);
            this.btnNovoVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovoVeiculo.TabIndex = 3;
            this.btnNovoVeiculo.TabStop = false;
            this.btnNovoVeiculo.Click += new System.EventHandler(this.btnNovoVeiculo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Sistema_Apolices.Properties.Resources.Editar;
            this.btnAlterar.Location = new System.Drawing.Point(77, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 40);
            this.btnAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmListaDeVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 254);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovoVeiculo);
            this.Controls.Add(this.dgvCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmListaDeVeiculos";
            this.Text = "Lista de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.PictureBox btnNovoVeiculo;
        private System.Windows.Forms.PictureBox btnAlterar;
    }
}

