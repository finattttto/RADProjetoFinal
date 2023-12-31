﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RADProjetoFinal
{
    public partial class FormAdm : Form
    {
        public FormAdm()
        {
            InitializeComponent();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroMarcas().ShowDialog();
        }

        private void FormAdm_Load(object sender, EventArgs e)
        {

        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroModelo().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            new FormListaModelo().ShowDialog();
        }

        private void btnTabelaFipe_Click(object sender, EventArgs e)
        {
            new FormListaTabelasFIPE().ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            new FormCadastroMarcas().ShowDialog();
        }
    }
}
