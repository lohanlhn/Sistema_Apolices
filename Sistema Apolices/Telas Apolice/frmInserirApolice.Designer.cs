namespace Sistema_Apolices
{
    partial class frmInserirApolice
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
            this.txtVlPremio = new System.Windows.Forms.TextBox();
            this.lblVlPremio = new System.Windows.Forms.Label();
            this.lblVlFranquia = new System.Windows.Forms.Label();
            this.lblInicioVigencia = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.dtpFimVigencia = new System.Windows.Forms.DateTimePicker();
            this.lblFimVigencia = new System.Windows.Forms.Label();
            this.txtVlFranquia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVlPremio
            // 
            this.txtVlPremio.Location = new System.Drawing.Point(129, 66);
            this.txtVlPremio.MaxLength = 20;
            this.txtVlPremio.Name = "txtVlPremio";
            this.txtVlPremio.Size = new System.Drawing.Size(89, 20);
            this.txtVlPremio.TabIndex = 41;
            // 
            // lblVlPremio
            // 
            this.lblVlPremio.AutoSize = true;
            this.lblVlPremio.Location = new System.Drawing.Point(126, 50);
            this.lblVlPremio.Name = "lblVlPremio";
            this.lblVlPremio.Size = new System.Drawing.Size(83, 13);
            this.lblVlPremio.TabIndex = 40;
            this.lblVlPremio.Text = "Valor do prêmio:";
            // 
            // lblVlFranquia
            // 
            this.lblVlFranquia.AutoSize = true;
            this.lblVlFranquia.Location = new System.Drawing.Point(12, 50);
            this.lblVlFranquia.Name = "lblVlFranquia";
            this.lblVlFranquia.Size = new System.Drawing.Size(90, 13);
            this.lblVlFranquia.TabIndex = 35;
            this.lblVlFranquia.Text = "Valor da franquia:";
            // 
            // lblInicioVigencia
            // 
            this.lblInicioVigencia.AutoSize = true;
            this.lblInicioVigencia.Location = new System.Drawing.Point(12, 9);
            this.lblInicioVigencia.Name = "lblInicioVigencia";
            this.lblInicioVigencia.Size = new System.Drawing.Size(95, 13);
            this.lblInicioVigencia.TabIndex = 33;
            this.lblInicioVigencia.Text = "Início da vigência:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(62, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(143, 103);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpInicioVigencia
            // 
            this.dtpInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVigencia.Location = new System.Drawing.Point(15, 26);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(89, 20);
            this.dtpInicioVigencia.TabIndex = 42;
            this.dtpInicioVigencia.Value = new System.DateTime(2020, 6, 9, 0, 0, 0, 0);
            // 
            // dtpFimVigencia
            // 
            this.dtpFimVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimVigencia.Location = new System.Drawing.Point(129, 26);
            this.dtpFimVigencia.Name = "dtpFimVigencia";
            this.dtpFimVigencia.Size = new System.Drawing.Size(89, 20);
            this.dtpFimVigencia.TabIndex = 44;
            // 
            // lblFimVigencia
            // 
            this.lblFimVigencia.AutoSize = true;
            this.lblFimVigencia.Location = new System.Drawing.Point(126, 9);
            this.lblFimVigencia.Name = "lblFimVigencia";
            this.lblFimVigencia.Size = new System.Drawing.Size(84, 13);
            this.lblFimVigencia.TabIndex = 43;
            this.lblFimVigencia.Text = "Fim da vigência:";
            // 
            // txtVlFranquia
            // 
            this.txtVlFranquia.Location = new System.Drawing.Point(15, 66);
            this.txtVlFranquia.MaxLength = 20;
            this.txtVlFranquia.Name = "txtVlFranquia";
            this.txtVlFranquia.Size = new System.Drawing.Size(89, 20);
            this.txtVlFranquia.TabIndex = 45;
            // 
            // frmInserirApolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 138);
            this.ControlBox = false;
            this.Controls.Add(this.txtVlFranquia);
            this.Controls.Add(this.dtpFimVigencia);
            this.Controls.Add(this.lblFimVigencia);
            this.Controls.Add(this.dtpInicioVigencia);
            this.Controls.Add(this.txtVlPremio);
            this.Controls.Add(this.lblVlPremio);
            this.Controls.Add(this.lblVlFranquia);
            this.Controls.Add(this.lblInicioVigencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInserirApolice";
            this.Text = "Inserir Apolice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVlPremio;
        private System.Windows.Forms.Label lblVlPremio;
        private System.Windows.Forms.Label lblVlFranquia;
        private System.Windows.Forms.Label lblInicioVigencia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.DateTimePicker dtpFimVigencia;
        private System.Windows.Forms.Label lblFimVigencia;
        private System.Windows.Forms.TextBox txtVlFranquia;
    }
}