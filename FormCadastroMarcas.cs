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
    public partial class FormCadastroMarcas : Form
    {
        public FormCadastroMarcas()
        {
            InitializeComponent();
        }

        private void marcasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.marcasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar alterações! Pode existir uma tabela FIPE associada ao modelo excluído!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FormCadastroMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.corretoraDataSet.Marcas);

        }

        private void marcasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
