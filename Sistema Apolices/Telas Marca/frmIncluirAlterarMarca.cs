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

            if (!String.IsNullOrEmpty(marcaSelecionada.nome))
            {
                lblAviso.Visible = true;
                txtNvNome.Text = marcaSelecionada.nome;

                _alterar = true;
                _marca.id = marcaSelecionada.id;

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
                    marca.id = _marca.id;
                    marca.nome = txtNvNome.Text;

                    new MarcaController().Alterar(marca);
                }
                else
                {
                    Marca marca = new Marca();
                    marca.nome = txtNvNome.Text;

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
