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

            dgvMarcas.ColumnCount = 2;

            dgvMarcas.Columns[0].Name = "Código";
            dgvMarcas.Columns[1].Name = "Marca";

            AtualizarDgv();
            
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
                    dgvMarcas.Rows.Add(item.Id.ToString(), item.Nome);
                }

                ChecarDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovaMarca_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirAlterarMarca janela = new frmIncluirAlterarMarca(new Marca());

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
                Marca marca = new Marca();

                marca.Id = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                marca.Nome = dgvMarcas.SelectedRows[0].Cells[1].Value.ToString();

                frmIncluirAlterarMarca janela = new frmIncluirAlterarMarca(marca);

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
            if (dgvMarcas.RowCount == 0)
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
