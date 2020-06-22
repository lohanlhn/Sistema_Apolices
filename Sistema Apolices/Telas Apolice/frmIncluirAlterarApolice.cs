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

        Apolice _apolice = new Apolice();
        Carro _carro = new Carro();
        public frmIncluirAlterarApolice(Apolice apoliceSelecioanda, Carro carroSelecionado)
        {
            InitializeComponent();

            try
            {
                if(apoliceSelecioanda.Id != 0)
                {
                    _apolice = new ApoliceController().Selecionar(apoliceSelecioanda);

                    dtpInicioVigencia.Value = _apolice.DtInicio;
                    dtpFimVigencia.Value = _apolice.DtFim;
                    txtVlFranquia.Text = _apolice.ValorFranquia.ToString();
                    txtVlPremio.Text = _apolice.ValorPremio.ToString();
                    Text = "Alterar Apolice";
                }
                else
                {
                    dtpFimVigencia.Value = DateTime.Today;
                    dtpInicioVigencia.Value = DateTime.Today;

                    _carro = carroSelecionado;
                    Text = "Nova Apolice";
                }
                
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
                if(_apolice.Id != 0)
                {
                    _apolice.DtFim = dtpFimVigencia.Value;
                    _apolice.DtInicio = dtpInicioVigencia.Value;
                    if (!string.IsNullOrEmpty(txtVlFranquia.Text))
                    {
                        _apolice.ValorFranquia = Convert.ToDecimal(txtVlFranquia.Text);
                    }
                    if (!string.IsNullOrEmpty(txtVlPremio.Text))
                    {
                        _apolice.ValorPremio = Convert.ToDecimal(txtVlPremio.Text);
                    }
                    new ApoliceController().Alterar(_apolice);
                }
                else
                {
                    Apolice apolice = new Apolice();
                    apolice.Carro = new Carro();

                    apolice.Carro.Id = _carro.Id;
                    apolice.DtFim = dtpFimVigencia.Value;
                    apolice.DtInicio = dtpInicioVigencia.Value;
                    if (!string.IsNullOrEmpty(txtVlFranquia.Text))
                    {
                        apolice.ValorFranquia = Convert.ToDecimal(txtVlFranquia.Text);
                    }
                    if (!string.IsNullOrEmpty(txtVlPremio.Text))
                    {
                        apolice.ValorPremio = Convert.ToDecimal(txtVlPremio.Text);
                    }

                    new ApoliceController().Inserir(apolice);
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
    }
}
