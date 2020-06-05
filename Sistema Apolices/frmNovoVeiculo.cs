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
            Marca marca = new Marca();
            marca = new MarcaController().Selecionar((Marca)cmbMarca.SelectedItem);


            cmbModelo.ValueMember = "id";
            cmbModelo.DisplayMember = "nome";
            cmbModelo.DataSource = marca.modelos;

            cmbModelo.Text = "";
            cmbModelo.SelectedIndex = -1;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            carro.modelo = new Modelo();

            carro.modelo.id = Convert.ToInt32(cmbModelo.SelectedValue.ToString());
            carro.chassi = txtChassi.Text;
            carro.placa = txtPlaca.Text;
            carro.renavam = txtRenavam.Text;

            new CarroController().Inserir(carro);
        }
    }
}
