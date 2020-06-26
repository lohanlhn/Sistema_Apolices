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
    public partial class frmIncluirAlterarModelo : Form
    {        
        //Campo
        Modelo _modelo = new Modelo();

        #region Contrutor

        public frmIncluirAlterarModelo(Modelo modeloSelecionado)
        {
            InitializeComponent();
            try
            {
                //Prepara o comboBox
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "nome";
                cmbMarca.DataSource = new MarcaController().Listar();

                //Alteração
                if (modeloSelecionado.Id != 0)
                {
                    //Deixa a marca referente ao modelo selecionada
                    cmbMarca.SelectedValue = modeloSelecionado.Marca.Id;

                    txtNvNome.Text = modeloSelecionado.Nome;

                    //Campo _modelo recebe o id do modelo selecionada para realizar a alteraçao do registro
                    _modelo.Id = modeloSelecionado.Id;

                    Text = "Alterar Marca";
                }
                //Inserção
                else
                {
                    cmbMarca.SelectedIndex = -1;

                    Text = "Nova Marca";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_modelo.Id != 0)
                {
                    AlterarModelo();
                }
                else
                {
                    InserirModelo();
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

        private void InserirModelo()
        {
            Modelo modelo = new Modelo();
            modelo.Marca = new Marca();

            modelo.Nome = txtNvNome.Text.ToUpper();
            modelo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);

            new ModeloController().Inserir(modelo);
        }

        private void AlterarModelo()
        {
            Modelo modelo = new Modelo();
            modelo.Marca = new Marca();

            modelo.Id = _modelo.Id;
            modelo.Nome = txtNvNome.Text.ToUpper();
            modelo.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);

            new ModeloController().Alterar(modelo);
        }

        #endregion

    }
}
