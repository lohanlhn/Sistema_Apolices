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
        bool _alterar;
        Marca _marca = new Marca();
        public frmIncluirAlterarMarca(Marca marcaSelecionada)
        {
            InitializeComponent();

            if (!String.IsNullOrEmpty(marcaSelecionada.Nome))
            {
                lblAviso.Visible = true;
                txtNvNome.Text = marcaSelecionada.Nome;

                _alterar = true;
                _marca.Id = marcaSelecionada.Id;

                Text = "Alterar Marca";
            }
            else
            {
                lblAviso.Visible = false;

                _alterar = false;

                Text = "Nova Marca";
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_alterar)
                {
                    Marca marca = new Marca();
                    marca.Id = _marca.Id;
                    marca.Nome = txtNvNome.Text;

                    new MarcaController().Alterar(marca);
                }
                else
                {
                    Marca marca = new Marca();
                    marca.Nome = txtNvNome.Text;

                    new MarcaController().Inserir(marca);
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
