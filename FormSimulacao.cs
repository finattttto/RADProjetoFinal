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
            // O índice da tab ativa mudou, atualiza a visibilidade do botão de voltar
            AtualizarVisibilidadeBotaoVoltar();
        }

        private void AtualizarVisibilidadeBotaoVoltar()
        {
            // Se estiver na primeira tab, esconde o botão de voltar; caso contrário, mostra
            buttonReturn.Visible = tabControl1.SelectedIndex != 0;
        }

        private void buttonAdvance_Click(object sender, EventArgs e)
        {
            // Verifica se há uma próxima tab
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                // Avança para a próxima tab
                tabControl1.SelectedIndex++;

                // Atualiza a visibilidade do botão de voltar com base na nova tab ativa
                AtualizarVisibilidadeBotaoVoltar();
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
    }
}
