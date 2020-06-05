namespace Sistema_Apolices
{
    partial class frmPrincipal
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
            this.panelNovoForm = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnVeículos = new System.Windows.Forms.Button();
            this.panelMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNovoForm
            // 
            this.panelNovoForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNovoForm.Location = new System.Drawing.Point(168, 0);
            this.panelNovoForm.Name = "panelNovoForm";
            this.panelNovoForm.Size = new System.Drawing.Size(714, 293);
            this.panelNovoForm.TabIndex = 0;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.Controls.Add(this.btnVeículos);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(168, 293);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(168, 79);
            this.panelLogo.TabIndex = 0;
            // 
            // btnVeículos
            // 
            this.btnVeículos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeículos.FlatAppearance.BorderSize = 0;
            this.btnVeículos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeículos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeículos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVeículos.Location = new System.Drawing.Point(0, 79);
            this.btnVeículos.Name = "btnVeículos";
            this.btnVeículos.Size = new System.Drawing.Size(168, 45);
            this.btnVeículos.TabIndex = 1;
            this.btnVeículos.Text = "Veículos";
            this.btnVeículos.UseVisualStyleBackColor = true;
            this.btnVeículos.Click += new System.EventHandler(this.btnVeículos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 293);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelNovoForm);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.panelMenuLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNovoForm;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnVeículos;
        private System.Windows.Forms.Panel panelLogo;
    }
}