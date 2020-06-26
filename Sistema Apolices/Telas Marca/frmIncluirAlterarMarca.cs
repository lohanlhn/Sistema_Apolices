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
    public partial class frmIncluirAlterarMarca : Form
    {        
        //Campo
        Marca _marca = new Marca();        

        #region Construtor

        public frmIncluirAlterarMarca(Marca marcaSelecionada)
        {
            InitializeComponent();

            //Alteração
            if (marcaSelecionada.Id != 0)
            {
                lblAviso.Visible = true;
                txtNvNome.Text = marcaSelecionada.Nome;
                
                //Campo _marca recebe o id da marca selecionada para realizar a alteraçao do registro
                _marca.Id = marcaSelecionada.Id;

                Text = "Alterar Marca";
            }
            //Inserção
            else
            {
                lblAviso.Visible = false;                

                Text = "Nova Marca";
            }
        }

        #endregion

        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_marca.Id != 0)
                {
                    AlterarMarca();
                }
                else
                {
                    InserirMarca();
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

        private void InserirMarca()
        {
            Marca marca = new Marca();
            marca.Nome = txtNvNome.Text.ToUpper();

            new MarcaController().Inserir(marca);
        }

        private void AlterarMarca()
        {
            Marca marca = new Marca();
            marca.Id = _marca.Id;
            marca.Nome = txtNvNome.Text.ToUpper();

            new MarcaController().Alterar(marca);
        }

        #endregion

    }
}
