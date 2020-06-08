namespace Sistema_Apolices
{
    partial class frmListaDeMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.PictureBox();
            this.btnNovaMarca = new System.Windows.Forms.PictureBox();
            this.lblNvNome = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNvNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 58);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(240, 184);
            this.dgvMarcas.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Sistema_Apolices.Properties.Resources.Editar;
            this.btnAlterar.Location = new System.Drawing.Point(66, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 40);
            this.btnAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Image = global::Sistema_Apolices.Properties.Resources.Adicionar;
            this.btnNovaMarca.Location = new System.Drawing.Point(12, 12);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(48, 40);
            this.btnNovaMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovaMarca.TabIndex = 5;
            this.btnNovaMarca.TabStop = false;
            this.btnNovaMarca.Click += new System.EventHandler(this.btnNovaMarca_Click);
            // 
            // lblNvNome
            // 
            this.lblNvNome.AutoSize = true;
            this.lblNvNome.Location = new System.Drawing.Point(376, 91);
            this.lblNvNome.Name = "lblNvNome";
            this.lblNvNome.Size = new System.Drawing.Size(65, 13);
            this.lblNvNome.TabIndex = 21;
            this.lblNvNome.Text = "Novo nome:";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(376, 58);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(310, 13);
            this.lblAviso.TabIndex = 20;
            this.lblAviso.Text = "*Os Modelos continuaram ligados a Marca depois de sua edição";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(530, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(611, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNvNome
            // 
            this.txtNvNome.Location = new System.Drawing.Point(379, 107);
            this.txtNvNome.MaxLength = 100;
            this.txtNvNome.Name = "txtNvNome";
            this.txtNvNome.Size = new System.Drawing.Size(130, 20);
            this.txtNvNome.TabIndex = 17;
            // 
            // frmListaDeMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 254);
            this.Controls.Add(this.lblNvNome);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNvNome);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovaMarca);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaDeMarcas";
            this.Text = "frmListaDeMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.PictureBox btnAlterar;
        private System.Windows.Forms.PictureBox btnNovaMarca;
        private System.Windows.Forms.Label lblNvNome;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNvNome;
    }
}