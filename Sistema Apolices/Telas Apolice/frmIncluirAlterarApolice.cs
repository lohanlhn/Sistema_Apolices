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

        #region Permitir apenas numeros e virgula nas textBoxs

        //txtVlFranquia
        private void txtVlFranquia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtVlFranquia.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

            //Limita para ter 2 numeros após a virgula
            else if (txtVlFranquia.Text.Contains(",") && txtVlFranquia.Text.Split(',')[1].Length > 1 && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        //txtVlPremio
        private void txtVlPremio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtVlPremio.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

            //Limita para ter 2 numeros após a virgula
            else if (txtVlPremio.Text.Contains(",") && txtVlPremio.Text.Split(',')[1].Length > 1 && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        #endregion


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

            //Caso text box esteja vazia recebe valor recebe 0
            if (string.IsNullOrWhiteSpace(txtVlFranquia.Text))
            {
                apolice.ValorFranquia = 0;
            }
            else
            {
                apolice.ValorFranquia = Convert.ToDecimal(txtVlFranquia.Text);
            }
            //Caso text box esteja vazia recebe valor recebe 0
            if (string.IsNullOrWhiteSpace(txtVlPremio.Text))
            {
                apolice.ValorPremio = 0;
            }
            else
            {
                apolice.ValorPremio = Convert.ToDecimal(txtVlPremio.Text);
            }

            #endregion

            new ApoliceController().Inserir(apolice);
        }

        private void AlterarApolice()
        {
            Apolice apolice = new Apolice();

            #region Prepara a apolice a ser inserida

            apolice.DtFim = dtpFimVigencia.Value;
            apolice.DtInicio = dtpInicioVigencia.Value;

            //Caso text box esteja vazia recebe valor recebe 0
            if (string.IsNullOrWhiteSpace(txtVlFranquia.Text))
            {
                apolice.ValorFranquia = 0;
            }
            else
            {
                _apolice.ValorFranquia = Convert.ToDecimal(txtVlFranquia.Text);
            }
            //Caso text box esteja vazia recebe valor recebe 0
            if (string.IsNullOrWhiteSpace(txtVlPremio.Text))
            {
                apolice.ValorPremio = 0;
            }
            else
            {
                apolice.ValorPremio = Convert.ToDecimal(txtVlPremio.Text);
            }

            #endregion

            new ApoliceController().Alterar(apolice);
        }

        #endregion
        
    }
}
