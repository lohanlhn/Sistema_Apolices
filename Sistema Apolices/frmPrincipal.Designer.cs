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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelNovoForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnVeículos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNovoForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNovoForm
            // 
            this.panelNovoForm.Controls.Add(this.pictureBox2);
            this.panelNovoForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNovoForm.Location = new System.Drawing.Point(168, 0);
            this.panelNovoForm.Name = "panelNovoForm";
            this.panelNovoForm.Size = new System.Drawing.Size(714, 293);
            this.panelNovoForm.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Sistema_Apolices.Properties.Resources.Carro1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(714, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenuLateral.Controls.Add(this.btnModelos);
            this.panelMenuLateral.Controls.Add(this.btnMarcas);
            this.panelMenuLateral.Controls.Add(this.btnVeículos);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(168, 293);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // btnModelos
            // 
            this.btnModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModelos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModelos.FlatAppearance.BorderSize = 0;
            this.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnModelos.Location = new System.Drawing.Point(0, 169);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(168, 45);
            this.btnModelos.TabIndex = 3;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.UseVisualStyleBackColor = true;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnMarcas.Location = new System.Drawing.Point(0, 124);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(168, 45);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnVeículos
            // 
            this.btnVeículos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVeículos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeículos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVeículos.FlatAppearance.BorderSize = 0;
            this.btnVeículos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeículos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeículos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVeículos.Location = new System.Drawing.Point(0, 79);
            this.btnVeículos.Name = "btnVeículos";
            this.btnVeículos.Size = new System.Drawing.Size(168, 45);
            this.btnVeículos.TabIndex = 0;
            this.btnVeículos.Text = "Veículos";
            this.btnVeículos.UseVisualStyleBackColor = true;
            this.btnVeículos.Click += new System.EventHandler(this.btnVeículos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(168, 79);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Sistema_Apolices.Properties.Resources.Carro1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 293);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelNovoForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Controle de Veículos";
            this.panelNovoForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNovoForm;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnVeículos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnModelos;
    }
}