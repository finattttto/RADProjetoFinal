using System;
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
    public partial class FormListaTabelasFIPE : Form
    {
        public FormListaTabelasFIPE()
        {
            InitializeComponent();
        }

        private void FormListaTabelasFIPE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewTabelasFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.viewTabelasFIPETableAdapter.Fill(this.corretoraDataSet.ViewTabelasFIPE);

        }

        private void txtPesquisaMarcas_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisaMarcas.Text) && string.IsNullOrWhiteSpace(txtPesquisaModelo.Text))
            {
                viewTabelasFIPEBindingSource.RemoveFilter();
            }
            else
            {
                string filtro = $"Marca LIKE '%{txtPesquisaMarcas.Text}%' AND Modelo LIKE '%{txtPesquisaModelo.Text}%'";
                viewTabelasFIPEBindingSource.Filter = filtro;
            }
        }

        private void txtPesquisaModelo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisaMarcas.Text) && string.IsNullOrWhiteSpace(txtPesquisaModelo.Text))
            {
                viewTabelasFIPEBindingSource.RemoveFilter();
            }
            else
            {
                string filtro = $"Marca LIKE '%{txtPesquisaMarcas.Text}%' AND Modelo LIKE '%{txtPesquisaModelo.Text}%'";
                viewTabelasFIPEBindingSource.Filter = filtro;
            }
        }

        private void btnAbrirCRUD_Click(object sender, EventArgs e)
        {
            new FormCadastroTabelaFipe().ShowDialog();
        }
    }
}
