namespace Sistema_Apolices
{
    partial class frmListaDeModelos
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
            this.lblNvNome = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNvNome = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.PictureBox();
            this.btnNovoModelo = new System.Windows.Forms.PictureBox();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNvNome
            // 
            this.lblNvNome.AutoSize = true;
            this.lblNvNome.Location = new System.Drawing.Point(376, 131);
            this.lblNvNome.Name = "lblNvNome";
            this.lblNvNome.Size = new System.Drawing.Size(65, 13);
            this.lblNvNome.TabIndex = 29;
            this.lblNvNome.Text = "Novo nome:";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(376, 58);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(310, 13);
            this.lblAviso.TabIndex = 28;
            this.lblAviso.Text = "*Os Modelos continuaram ligados a Marca depois de sua edição";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(530, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(611, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNvNome
            // 
            this.txtNvNome.Location = new System.Drawing.Point(379, 147);
            this.txtNvNome.MaxLength = 100;
            this.txtNvNome.Name = "txtNvNome";
            this.txtNvNome.Size = new System.Drawing.Size(130, 20);
            this.txtNvNome.TabIndex = 25;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Sistema_Apolices.Properties.Resources.Editar;
            this.btnAlterar.Location = new System.Drawing.Point(66, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 40);
            this.btnAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovoModelo
            // 
            this.btnNovoModelo.Image = global::Sistema_Apolices.Properties.Resources.Adicionar;
            this.btnNovoModelo.Location = new System.Drawing.Point(12, 12);
            this.btnNovoModelo.Name = "btnNovoModelo";
            this.btnNovoModelo.Size = new System.Drawing.Size(48, 40);
            this.btnNovoModelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovoModelo.TabIndex = 23;
            this.btnNovoModelo.TabStop = false;
            this.btnNovoModelo.Click += new System.EventHandler(this.btnNovoModelo_Click);
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvModelos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvModelos.Location = new System.Drawing.Point(12, 58);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.ReadOnly = true;
            this.dgvModelos.RowHeadersVisible = false;
            this.dgvModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelos.Size = new System.Drawing.Size(318, 184);
            this.dgvModelos.TabIndex = 22;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(379, 107);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(130, 21);
            this.cmbMarca.TabIndex = 30;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(376, 91);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 31;
            this.lblMarca.Text = "Marca:";
            // 
            // frmListaDeModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 254);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblNvNome);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNvNome);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovoModelo);
            this.Controls.Add(this.dgvModelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaDeModelos";
            this.Text = "frmListaDeModelos";
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNvNome;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNvNome;
        private System.Windows.Forms.PictureBox btnAlterar;
        private System.Windows.Forms.PictureBox btnNovoModelo;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
    }
}