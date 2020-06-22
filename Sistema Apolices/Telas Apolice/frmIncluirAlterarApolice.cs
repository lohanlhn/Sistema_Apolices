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

        Apolice apolice = new Apolice();
        Carro carro = new Carro();
        public frmIncluirAlterarApolice(Apolice apoliceSelecioanda, Carro carroSelecionado)
        {
            InitializeComponent();

            try
            {
                if(apoliceSelecioanda.Id != 0)
                {
                    apolice = new ApoliceController().Selecionar(apoliceSelecioanda);

                    dtpInicioVigencia.Value = apolice.DtInicio;
                    dtpFimVigencia.Value = apolice.DtFim;
                    txtVlFranquia.Text = apolice.ValorFranquia.ToString();
                    txtVlPremio.Text = apolice.ValorPremio.ToString();
                    Text = "Alterar Apolice";
                }
                else
                {
                    dtpFimVigencia.Value = DateTime.Today;
                    dtpInicioVigencia.Value = DateTime.Today;

                    carro = carroSelecionado;
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
                if(apolice.Id != 0)
                {
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
                    new ApoliceController().Alterar(apolice);
                }
                else
                {
                    Apolice apolice = new Apolice();
                    apolice.Carro = new Carro();

                    apolice.Carro.Id = carro.Id;
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
