namespace RADProjetoFinal
{
    partial class FormAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnTabelaFipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(182, 159);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(111, 90);
            this.btnMarcas.TabIndex = 1;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.Location = new System.Drawing.Point(317, 159);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(103, 90);
            this.btnModelos.TabIndex = 2;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.UseVisualStyleBackColor = true;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnTabelaFipe
            // 
            this.btnTabelaFipe.Location = new System.Drawing.Point(443, 159);
            this.btnTabelaFipe.Name = "btnTabelaFipe";
            this.btnTabelaFipe.Size = new System.Drawing.Size(132, 90);
            this.btnTabelaFipe.TabIndex = 3;
            this.btnTabelaFipe.Text = "Tabelas Fipe";
            this.btnTabelaFipe.UseVisualStyleBackColor = true;
            this.btnTabelaFipe.Click += new System.EventHandler(this.btnTabelaFipe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wizard de Administração";
            // 
            // FormAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTabelaFipe);
            this.Controls.Add(this.btnModelos);
            this.Controls.Add(this.btnMarcas);
            this.Name = "FormAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnTabelaFipe;
        private System.Windows.Forms.Label label1;
    }
}