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
    public partial class frmAlterarVeiculo : Form
    {
        Carro carro = new Carro();
        public frmAlterarVeiculo(Carro carroSelecionado)
        {
            InitializeComponent();
            try
            {                
                carro = new CarroController().Selecionar(carroSelecionado);

                #region Popula Comboboxs

                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "nome";
                cmbMarca.DataSource = new MarcaController().Listar();
                cmbMarca.SelectedValue = carro.modelo.marca.id;

                Modelo modelo = new Modelo();
                modelo.marca = new Marca();
                modelo.marca.id = carro.modelo.marca.id;

                cmbModelo.ValueMember = "id";
                cmbModelo.DisplayMember = "nome";
                cmbModelo.DataSource = new ModeloController().Listar(modelo);                
                cmbModelo.SelectedValue = carro.modelo.id;            
                #endregion

                #region Carrega textBoxs
                txtChassi.Text = carro.chassi;
                txtPlaca.Text = carro.placa;
                txtRenavam.Text = carro.renavam;
                #endregion

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Carro carroAlterado = new Carro();
                carroAlterado.modelo = new Modelo();
                carroAlterado.modelo.marca = new Marca();

                carroAlterado.id = carro.id;
                if (!String.IsNullOrEmpty(Convert.ToString(cmbMarca.SelectedValue)))
                {
                    carroAlterado.modelo.marca.id = Convert.ToInt32(cmbMarca.SelectedValue);
                }
                if (!String.IsNullOrEmpty(Convert.ToString(cmbModelo.SelectedValue)))
                {
                    carroAlterado.modelo.id = Convert.ToInt32(cmbModelo.SelectedValue);
                }
                carroAlterado.chassi = txtChassi.Text;
                carroAlterado.placa = txtPlaca.Text;
                carroAlterado.renavam = txtRenavam.Text;

                new CarroController().Alterar(carroAlterado);

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
