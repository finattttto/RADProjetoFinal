namespace RADProjetoFinal
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaFipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.tabelaFipeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.carrosToolStripMenuItem.Text = "&Marcas";
            this.carrosToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoriasToolStripMenuItem.Text = "&Modelos";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // tabelaFipeToolStripMenuItem
            // 
            this.tabelaFipeToolStripMenuItem.Name = "tabelaFipeToolStripMenuItem";
            this.tabelaFipeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tabelaFipeToolStripMenuItem.Text = "&Tabela Fipe";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIniciar.AutoSize = true;
            this.buttonIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIniciar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciar.FlatAppearance.BorderSize = 0;
            this.buttonIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIniciar.Image = ((System.Drawing.Image)(resources.GetObject("buttonIniciar.Image")));
            this.buttonIniciar.Location = new System.Drawing.Point(134, 86);
            this.buttonIniciar.Margin = new System.Windows.Forms.Padding(10);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(817, 314);
            this.buttonIniciar.TabIndex = 1;
            this.buttonIniciar.Text = "Clique na figura para iniciar a simulação";
            this.buttonIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(173, 100);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaFipeToolStripMenuItem;
        private System.Windows.Forms.Button buttonIniciar;
    }
}

