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
    public partial class FormSimulacao : Form
    {
        public FormSimulacao()
        {
            InitializeComponent();
        }

        private void FormSimulacao_Load(object sender, EventArgs e)
        {
            apolicesBindingSource.AddNew();

            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.TabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaFIPETableAdapter.Fill(this.corretoraDataSet.TabelaFIPE);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewModelos'. Você pode movê-la ou removê-la conforme necessário.
            this.viewModelosTableAdapter.Fill(this.corretoraDataSet.ViewModelos);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.ViewTabelasFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.viewTabelasFIPETableAdapter.Fill(this.corretoraDataSet.ViewTabelasFIPE);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.corretoraDataSet.Modelos);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.corretoraDataSet.Marcas);
            // Configurar o evento SelectedIndexChanged
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            
            // Inicialmente, verifica o índice da tab ativa
            AtualizarVisibilidadeBotaoVoltar();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarVisibilidadeBotaoVoltar();
        }

        private void AtualizarVisibilidadeBotaoVoltar()
        {
            buttonReturn.Visible = tabControl1.SelectedIndex != 0;
        }

        private void calcularValoresIniciaisApolice()
        {
            try
            {
                double valorApolice = 0.0;
                double valorPremioInicial = 0.0;
                double valorPremioTotal = 0.0;
                double valorFranquia = 0.0;

                DataRowView selectedRow = (DataRowView)valorComboBox.SelectedItem;
                decimal valorDecimal = (decimal)selectedRow["Valor"];

                valorApolice = Convert.ToDouble(valorDecimal) * 1.1;
                valorPremioInicial = valorApolice * 0.015;
                valorPremioTotal = valorApolice * 0.015;
                valorFranquia = Convert.ToDouble(valorDecimal) * 0.06;

                if (rouboCheckBox.Checked)
                {
                    valorPremioTotal += valorPremioInicial * 0.12;
                }

                if (vidrosCheckBox.Checked)
                {
                    valorPremioTotal += valorPremioInicial * 0.01;
                }

                if (acidentesCheckBox.Checked)
                {
                    valorPremioTotal += valorPremioInicial * 0.04;
                }

                if (danosTerceirosCheckBox.Checked)
                {
                    valorPremioTotal += valorPremioInicial * 0.05;
                }

                if (franquiaRedCheckBox.Checked)
                {
                    valorPremioTotal += valorPremioInicial * 0.03;
                    valorFranquia = valorFranquia / 2;
                }

                // "F" + 2 como parametro em tostring fixa o ponto flutuante em 2 casas
                lblValorApolice.Text += valorApolice.ToString("F" + 2);
                lblValorPremio.Text += valorPremioTotal.ToString("F" + 2);
                lblValorFranquia.Text += valorFranquia.ToString("F" + 2);
                
            } catch(Exception ex) { }
        }

        private void buttonAdvance_Click(object sender, EventArgs e)
        {
    
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    if (marcaIDComboBox.SelectedValue == null)
                    {
                        MessageBox.Show("Selecione uma marca, se necessário, cadastre!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (modeloIDComboBox.SelectedValue == null)
                    {
                        MessageBox.Show("Selecione um modelo, se necessário, cadastre!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (anoModeloComboBox.SelectedValue == null || valorComboBox.SelectedValue == null)
                    {
                        MessageBox.Show("Cadastre uma tabela fipe para este modelo e ano!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else if(anoFabricacaoTextBox.TextLength < 1)
                    {
                        MessageBox.Show("Digite o ano de fabricação!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }else if(tabControl1.SelectedIndex == 1)
                {
                    if(chassiTextBox.TextLength < 2)
                    {
                        MessageBox.Show("Digite a informação do Chassi!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else if(placaTextBox.TextLength < 2)
                    {
                        MessageBox.Show("Digite a placa!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else if(comboBoxCombustivel.SelectedItem == null)
                    {
                        MessageBox.Show("Escolha o tipo de combustível do veículo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                tabControl1.SelectedIndex++;

                AtualizarVisibilidadeBotaoVoltar();

               

                if(tabControl1.SelectedIndex == 3)
                {
                    calcularValoresIniciaisApolice();
                    buttonAdvance.Text = "Contratar";
                }

            }
            else if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                 Console.WriteLine(this.apolicesBindingSource);
                try
                {
                    new FormCadastroCliente(this).ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void cadastrarApolice(int clienteId)
        {
            try
            {
               
                DataRowView currentRow = (DataRowView)apolicesBindingSource.Current;
                currentRow["ClienteID"] = clienteId;

                this.Validate();
                this.apolicesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
                
            }
            catch (Exception ex){
               
            }
            this.Close();

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
             
                tabControl1.SelectedIndex--;
                buttonAdvance.Text = "Avançar";
                AtualizarVisibilidadeBotaoVoltar();
            }
        }
 

        private void marcaIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marcaIDComboBox.SelectedValue != null )
            {
                string filtro = $"MarcaID = '{marcaIDComboBox.SelectedValue}' ";
               
                modelosBindingSource.Filter = filtro;
                modeloIDComboBox.DataSource = modelosBindingSource;
                modeloIDComboBox.DisplayMember = "Modelo";
                modeloIDComboBox.ValueMember = "ModeloID";
            }
        }


        private void modeloIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (modeloIDComboBox.SelectedValue != null && marcaIDComboBox.SelectedValue != null )
            {
                string filtro = $"ModeloID = {modeloIDComboBox.SelectedValue} " +
                                $"AND MarcaID = {marcaIDComboBox.SelectedValue} ";
         
                tabelaFIPEBindingSource.Filter = filtro;
                anoModeloComboBox.DataSource = tabelaFIPEBindingSource;
                anoModeloComboBox.DisplayMember = "Ano";
                anoModeloComboBox.ValueMember = "Ano";
               
            }
            
        }

        private void anoModeloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (marcaIDComboBox.SelectedValue != null && modeloIDComboBox.SelectedValue != null 
                    && anoModeloComboBox.SelectedValue != null )
                {

                    BindingSource TabelaFipeBindingSourceValor = new BindingSource();
                    TabelaFipeBindingSourceValor.DataSource = tabelaFIPEBindingSource;
                    string filtro = $"ModeloID = {modeloIDComboBox.SelectedValue} " +
                                    $"AND MarcaID = {marcaIDComboBox.SelectedValue} " +
                                    $"AND Ano = {anoModeloComboBox.SelectedValue}";

                    TabelaFipeBindingSourceValor.Filter = filtro;
                    valorComboBox.DataSource = TabelaFipeBindingSourceValor;
                    valorComboBox.DisplayMember = "Valor";
                    valorComboBox.ValueMember = "Valor";


                }
            
        }

      
    }
}
