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
    public partial class FormMenu : Form
    {

        private FormAdm formAdm;

        public FormMenu()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F5))
            {
                if (formAdm == null || formAdm.IsDisposed)
                {
                    formAdm = new FormAdm();
                    formAdm.Show();
                }
                else
                {
                    formAdm.BringToFront();
                }
                return true;
            }
  
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroModelo().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroMarcas().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormCadastroModelo().ShowDialog();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                new FormSimulacao().ShowDialog();
            }catch (Exception ex)
            {

            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void tabelaFipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroTabelaFipe().ShowDialog();
        }
    }
}
