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
        #region Contrutor

        public frmListaDeModelos()
        {
            InitializeComponent();

            dgvModelos.ColumnCount = 4;

            dgvModelos.Columns[0].Name = "Código";
            dgvModelos.Columns[2].Name = "Marca";
            dgvModelos.Columns[3].Name = "Modelo";

            //Usado para passar o id da marca para o próximo form
            dgvModelos.Columns[1].Visible = false;

            AtualizarDgv();

        }

        #endregion

        #region Eventos

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
                modelo.Marca = new Marca();

                //Prepara o objeto para ser enviado para tela de alteração
                modelo.Id = Convert.ToInt32(dgvModelos.SelectedRows[0].Cells[0].Value);
                modelo.Marca.Id = Convert.ToInt32(dgvModelos.SelectedRows[0].Cells[1].Value);
                modelo.Nome = dgvModelos.SelectedRows[0].Cells[3].Value.ToString();

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

        #endregion

        #region Métodos

        private void AtualizarDgv()
        {
            try
            {
                Modelo modelo = new Modelo();
                modelo.Marca = new Marca();

                List<Modelo> modelos = new ModeloController().Listar(modelo);

                dgvModelos.Rows.Clear();

                foreach (Modelo item in modelos)
                {
                    dgvModelos.Rows.Add(item.Id.ToString(), item.Marca.Id.ToString(), item.Marca.Nome, item.Nome);
                }

                ChecarDataGrid();

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
            }
            else
            {
                btnAlterar.Visible = true;
            }
        }

        #endregion

    }
}
