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
    public partial class frmAlterarApolice : Form
    {

        Apolice apolice = new Apolice();
        public frmAlterarApolice(Apolice apoliceSelecioanda)
        {
            InitializeComponent();

            try
            {
                apolice = new ApoliceController().Selecionar(apoliceSelecioanda);

                dtpInicioVigencia.Value = apolice.dtInicio;
                dtpFimVigencia.Value = apolice.dtFim;
                txtVlFranquia.Text = apolice.valorFranquia.ToString();
                txtVlPremio.Text = apolice.valorPremio.ToString();
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
                apolice.dtFim = dtpFimVigencia.Value;
                apolice.dtInicio = dtpInicioVigencia.Value;
                apolice.valorFranquia = Convert.ToDecimal(txtVlFranquia.Text);
                apolice.valorPremio = Convert.ToDecimal(txtVlPremio.Text);

                new ApoliceController().Alterar(apolice);

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
