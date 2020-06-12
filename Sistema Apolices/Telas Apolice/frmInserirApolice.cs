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
    public partial class frmInserirApolice : Form
    {
        Carro carro = new Carro();
        public frmInserirApolice(Carro carroSelecionado)
        {
            InitializeComponent();

            dtpFimVigencia.Value = DateTime.Today;
            dtpInicioVigencia.Value = DateTime.Today;

            carro = carroSelecionado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Apolice apolice = new Apolice();
                apolice.carro = new Carro();

                apolice.carro.id = carro.id;
                apolice.dtFim = dtpFimVigencia.Value;
                apolice.dtInicio = dtpInicioVigencia.Value;
                if (!string.IsNullOrEmpty(txtVlFranquia.Text))
                {
                    apolice.valorFranquia = Convert.ToDecimal(txtVlFranquia.Text);
                }
                if (!string.IsNullOrEmpty(txtVlPremio.Text))
                {
                    apolice.valorPremio = Convert.ToDecimal(txtVlPremio.Text);
                }                    

                new ApoliceController().Inserir(apolice);

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
