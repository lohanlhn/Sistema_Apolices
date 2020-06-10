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
    public partial class frmInserirApolice : Form
    {
        Carro carro = new Carro();
        public frmInserirApolice(Carro carroSelecionado)
        {
            InitializeComponent();

            carro = carroSelecionado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Apolice apolice = new Apolice();
            apolice.carro = new Carro();

            apolice.carro.id = carro.id;
            apolice.dtFim = dtpFimVigencia.Value;
            apolice.dtInicio = dtpInicioVigencia.Value;
            apolice.valorFranquia = Convert.ToDecimal(txtVlFranquia.Text);
            apolice.valorPremio = Convert.ToDecimal(txtVlPremio.Text);

            new ApoliceController().Inserir(apolice);
        }
    }
}
