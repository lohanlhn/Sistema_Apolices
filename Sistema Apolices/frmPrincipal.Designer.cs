﻿namespace Sistema_Apolices
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
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.btnNovoVeiculo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(38, 78);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.RowHeadersVisible = false;
            this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarros.Size = new System.Drawing.Size(674, 184);
            this.dgvCarros.TabIndex = 0;
            // 
            // btnNovoVeiculo
            // 
            this.btnNovoVeiculo.Location = new System.Drawing.Point(38, 46);
            this.btnNovoVeiculo.Name = "btnNovoVeiculo";
            this.btnNovoVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnNovoVeiculo.TabIndex = 1;
            this.btnNovoVeiculo.Text = "Incluir";
            this.btnNovoVeiculo.UseVisualStyleBackColor = true;
            this.btnNovoVeiculo.Click += new System.EventHandler(this.btnNovoVeiculo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(145, 46);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovoVeiculo);
            this.Controls.Add(this.dgvCarros);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button btnNovoVeiculo;
        private System.Windows.Forms.Button btnAlterar;
    }
}

