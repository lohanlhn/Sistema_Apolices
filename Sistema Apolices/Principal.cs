﻿using Controllers;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            var teste = new CarroController().Listar();

            foreach (Carro item in collection)
            {

            }

        }
    }
}
