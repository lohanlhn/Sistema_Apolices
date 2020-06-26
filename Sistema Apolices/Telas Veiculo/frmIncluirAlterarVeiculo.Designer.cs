namespace Sistema_Apolices
{
    partial class frmIncluirAlterarVeiculo
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.lblChassi = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mtxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.mtxChassi = new System.Windows.Forms.MaskedTextBox();
            this.mtxRenavam = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(249, 102);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Location = new System.Drawing.Point(165, 50);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblRenavam.TabIndex = 20;
            this.lblRenavam.Text = "Renavam";
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(16, 89);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(38, 13);
            this.lblChassi.TabIndex = 18;
            this.lblChassi.Text = "Chassi";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(165, 11);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 17;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 49);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DisplayMember = "nome";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(15, 65);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(121, 21);
            this.cmbModelo.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(15, 25);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 1;
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.cmbMarca_SelectionChangeCommitted);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mtxPlaca
            // 
            this.mtxPlaca.Location = new System.Drawing.Point(168, 25);
            this.mtxPlaca.Mask = "LLL0A00";
            this.mtxPlaca.Name = "mtxPlaca";
            this.mtxPlaca.Size = new System.Drawing.Size(156, 20);
            this.mtxPlaca.TabIndex = 4;
            // 
            // mtxChassi
            // 
            this.mtxChassi.Location = new System.Drawing.Point(15, 102);
            this.mtxChassi.Mask = "AAAAAAAAAAAAAAAAA";
            this.mtxChassi.Name = "mtxChassi";
            this.mtxChassi.Size = new System.Drawing.Size(121, 20);
            this.mtxChassi.TabIndex = 3;
            // 
            // mtxRenavam
            // 
            this.mtxRenavam.Location = new System.Drawing.Point(168, 65);
            this.mtxRenavam.Mask = "AAAAAAAAAAA";
            this.mtxRenavam.Name = "mtxRenavam";
            this.mtxRenavam.Size = new System.Drawing.Size(156, 20);
            this.mtxRenavam.TabIndex = 5;
            // 
            // frmIncluirAlterarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 138);
            this.ControlBox = false;
            this.Controls.Add(this.mtxRenavam);
            this.Controls.Add(this.mtxChassi);
            this.Controls.Add(this.mtxPlaca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblRenavam);
            this.Controls.Add(this.lblChassi);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmIncluirAlterarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmIncluirAlterarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtxPlaca;
        private System.Windows.Forms.MaskedTextBox mtxChassi;
        private System.Windows.Forms.MaskedTextBox mtxRenavam;
    }
}