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
    public partial class FormListaModelo : Form
    {
        public FormListaModelo()
        {
            InitializeComponent();
        }

        private void FormListaModelo_Load(object sender, EventArgs e)
        {
            this.viewModelosTableAdapter.Fill(this.corretoraDataSet.ViewModelos);

        }

        private void txtMarcaPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarcaPesquisar.Text))
            {
                viewModelosBindingSource.RemoveFilter();
            }
            else
            {
                string filtro = $"Marca LIKE '%{txtMarcaPesquisar.Text}%'";
                viewModelosBindingSource.Filter = filtro;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormCadastroModelo().ShowDialog();
        }

        private void viewModelosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
