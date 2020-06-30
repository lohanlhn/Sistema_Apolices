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
        //Campo
        private Form _formAtivo = null;

        #region Contrutor

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        //Abre o form da lista de veiuculos
        private void btnVeículos_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirNovoForm(new frmListaDeVeiculos());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }

        //Abre o form da lista de marcas
        private void btnMarcas_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirNovoForm(new frmListaDeMarcas());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }

        //Abre o form da lista de modelos
        private void btnModelos_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirNovoForm(new frmListaDeModelos());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }

        //Fecha o form que estiver aberto
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_formAtivo != null)
                {
                    _formAtivo.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Métodos

        //Fecha o form aberto caso exista e abre o novo
        public void AbrirNovoForm(Form novoForm)
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

        #endregion

    }
}
