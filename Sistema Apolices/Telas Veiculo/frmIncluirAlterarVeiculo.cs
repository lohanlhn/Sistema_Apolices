using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Entities;
using Utils;

namespace Sistema_Apolices
{
    public partial class frmIncluirAlterarVeiculo : Form
    {
        //Campo
        private Carro _carro = new Carro();

        #region Construtor
        public frmIncluirAlterarVeiculo(Carro carroSelecionado)
        {
            InitializeComponent();
            try
            {
                //Alteração
                if (carroSelecionado.Id != 0)
                {
                    Text = "Alterar Veiculo";
                    //Campo _carro recebe os dados do carroSelecioando para a alteraçao do registro
                    _carro = new CarroController().Selecionar(carroSelecionado);

                    #region Popula Comboboxs

                    cmbMarca.ValueMember = "id";
                    cmbMarca.DisplayMember = "nome";
                    cmbMarca.DataSource = new MarcaController().Listar();
                    cmbMarca.SelectedValue = _carro.Modelo.Marca.Id;

                    cmbModelo.ValueMember = "id";
                    cmbModelo.DisplayMember = "nome";
                    cmbModelo.DataSource = new ModeloController().ListarPorMarcaId(_carro.Modelo.Marca.Id);
                    cmbModelo.SelectedValue = _carro.Modelo.Id;
                    #endregion

                    #region Carrega textBoxs
                    mtxChassi.Text = _carro.Chassi;
                    mtxPlaca.Text = _carro.Placa;
                    mtxRenavam.Text = _carro.Renavam;
                    #endregion

                }
                //Inserção
                else
                {
                    Text = "Novo Veiculo";

                    cmbMarca.ValueMember = "id";
                    cmbMarca.DisplayMember = "nome";
                    cmbMarca.DataSource = new MarcaController().Listar();
                    cmbMarca.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        #endregion

        #region Eventos

        //Carrega a combobox de modelos a cada marca selecioanda
        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();
                marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);

                cmbModelo.ValueMember = "id";
                cmbModelo.DisplayMember = "nome";
                cmbModelo.DataSource = new ModeloController().ListarPorMarcaId(marca.Id);
                
                cmbModelo.SelectedIndex = -1;
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
                if (_carro.Id != 0)
                {
                    AlterarVeiculo();
                }
                else
                {
                    InserirVeiculo();
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
        #endregion

        #region Métodos
        private void AlterarVeiculo()
        {
            Carro carroAlterado = new Carro();
            carroAlterado.Modelo = new Modelo();
            carroAlterado.Modelo.Marca = new Marca();

            //Pega o do Id do carro que vai ter as informções alterardas 
            carroAlterado.Id = _carro.Id;

            carroAlterado.Modelo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
            carroAlterado.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);

            carroAlterado.Chassi = mtxChassi.Text.ToUpper();
            carroAlterado.Placa = mtxPlaca.Text.ToUpper();
            carroAlterado.Renavam = mtxRenavam.Text.ToUpper();

            new CarroController().Alterar(carroAlterado);
        }

        private void InserirVeiculo()
        {
            Carro carro = new Carro();
            carro.Modelo = new Modelo();
            carro.Modelo.Marca = new Marca();

            carro.Modelo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
            carro.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);

            carro.Chassi = mtxChassi.Text.ToUpper();
            carro.Placa = mtxPlaca.Text.ToUpper();
            carro.Renavam = mtxRenavam.Text.ToUpper();

            new CarroController().Inserir(carro);
        }
        #endregion

    }
}
