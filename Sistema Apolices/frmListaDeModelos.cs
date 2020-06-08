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
    public partial class frmListaDeModelos : Form
    {

        bool alterar;
        public frmListaDeModelos()
        {
            InitializeComponent();

            #region Carrega datagrid

            dgvModelos.ColumnCount = 4;

            dgvModelos.Columns[0].Name = "Código";
            dgvModelos.Columns[2].Name = "Marca";
            dgvModelos.Columns[3].Name = "Modelo";

            dgvModelos.Columns[1].Visible = false;


            AtualizarDgv();

            #endregion

            lblNvNome.Visible = false;
            lblMarca.Visible = false;
            lblAviso.Visible = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            txtNvNome.Visible = false;
            cmbMarca.Visible = false;
        }
        private void AtualizarDgv()
        {
            try
            {
                Modelo modelo = new Modelo();
                modelo.marca = new Marca();

                List <Modelo> modelos;
                
                modelos = new ModeloController().Listar(modelo);
                dgvModelos.Rows.Clear();
                foreach (Modelo item in modelos)
                {
                    dgvModelos.Rows.Add(item.id.ToString(), item.marca.id.ToString(),item.marca.nome, item.nome);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoModelo_Click(object sender, EventArgs e)
        {
            try
            {
                lblNvNome.Visible = true;
                btnSalvar.Visible = true;
                lblMarca.Visible = true;
                btnCancelar.Visible = true;
                txtNvNome.Visible = true;
                cmbMarca.Visible = true;

                txtNvNome.Text = "";
                
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "nome";
                cmbMarca.DataSource = new MarcaController().Listar();
                cmbMarca.SelectedIndex = -1;

                btnAlterar.Enabled = false;
                dgvModelos.Enabled = false;

                alterar = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                lblNvNome.Visible = true;
                lblAviso.Visible = true;
                lblMarca.Visible = true;
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                txtNvNome.Visible = true;
                cmbMarca.Visible = true;

                //popula combobox
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "nome";
                cmbMarca.DataSource = new MarcaController().Listar();
                //seleciona marca
                cmbMarca.SelectedValue = Convert.ToInt32(dgvModelos.SelectedRows[0].Cells[1].Value);

                txtNvNome.Text = dgvModelos.SelectedRows[0].Cells[3].Value.ToString();

                btnNovoModelo.Enabled = false;
                dgvModelos.Enabled = false;

                alterar = true;
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
                if (alterar)
                {
                    AlterarModelo();
                }
                else
                {
                    SalvarNovoModelo();
                }

                MessageBox.Show("Ação realizada com sucesso");

                lblNvNome.Visible = false;
                lblMarca.Visible = false;
                lblAviso.Visible = false;
                btnSalvar.Visible = false;
                btnCancelar.Visible = false;
                txtNvNome.Visible = false;
                cmbMarca.Visible = false;

                btnAlterar.Enabled = true;
                btnNovoModelo.Enabled = true;
                dgvModelos.Enabled = true;

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
        private void SalvarNovoModelo()
        {

            Modelo modelo = new Modelo();
            modelo.marca = new Marca();

            modelo.nome = txtNvNome.Text;
            modelo.marca.id = Convert.ToInt32(cmbMarca.SelectedValue);


            new ModeloController().Inserir(modelo);
        }
        private void AlterarModelo()
        {

            Modelo modelo = new Modelo();
            modelo.marca = new Marca();

            modelo.id = Convert.ToInt32(dgvModelos.SelectedRows[0].Cells[0].Value);
            modelo.nome = txtNvNome.Text;
            modelo.marca.id = Convert.ToInt32(cmbMarca.SelectedValue);


            new ModeloController().Alterar(modelo);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblNvNome.Visible = false;
            lblAviso.Visible = false;
            lblMarca.Visible = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            txtNvNome.Visible = false;
            cmbMarca.Visible = false;

            dgvModelos.Enabled = true;
            btnAlterar.Enabled = true;
            btnNovoModelo.Enabled = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            lblNvNome.Visible = false;
            lblMarca.Visible = false;
            lblAviso.Visible = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            txtNvNome.Visible = false;
            cmbMarca.Visible = false;

            dgvModelos.Enabled = true;
            btnAlterar.Enabled = true;
            btnNovoModelo.Enabled = true;
        }
    }
}
