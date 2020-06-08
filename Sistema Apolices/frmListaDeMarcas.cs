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
    public partial class frmListaDeMarcas : Form
    {

        bool alterar;

        public frmListaDeMarcas()
        {
            InitializeComponent();

            #region Carrega datagrid

            dgvMarcas.ColumnCount = 2;

            dgvMarcas.Columns[0].Name = "Código";
            dgvMarcas.Columns[1].Name = "Marca";

            AtualizarDgv();

            #endregion

            lblNvNome.Visible =     false;
            lblAviso.Visible =      false;
            btnSalvar.Visible =     false;
            btnCancelar.Visible =   false;
            txtNvNome.Visible =     false;
        }

        private void AtualizarDgv()
        {
            try
            {
                List<Marca> marcas;
                marcas = new MarcaController().Listar();
                dgvMarcas.Rows.Clear();
                foreach (Marca item in marcas)
                {
                    dgvMarcas.Rows.Add(item.id.ToString(), item.nome);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovaMarca_Click(object sender, EventArgs e)
        {
            lblNvNome.Visible = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            txtNvNome.Visible = true;

            txtNvNome.Text = "";

            btnAlterar.Enabled = false;
            dgvMarcas.Enabled = false;

            alterar = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblNvNome.Visible = true;
            lblAviso.Visible = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            txtNvNome.Visible = true;

            txtNvNome.Text = dgvMarcas.SelectedRows[0].Cells[1].Value.ToString();

            btnNovaMarca.Enabled = false;
            dgvMarcas.Enabled = false;

            alterar = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (alterar)
                {
                    AlterarMarca();
                }
                else
                {
                    SalvarNovaMarca();
                }

                MessageBox.Show("Ação realizada com sucesso");

                lblNvNome.Visible = false;
                lblAviso.Visible = false;
                btnSalvar.Visible = false;
                btnCancelar.Visible = false;
                txtNvNome.Visible = false;

                btnAlterar.Enabled = true;
                btnNovaMarca.Enabled = true;
                dgvMarcas.Enabled = true;

                AtualizarDgv();

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

        private void SalvarNovaMarca()
        {
            
            Marca marca = new Marca();
            marca.nome = txtNvNome.Text;

            new MarcaController().Inserir(marca);
        }

        private void AlterarMarca()
        {
            Marca marca = new Marca();            
            marca.id = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
            marca.nome = txtNvNome.Text;

            new MarcaController().Alterar(marca);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblNvNome.Visible = false;
            lblAviso.Visible = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            txtNvNome.Visible = false;

            dgvMarcas.Enabled = true;
            btnAlterar.Enabled = true;
            btnNovaMarca.Enabled = true;
        }
    }
}
