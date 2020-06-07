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
using Utils;

namespace Sistema_Apolices
{
    public partial class frmNovoVeiculo : Form
    {
        public frmNovoVeiculo()
        {
            InitializeComponent();

            try
            {
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "nome";
                cmbMarca.DataSource = new MarcaController().Listar();
                cmbMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Modelo modelo = new Modelo();
                modelo.marca = new Marca();
                modelo.marca.id = Convert.ToInt32(cmbMarca.SelectedValue);               

                cmbModelo.ValueMember = "id";
                cmbModelo.DisplayMember = "nome";
                cmbModelo.DataSource = new ModeloController().Listar(modelo);                

                cmbModelo.Text = "";
                cmbModelo.SelectedIndex = -1;
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
                Carro carro = new Carro();
                carro.modelo = new Modelo();
                carro.modelo.marca = new Marca();

                if (!String.IsNullOrEmpty(Convert.ToString(cmbMarca.SelectedValue)))
                {
                    carro.modelo.marca.id = Convert.ToInt32(cmbMarca.SelectedValue);
                }
                if (!String.IsNullOrEmpty(Convert.ToString(cmbModelo.SelectedValue)))
                {
                    carro.modelo.id = Convert.ToInt32(cmbModelo.SelectedValue);
                }

                carro.chassi = txtChassi.Text;
                carro.placa = txtPlaca.Text;
                carro.renavam = txtRenavam.Text;

                new CarroController().Inserir(carro);

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
