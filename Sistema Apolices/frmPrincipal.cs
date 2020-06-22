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
    public partial class frmPrincipal : Form
    {
        private Form _formAtivo = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }


        //Fecha o form aberto e abre o novo
        public void abrirNovoForm(Form novoForm)
        {            
            if (_formAtivo != null)
            {
                _formAtivo.Close();
            }
            _formAtivo = novoForm;
            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;
            panelNovoForm.Controls.Add(novoForm);
            panelNovoForm.Tag = novoForm;
            novoForm.BringToFront();
            novoForm.Show();
        }


        //Abre o form da lista de veiuculos
        private void btnVeículos_Click(object sender, EventArgs e)
        {
            abrirNovoForm(new frmListaDeVeiculos());
        }

        //Abre o form da lista de marcas
        private void btnMarcas_Click(object sender, EventArgs e)
        {
            abrirNovoForm(new frmListaDeMarcas());
        }

        //Abre o form da lista de modelos
        private void btnModelos_Click(object sender, EventArgs e)
        {
            abrirNovoForm(new frmListaDeModelos());
        }

        //Fecha o form que estiver aberto
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(_formAtivo != null)
            {
                _formAtivo.Close();
            }
            
        }

    }
}
