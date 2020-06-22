﻿using Controllers;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Sistema_Apolices
{    
    public partial class frmIncluirAlterarModelo : Form
    {
        bool _alterar;
        Modelo _modelo = new Modelo();
        public frmIncluirAlterarModelo(Modelo modeloSelecionado)
        {
            InitializeComponent();
            try
            {
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "nome";
                cmbMarca.DataSource = new MarcaController().Listar();


                if (!String.IsNullOrEmpty(modeloSelecionado.nome))
                {
                    lblAviso.Visible = true;

                    cmbMarca.SelectedValue = modeloSelecionado.marca.id;                    

                    txtNvNome.Text = modeloSelecionado.nome;


                    _alterar = true;
                    _modelo.id = modeloSelecionado.id;

                    Text = "Alterar Marca";
                }
                else
                {
                    lblAviso.Visible = false;
                    cmbMarca.SelectedIndex = -1;

                    _alterar = false;

                    Text = "Nova Marca";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_alterar)
                {
                    Modelo modelo = new Modelo();
                    modelo.marca = new Marca();

                    modelo.id = _modelo.id;
                    modelo.nome = txtNvNome.Text;
                    modelo.marca.id = Convert.ToInt32(cmbMarca.SelectedValue);


                    new ModeloController().Alterar(modelo);
                }
                else
                {
                    Modelo modelo = new Modelo();
                    modelo.marca = new Marca();

                    modelo.nome = txtNvNome.Text;
                    modelo.marca.id = Convert.ToInt32(cmbMarca.SelectedValue);


                    new ModeloController().Inserir(modelo);
                }
                MessageBox.Show("Operação realizada com sucesso");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ConsistenciaException ex)
            {

                MessageBox.Show(ex.Mensagem);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}