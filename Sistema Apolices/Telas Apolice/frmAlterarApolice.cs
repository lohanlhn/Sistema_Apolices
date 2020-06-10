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
    public partial class frmAlterarApolice : Form
    {
        public frmAlterarApolice(Apolice apoliceSelecioanda)
        {
            InitializeComponent();

            Apolice apolice = new ApoliceController().Selecionar(apoliceSelecioanda);


        }
    }
}
