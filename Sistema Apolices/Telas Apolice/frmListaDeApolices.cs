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
        //Campo
        Carro _carro = new Carro();
        #region Construtor

        public frmListaDeApolices(Carro carroSelecionado)
        {
            InitializeComponent();
            try
            {
                _carro = new CarroController().Selecionar(carroSelecionado);

                lblCodigo.Text = _carro.Id.ToString();
                lblModelo.Text = _carro.Modelo.Nome;
                lblMarca.Text = _carro.Modelo.Marca.Nome;
                lblPlaca.Text = _carro.Placa;

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

        #endregion

        #region Eventos

        private void btnNovaApolice_Click(object sender, EventArgs e)
        {
            try
            {
                Apolice apolice = new Apolice();
                apolice.Carro = new Carro();
                
                //carro que vai ter a apolice inserida
                apolice.Carro.Id = _carro.Id;

                frmIncluirAlterarApolice janela = new frmIncluirAlterarApolice(apolice);
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

                apolice.Id = Convert.ToInt32(dgvApolices.SelectedRows[0].Cells[0].Value);

                frmIncluirAlterarApolice janela = new frmIncluirAlterarApolice(apolice);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Métodos

        private void AtualizarDgv()
        {
            try
            {
                List<Apolice> apolices = new ApoliceController().ListarPorCarroId(_carro.Id);

                //Limpa datagrid
                dgvApolices.Rows.Clear();

                //Popula datagrid
                foreach (Apolice item in apolices)
                {
                    dgvApolices.Rows.Add(item.Id.ToString(), item.DtInicio.ToString("d"), item.DtFim.ToString("d"), item.ValorFranquia, item.ValorPremio);
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
            if (dgvApolices.RowCount == 0)
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
