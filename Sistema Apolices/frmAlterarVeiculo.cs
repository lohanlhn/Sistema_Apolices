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
    public partial class frmAlterarVeiculo : Form
    {
        public frmAlterarVeiculo(Carro carroSelecionado)
        {
            InitializeComponent();            

            Carro carro = new Carro();

            #region Popula Comboboxs
            carro = new CarroController().Selecionar(carroSelecionado);
            cmbMarca.ValueMember = "id";
            cmbMarca.DisplayMember = "nome";
            cmbMarca.DataSource = new MarcaController().Listar();
            cmbMarca.SelectedValue = carro.modelo.marca.id;

            Marca marca = new Marca();
            marca = new MarcaController().Selecionar((Marca)cmbMarca.SelectedItem);

            cmbModelo.ValueMember = "id";
            cmbModelo.DisplayMember = "nome";
            cmbModelo.DataSource = marca.modelos;
            cmbModelo.SelectedValue = carro.modelo.id;
            #endregion

            txtChassi.Text = carroSelecionado.chassi;
            txtPlaca.Text = carroSelecionado.placa;
            txtRenavam.Text = carroSelecionado.renavam;
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
    }
}
