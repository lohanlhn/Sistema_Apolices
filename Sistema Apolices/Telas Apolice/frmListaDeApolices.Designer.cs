namespace Sistema_Apolices
{
    partial class frmListaDeApolices
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
            this.dgvApolices = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.PictureBox();
            this.btnNovaMarca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApolices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApolices
            // 
            this.dgvApolices.AllowUserToAddRows = false;
            this.dgvApolices.AllowUserToDeleteRows = false;
            this.dgvApolices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvApolices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvApolices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApolices.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvApolices.Location = new System.Drawing.Point(12, 93);
            this.dgvApolices.Name = "dgvApolices";
            this.dgvApolices.ReadOnly = true;
            this.dgvApolices.RowHeadersVisible = false;
            this.dgvApolices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApolices.Size = new System.Drawing.Size(674, 149);
            this.dgvApolices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Placa:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(61, 12);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(3);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(58, 31);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(3);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(63, 51);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(3);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(55, 70);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(3);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 16;
            this.lblPlaca.Text = "Placa";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(611, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Sistema_Apolices.Properties.Resources.Editar;
            this.btnAlterar.Location = new System.Drawing.Point(646, 47);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 40);
            this.btnAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Image = global::Sistema_Apolices.Properties.Resources.Adicionar;
            this.btnNovaMarca.Location = new System.Drawing.Point(592, 47);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(48, 40);
            this.btnNovaMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovaMarca.TabIndex = 7;
            this.btnNovaMarca.TabStop = false;
            this.btnNovaMarca.Click += new System.EventHandler(this.btnNovaMarca_Click);
            // 
            // frmListaDeApolices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 254);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovaMarca);
            this.Controls.Add(this.dgvApolices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaDeApolices";
            this.Text = "frmListaDeApolices";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApolices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovaMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApolices;
        private System.Windows.Forms.PictureBox btnAlterar;
        private System.Windows.Forms.PictureBox btnNovaMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnVoltar;
    }
}