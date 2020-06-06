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
        
        public frmListaDeVeiculos()
        {
            InitializeComponent();

            //Organiza datagrid
            dgvCarros.ColumnCount = 6;

            dgvCarros.Columns[0].Name = "Código";
            dgvCarros.Columns[1].Name = "Marca";
            dgvCarros.Columns[2].Name = "Modelo";
            dgvCarros.Columns[3].Name = "Chassi";
            dgvCarros.Columns[4].Name = "Placa";
            dgvCarros.Columns[5].Name = "Renavam";
            dgvCarros.Columns[3].Width = 130;

            //Atualiza datagrid
            AtualizarDgv(); 
            
            //Caso não possua registros o alterar fica desabilitado
            if(dgvCarros.RowCount == 0)
            {
                btnAlterar.Enabled = false;
            }

        }
        
        private void AtualizarDgv()
        {
            try
            {
                List<Carro> carros;
                carros = new CarroController().Listar();
                
                //Limpa datagrid
                dgvCarros.Rows.Clear();

                //Popula datagrid
                foreach (Carro item in carros)
                {
                    dgvCarros.Rows.Add(item.id.ToString(), item.modelo.marca.nome, item.modelo.nome, item.chassi, item.placa, item.renavam);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                frmNovoVeiculo janela = new frmNovoVeiculo();

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
                //Preenche o objeto carro
                Carro carro = new Carro();
                carro.id = int.Parse(dgvCarros.SelectedRows[0].Cells[0].Value.ToString());
                carro.chassi = dgvCarros.SelectedRows[0].Cells[3].Value.ToString();
                carro.placa = dgvCarros.SelectedRows[0].Cells[4].Value.ToString();
                carro.renavam = dgvCarros.SelectedRows[0].Cells[5].Value.ToString();

                //Envia o objeto para próxima janela
                frmAlterarVeiculo janela = new frmAlterarVeiculo(carro);
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
    }
}
