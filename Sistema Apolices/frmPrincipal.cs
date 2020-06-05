using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Sistema_Apolices
{
    public partial class frmPrincipal : Form
    {
        List<Carro> carro;
        public frmPrincipal()
        {
            InitializeComponent();

            dgvCarros.ColumnCount = 6;

            dgvCarros.Columns[0].Name = "Código";
            dgvCarros.Columns[1].Name = "Marca";
            dgvCarros.Columns[2].Name = "Modelo";
            dgvCarros.Columns[3].Name = "Chassi";
            dgvCarros.Columns[4].Name = "Placa";
            dgvCarros.Columns[5].Name = "Renavam";            

            AtualizarDgv();            

        }

        private void AtualizarDgv()
        {
            carro = new CarroController().Listar();

            foreach (Carro item in carro)
            {
                dgvCarros.Rows.Add(item.id.ToString(), item.modelo.marca.nome, item.modelo.nome, item.chassi, item.placa, item.renavam);
            }
        }

        private void btnNovoVeiculo_Click(object sender, EventArgs e)
        {
            frmNovoVeiculo frm = new frmNovoVeiculo();

            frm.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            carro.id = int.Parse(dgvCarros.SelectedRows[0].Cells[0].Value.ToString());
            carro.chassi = dgvCarros.SelectedRows[0].Cells[3].Value.ToString();
            carro.placa = dgvCarros.SelectedRows[0].Cells[4].Value.ToString();
            carro.renavam = dgvCarros.SelectedRows[0].Cells[5].Value.ToString();

            frmAlterarVeiculo janela = new frmAlterarVeiculo(carro);

            janela.Show();
        }
    }
}
