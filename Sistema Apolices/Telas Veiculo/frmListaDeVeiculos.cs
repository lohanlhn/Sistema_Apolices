﻿using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Sistema_Apolices
{
    public partial class frmListaDeVeiculos : Form
    {
        #region Construtor

        public frmListaDeVeiculos()
        {
            InitializeComponent();

            //Prepara o DataGrid para ser populado
            dgvCarros.ColumnCount = 6;
            dgvCarros.Columns[0].Name = "Código";
            dgvCarros.Columns[1].Name = "Marca";
            dgvCarros.Columns[2].Name = "Modelo";
            dgvCarros.Columns[3].Name = "Chassi";
            dgvCarros.Columns[4].Name = "Placa";
            dgvCarros.Columns[5].Name = "Renavam";

            //Atualiza datagrid
            AtualizarDgv();

        }

        #endregion

        #region Eventos

        private void btnNovoVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirAlterarVeiculo janela = new frmIncluirAlterarVeiculo(new Carro());
                if (janela.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDgv();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Carro carro = new Carro();
                carro.Id = int.Parse(dgvCarros.SelectedRows[0].Cells[0].Value.ToString());
                
                frmIncluirAlterarVeiculo janela = new frmIncluirAlterarVeiculo(carro);
                if (janela.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDgv();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnApolices_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();

            carro.Id = Convert.ToInt32(dgvCarros.SelectedRows[0].Cells[0].Value);

            frmListaDeApolices novoForm = new frmListaDeApolices(carro);

            //Esconde o form atual e exibe o form de apolices
            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(novoForm);
            panel1.Tag = novoForm;            
            novoForm.BringToFront();
            novoForm.Show();
        }

        #endregion

        #region Métodos

        private void AtualizarDgv()
        {
            try
            {
                List<Carro> carros = new CarroController().Listar();

                //Limpa datagrid
                dgvCarros.Rows.Clear();

                //Popula datagrid
                foreach (Carro item in carros)
                {
                    dgvCarros.Rows.Add(item.Id.ToString(), item.Modelo.Marca.Nome, item.Modelo.Nome, item.Chassi, item.Placa, item.Renavam);
                }

                ChecarDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void ChecarDataGrid()
        {
            if (dgvCarros.RowCount == 0)
            {
                btnAlterar.Visible = false;
            }
            else
            {
                btnAlterar.Visible = true;
            }
        }

        #endregion

    }
}
