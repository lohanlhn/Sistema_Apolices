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
using Utils;

namespace Sistema_Apolices
{
    public partial class frmListaDeVeiculos : Form
    {

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

            //Atualiza datagrid
            AtualizarDgv();

            //Caso não possua registros o alterar fica desabilitado
            if (dgvCarros.RowCount == 0)
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
                frmCadastrarAlterarVeiculo janela = new frmCadastrarAlterarVeiculo(new Carro());
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
                ChecaDataGrid();

                //Preenche o objeto carro com id 
                Carro carro = new Carro();
                carro.id = int.Parse(dgvCarros.SelectedRows[0].Cells[0].Value.ToString());

                frmCadastrarAlterarVeiculo janela = new frmCadastrarAlterarVeiculo(carro);
                if (janela.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDgv();
                }

            }
            catch (DataGridException ex)
            {

                MessageBox.Show(ex.Mensagem);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnApolices_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();

            carro.id = carro.id = Convert.ToInt32(dgvCarros.SelectedRows[0].Cells[0].Value);

            frmListaDeApolices novoForm = new frmListaDeApolices(carro);

            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(novoForm);
            panel1.Tag = novoForm;
            novoForm.BringToFront();
            novoForm.Show();
        }

        private void ChecaDataGrid()
        {
            if (dgvCarros.RowCount == 0)
            {
                throw new DataGridException("Não possuém registros para serem alterados.");
            }
        }
    }
}
