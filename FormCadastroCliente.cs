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
    public partial class FormCadastroCliente : Form
    {
        FormSimulacao form;
        public FormCadastroCliente()
        {
            InitializeComponent();  
        }

        public FormCadastroCliente(FormSimulacao form)
        {
            InitializeComponent();
            this.form = form;
        }


        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            this.clientesBindingSource.AddNew();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.TextLength < 2)
            {
                MessageBox.Show("Digite um nome!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataRowView currentRow = (DataRowView)clientesBindingSource.Current;
                currentRow["ClienteID"] = int.Parse(clienteIDTextBox.Text);

                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.cadastrarApolice(int.Parse(clienteIDTextBox.Text));
                this.Close();
            }
            catch (FormatException ex) {
                MessageBox.Show("Campo de tipo data com valor inválido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
