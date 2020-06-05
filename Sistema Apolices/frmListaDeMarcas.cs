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

namespace Sistema_Apolices
{
    public partial class frmListaDeMarcas : Form
    {
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
                    dgvMarcas.Rows.Add(item.id.ToString(), item.nome);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
