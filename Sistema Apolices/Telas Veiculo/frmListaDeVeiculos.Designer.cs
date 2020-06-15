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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApolices = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.PictureBox();
            this.btnNovoVeiculo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnApolices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCarros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApolices);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnNovoVeiculo);
            this.panel1.Controls.Add(this.dgvCarros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 254);
            this.panel1.TabIndex = 6;
            // 
            // btnApolices
            // 
            this.btnApolices.Image = global::Sistema_Apolices.Properties.Resources.apolice;
            this.btnApolices.Location = new System.Drawing.Point(638, 12);
            this.btnApolices.Name = "btnApolices";
            this.btnApolices.Size = new System.Drawing.Size(48, 40);
            this.btnApolices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnApolices.TabIndex = 6;
            this.btnApolices.TabStop = false;
            this.btnApolices.Click += new System.EventHandler(this.btnApolices_Click);
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
            // frmListaDeVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 254);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmListaDeVeiculos";
            this.Text = "Lista de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnApolices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.PictureBox btnNovoVeiculo;
        private System.Windows.Forms.PictureBox btnAlterar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnApolices;
    }
}

