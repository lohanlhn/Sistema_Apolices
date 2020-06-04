using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Entities;

namespace Sistema_Apolices
{
    public partial class frmNovoVeiculo : Form
    {
        public frmNovoVeiculo()
        {
            InitializeComponent();
            
            cmbMarca.ValueMember = "id";
            cmbMarca.DisplayMember = "nome";            
            cmbMarca.DataSource = new MarcaController().Listar();
            cmbMarca.SelectedIndex = -1;
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            modelo.marca = new Marca();
            modelo.marca.id = (int)cmbMarca.SelectedValue;
            cmbModelo.ValueMember = "id";
            cmbModelo.DisplayMember = "nome";
            cmbModelo.DataSource = new ModeloController().Listar(modelo);
            cmbModelo.SelectedIndex = -1;

        }
    }
}
