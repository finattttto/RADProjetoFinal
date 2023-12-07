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
    public partial class FormSimulacao : Form
    {
        public FormSimulacao()
        {
            InitializeComponent();
        }

        private void FormSimulacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.corretoraDataSet.Modelos);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.corretoraDataSet.Marcas);
            // TODO: esta linha de código carrega dados na tabela 'corretoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.corretoraDataSet.Apolices);
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

        private void buttonAdvance_Click(object sender, EventArgs e)
        {
    
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex++;

                AtualizarVisibilidadeBotaoVoltar();

                if(tabControl1.SelectedIndex == 3)
                {

                }
                else if(tabControl1.SelectedIndex == 4)
                {
                    this.Validate();
                    this.apolicesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.corretoraDataSet);
                }

            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            // Verifica se há uma tab anterior
            if (tabControl1.SelectedIndex > 0)
            {
                // Retrocede para a tab anterior
                tabControl1.SelectedIndex--;

                // Atualiza a visibilidade do botão de voltar com base na nova tab ativa
                AtualizarVisibilidadeBotaoVoltar();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        // metodo que salva a apolice
        private void apolicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apolicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.corretoraDataSet);

        }

    }
}
