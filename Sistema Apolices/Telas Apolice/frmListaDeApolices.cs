using Controllers;
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
    public partial class frmListaDeApolices : Form
    {
        Carro carro = new Carro();
        public frmListaDeApolices(Carro carroSelecionado)
        {
            InitializeComponent();
            try
            {
                carro = new CarroController().Selecionar(carroSelecionado);

                lblCodigo.Text = carro.id.ToString();
                lblModelo.Text = carro.modelo.nome;
                lblMarca.Text = carro.modelo.marca.nome;
                lblPlaca.Text = carro.placa;

                dgvApolices.ColumnCount = 5;

                dgvApolices.Columns[0].Name = "Código";
                dgvApolices.Columns[1].Name = "Início da vigência";
                dgvApolices.Columns[2].Name = "Fim da vigência";
                dgvApolices.Columns[3].Name = "Valor franquia";
                dgvApolices.Columns[4].Name = "Valor premio";


                AtualizarDgv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarDgv()
        {
            try
            {
                Apolice apolice = new Apolice();
                apolice.carro = new Carro();

                apolice.carro.id = carro.id;

                List<Apolice> apolices;
                apolices = new ApoliceController().Listar(apolice);

                //Limpa datagrid
                dgvApolices.Rows.Clear();

                //Popula datagrid
                foreach (Apolice item in apolices)
                {
                    dgvApolices.Rows.Add(item.id.ToString(), item.dtInicio.ToString("d"), item.dtFim.ToString("d"), item.valorFranquia, item.valorPremio);
                }

                ChecarDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovaApolice_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastrarAlterarApolice janela = new frmCadastrarAlterarApolice(new Apolice(), carro);

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
                Apolice apolice = new Apolice();

                apolice.id = Convert.ToInt32(dgvApolices.SelectedRows[0].Cells[0].Value);

                frmCadastrarAlterarApolice janela = new frmCadastrarAlterarApolice(apolice, new Carro());

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
        private void ChecarDataGrid()
        {
            if (dgvApolices.RowCount == 0)
            {
                btnAlterar.Visible = false;
                btnAlterar.Enabled = false;
            }
            else
            {
                btnAlterar.Visible = true;
                btnAlterar.Enabled = true;
            }
        }
    }
}
