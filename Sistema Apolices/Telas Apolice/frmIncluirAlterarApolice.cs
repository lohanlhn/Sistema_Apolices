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
    public partial class frmIncluirAlterarApolice : Form
    {
        //Campo
        Apolice _apolice = new Apolice();

        #region Construtor

        public frmIncluirAlterarApolice(Apolice apoliceSelecioanda)
        {
            InitializeComponent();

            try
            {
                //Alteração
                if (apoliceSelecioanda.Id != 0)
                {
                    _apolice = new ApoliceController().Selecionar(apoliceSelecioanda);

                    dtpInicioVigencia.Value = _apolice.DtInicio;
                    dtpFimVigencia.Value = _apolice.DtFim;
                    txtVlFranquia.Text = _apolice.ValorFranquia.ToString();
                    txtVlPremio.Text = _apolice.ValorPremio.ToString();

                    Text = "Alterar Apolice";
                }
                //Inserção
                else
                {
                    dtpFimVigencia.Value = DateTime.Today;
                    dtpInicioVigencia.Value = DateTime.Today;

                    _apolice.Carro = new Carro();
                    //Pega o id do carro que vai ter uma apolice inserida
                    _apolice.Carro.Id = apoliceSelecioanda.Carro.Id;

                    Text = "Nova Apolice";
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
                if (_apolice.Id != 0)
                {
                    AlterarApolice();
                }
                else
                {
                    InserirApolice();
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

        private void InserirApolice()
        {           
            Apolice apolice = new Apolice();
            apolice.Carro = new Carro();

            //Carro que vai ter a apolice inserida
            apolice.Carro.Id = _apolice.Carro.Id;

            #region Prepara a apolice a ser inserida

            apolice.DtFim = dtpFimVigencia.Value;
            apolice.DtInicio = dtpInicioVigencia.Value;

            decimal.TryParse(txtVlFranquia.Text, out decimal valorFranquia);
            decimal.TryParse(txtVlPremio.Text, out decimal valorPremio);
            apolice.ValorFranquia = valorFranquia;
            apolice.ValorPremio = valorPremio;            

            #endregion

            new ApoliceController().Inserir(apolice);
        }

        private void AlterarApolice()
        {
            Apolice apolice = new Apolice();

            apolice.Id = _apolice.Id;

            #region Prepara a apolice a ser inserida

            apolice.DtFim = dtpFimVigencia.Value;
            apolice.DtInicio = dtpInicioVigencia.Value;

            decimal.TryParse(txtVlFranquia.Text, out decimal valorFranquia);
            decimal.TryParse(txtVlPremio.Text, out decimal valorPremio);
            apolice.ValorFranquia = valorFranquia;
            apolice.ValorPremio = valorPremio;

            #endregion

            new ApoliceController().Alterar(apolice);
        }

        #endregion
        
    }
}
