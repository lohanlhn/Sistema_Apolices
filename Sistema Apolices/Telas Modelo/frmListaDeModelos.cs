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

                ChecarDataGrid();

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
                frmIncluirAlterarModelo janela = new frmIncluirAlterarModelo(new Modelo());

                if (janela.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDgv();
                }
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
                Modelo modelo = new Modelo();
                modelo.marca = new Marca();

                modelo.id = Convert.ToInt32(dgvModelos.SelectedRows[0].Cells[0].Value);
                modelo.marca.id = Convert.ToInt32(dgvModelos.SelectedRows[0].Cells[1].Value);
                modelo.nome = dgvModelos.SelectedRows[0].Cells[3].Value.ToString();

                frmIncluirAlterarModelo janela = new frmIncluirAlterarModelo(modelo);

                if (janela.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDgv();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ChecarDataGrid()
        {
            if (dgvModelos.RowCount == 0)
            {
                btnAlterar.Visible = false;
                btnAlterar.Enabled = false;
            }
            else
            {
                btnAlterar.Visible = true;
                btnAlterar.Enabled = true;
            }
        }
    }
}
