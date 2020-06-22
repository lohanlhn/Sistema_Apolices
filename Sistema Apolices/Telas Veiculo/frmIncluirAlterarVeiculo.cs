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
        private Carro _carro = new Carro();        
        public frmIncluirAlterarVeiculo(Carro carroSelecionado)
        {
            InitializeComponent();
            try
            {                                
                if (carroSelecionado.Id != 0)
                {
                    Text = "Alterar Veiculo";
                    _carro = new CarroController().Selecionar(carroSelecionado);

                    #region Popula Comboboxs

                    cmbMarca.ValueMember = "id";
                    cmbMarca.DisplayMember = "nome";
                    cmbMarca.DataSource = new MarcaController().Listar();
                    cmbMarca.SelectedValue = _carro.Modelo.Marca.Id;

                    Modelo modelo = new Modelo();
                    modelo.Marca = new Marca();
                    modelo.Marca.Id = _carro.Modelo.Marca.Id;

                    cmbModelo.ValueMember = "id";
                    cmbModelo.DisplayMember = "nome";
                    cmbModelo.DataSource = new ModeloController().Listar(modelo);
                    cmbModelo.SelectedValue = _carro.Modelo.Id;
                    #endregion

                    #region Carrega textBoxs
                    txtChassi.Text = _carro.Chassi;
                    txtPlaca.Text = _carro.Placa;
                    txtRenavam.Text = _carro.Renavam;
                    #endregion

                }
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

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Modelo modelo = new Modelo();
                modelo.Marca = new Marca();
                modelo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);

                cmbModelo.ValueMember = "id";
                cmbModelo.DisplayMember = "nome";
                cmbModelo.DataSource = new ModeloController().Listar(modelo);

                cmbModelo.Text = "";
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

        private void AlterarVeiculo()
        {
            Carro carroAlterado = new Carro();
            carroAlterado.Modelo = new Modelo();
            carroAlterado.Modelo.Marca = new Marca();

            carroAlterado.Id = _carro.Id;
            if (!String.IsNullOrEmpty(Convert.ToString(cmbMarca.SelectedValue)))
            {
                carroAlterado.Modelo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
            }
            if (!String.IsNullOrEmpty(Convert.ToString(cmbModelo.SelectedValue)))
            {
                carroAlterado.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);
            }
            carroAlterado.Chassi = txtChassi.Text;
            carroAlterado.Placa = txtPlaca.Text;
            carroAlterado.Renavam = txtRenavam.Text;

            new CarroController().Alterar(carroAlterado);
        }

        private void InserirVeiculo()
        {
            Carro carro = new Carro();
            carro.Modelo = new Modelo();
            carro.Modelo.Marca = new Marca();

            if (!String.IsNullOrEmpty(Convert.ToString(cmbMarca.SelectedValue)))
            {
                carro.Modelo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
            }
            if (!String.IsNullOrEmpty(Convert.ToString(cmbModelo.SelectedValue)))
            {
                carro.Modelo.Id = Convert.ToInt32(cmbModelo.SelectedValue);
            }

            carro.Chassi = txtChassi.Text;
            carro.Placa = txtPlaca.Text;
            carro.Renavam = txtRenavam.Text;

            new CarroController().Inserir(carro);
        }
    }
}
