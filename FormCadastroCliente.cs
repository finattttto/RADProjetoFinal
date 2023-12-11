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
        public FormCadastroCliente()
        {
            InitializeComponent();  
        }


        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
            int proximoValor = (int)((DataRowView)clientesBindingSource.Current)["ClienteID"];
            clienteIDTextBox.Text = proximoValor.ToString();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableAdapterManager.ClientesTableAdapter.Insert(
                    int.Parse(clienteIDTextBox.Text), nomeTextBox.Text, enderecoTextBox.Text, cEPTextBox.Text, cidadeTextBox.Text,
                    uFComboBox.SelectedItem.ToString(), telefoneTextBox.Text, celularTextBox.Text, cPFTextBox.Text, rGTextBox.Text,
                    orgaoEmissorTextBox.Text, cartMotoristaTextBox.Text, emissaoCartMotDateTimePicker.Value, cartMotoristaTextBox.Text,
                    dataNascimentoDateTimePicker.Value, emailTextBox.Text
                    ) ;
                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException ex) {
                MessageBox.Show("Campo de tipo data com valor inválido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
