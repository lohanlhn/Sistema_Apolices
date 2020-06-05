using Controllers;
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
        List<Carro> carro;
        public frmListaDeVeiculos()
        {
            InitializeComponent();

            dgvCarros.ColumnCount = 6;

            dgvCarros.Columns[0].Name = "Código";
            dgvCarros.Columns[1].Name = "Marca";
            dgvCarros.Columns[2].Name = "Modelo";
            dgvCarros.Columns[3].Name = "Chassi";
            dgvCarros.Columns[4].Name = "Placa";
            dgvCarros.Columns[5].Name = "Renavam";
            dgvCarros.Columns[3].Width = 130;

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
                carro = new CarroController().Listar();
                dgvCarros.Rows.Clear();
                foreach (Carro item in carro)
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
                Carro carro = new Carro();
                carro.id = int.Parse(dgvCarros.SelectedRows[0].Cells[0].Value.ToString());
                carro.chassi = dgvCarros.SelectedRows[0].Cells[3].Value.ToString();
                carro.placa = dgvCarros.SelectedRows[0].Cells[4].Value.ToString();
                carro.renavam = dgvCarros.SelectedRows[0].Cells[5].Value.ToString();

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
