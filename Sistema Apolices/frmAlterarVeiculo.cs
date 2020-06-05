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
        int idCarroSelecionado;
        public frmAlterarVeiculo(Carro carroSelecionado)
        {
            InitializeComponent();
            try
            {
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

                #region Carrega textBoxs
                txtChassi.Text = carroSelecionado.chassi;
                txtPlaca.Text = carroSelecionado.placa;
                txtRenavam.Text = carroSelecionado.renavam;
                #endregion

                //Necessario para alterar registro
                idCarroSelecionado = carroSelecionado.id;
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
                Marca marca = new Marca();
                marca = new MarcaController().Selecionar((Marca)cmbMarca.SelectedItem);


                cmbModelo.ValueMember = "id";
                cmbModelo.DisplayMember = "nome";
                cmbModelo.DataSource = marca.modelos;

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
                Carro carro = new Carro();
                carro.modelo = new Modelo();
                carro.modelo.marca = new Marca();

                carro.id = idCarroSelecionado;
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

                new CarroController().Alterar(carro);

                MessageBox.Show("Operação realizada com sucesso");
                this.DialogResult = DialogResult.OK;
                this.Close();
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
