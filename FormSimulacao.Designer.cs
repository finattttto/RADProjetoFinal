namespace RADProjetoFinal
{
    partial class FormSimulacao
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label marcaIDLabel;
            System.Windows.Forms.Label modeloIDLabel;
            System.Windows.Forms.Label anoFabricacaoLabel;
            System.Windows.Forms.Label anoModeloLabel;
            System.Windows.Forms.Label valorDoBemLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.valorDoBemTextBox = new System.Windows.Forms.TextBox();
            this.apolicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.anoModeloTextBox = new System.Windows.Forms.TextBox();
            this.anoFabricacaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAdvance = new System.Windows.Forms.Button();
            this.apolicesTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ApolicesTableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.marcaIDComboBox = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.MarcasTableAdapter();
            this.modeloIDComboBox = new System.Windows.Forms.ComboBox();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelosTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ModelosTableAdapter();
            marcaIDLabel = new System.Windows.Forms.Label();
            modeloIDLabel = new System.Windows.Forms.Label();
            anoFabricacaoLabel = new System.Windows.Forms.Label();
            anoModeloLabel = new System.Windows.Forms.Label();
            valorDoBemLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaIDLabel
            // 
            marcaIDLabel.AutoSize = true;
            marcaIDLabel.Location = new System.Drawing.Point(109, 155);
            marcaIDLabel.Name = "marcaIDLabel";
            marcaIDLabel.Size = new System.Drawing.Size(61, 20);
            marcaIDLabel.TabIndex = 1;
            marcaIDLabel.Text = "Marca:";
            // 
            // modeloIDLabel
            // 
            modeloIDLabel.AutoSize = true;
            modeloIDLabel.Location = new System.Drawing.Point(109, 206);
            modeloIDLabel.Name = "modeloIDLabel";
            modeloIDLabel.Size = new System.Drawing.Size(68, 20);
            modeloIDLabel.TabIndex = 3;
            modeloIDLabel.Text = "Modelo:";
            // 
            // anoFabricacaoLabel
            // 
            anoFabricacaoLabel.AutoSize = true;
            anoFabricacaoLabel.Location = new System.Drawing.Point(109, 258);
            anoFabricacaoLabel.Name = "anoFabricacaoLabel";
            anoFabricacaoLabel.Size = new System.Drawing.Size(131, 20);
            anoFabricacaoLabel.TabIndex = 5;
            anoFabricacaoLabel.Text = "Ano Fabricacao:";
            // 
            // anoModeloLabel
            // 
            anoModeloLabel.AutoSize = true;
            anoModeloLabel.Location = new System.Drawing.Point(109, 313);
            anoModeloLabel.Name = "anoModeloLabel";
            anoModeloLabel.Size = new System.Drawing.Size(102, 20);
            anoModeloLabel.TabIndex = 7;
            anoModeloLabel.Text = "Ano Modelo:";
            // 
            // valorDoBemLabel
            // 
            valorDoBemLabel.AutoSize = true;
            valorDoBemLabel.Location = new System.Drawing.Point(109, 370);
            valorDoBemLabel.Name = "valorDoBemLabel";
            valorDoBemLabel.Size = new System.Drawing.Size(120, 20);
            valorDoBemLabel.TabIndex = 9;
            valorDoBemLabel.Text = "Valor Do Bem:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 501);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.modeloIDComboBox);
            this.tabPage1.Controls.Add(this.marcaIDComboBox);
            this.tabPage1.Controls.Add(valorDoBemLabel);
            this.tabPage1.Controls.Add(this.valorDoBemTextBox);
            this.tabPage1.Controls.Add(anoModeloLabel);
            this.tabPage1.Controls.Add(this.anoModeloTextBox);
            this.tabPage1.Controls.Add(anoFabricacaoLabel);
            this.tabPage1.Controls.Add(this.anoFabricacaoTextBox);
            this.tabPage1.Controls.Add(modeloIDLabel);
            this.tabPage1.Controls.Add(marcaIDLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Etapa 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // valorDoBemTextBox
            // 
            this.valorDoBemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ValorDoBem", true));
            this.valorDoBemTextBox.Location = new System.Drawing.Point(255, 369);
            this.valorDoBemTextBox.Name = "valorDoBemTextBox";
            this.valorDoBemTextBox.Size = new System.Drawing.Size(232, 26);
            this.valorDoBemTextBox.TabIndex = 10;
            // 
            // apolicesBindingSource
            // 
            this.apolicesBindingSource.DataMember = "Apolices";
            this.apolicesBindingSource.DataSource = this.corretoraDataSet;
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anoModeloTextBox
            // 
            this.anoModeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "AnoModelo", true));
            this.anoModeloTextBox.Location = new System.Drawing.Point(255, 313);
            this.anoModeloTextBox.Name = "anoModeloTextBox";
            this.anoModeloTextBox.Size = new System.Drawing.Size(232, 26);
            this.anoModeloTextBox.TabIndex = 8;
            // 
            // anoFabricacaoTextBox
            // 
            this.anoFabricacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "AnoFabricacao", true));
            this.anoFabricacaoTextBox.Location = new System.Drawing.Point(255, 258);
            this.anoFabricacaoTextBox.Name = "anoFabricacaoTextBox";
            this.anoFabricacaoTextBox.Size = new System.Drawing.Size(232, 26);
            this.anoFabricacaoTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preencha os dados do veículo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etapa 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(96, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Combustivel: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(83, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Número placa: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(74, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Número chassi: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Gasolina",
            "Álcool",
            "Diesel",
            "Flex",
            "GNV",
            "Elétrico",
            "Outro"});
            this.comboBox4.Location = new System.Drawing.Point(233, 239);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(148, 28);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(233, 140);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 26);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label12.Location = new System.Drawing.Point(44, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(437, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "Dados do veículo complementares:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox5);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Etapa 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox5.Location = new System.Drawing.Point(111, 313);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(191, 29);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "Franquia reduzida";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox4.Location = new System.Drawing.Point(111, 263);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(229, 29);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Danos contra terceiros";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox3.Location = new System.Drawing.Point(111, 213);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(300, 29);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Acidente de qualquer natureza";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox2.Location = new System.Drawing.Point(111, 164);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(175, 29);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Vidros e granizo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(111, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Roubo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(44, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(464, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "Assinale as coberturas desejadas (*):";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(992, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Etapa 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label11.Location = new System.Drawing.Point(44, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 31);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cálculo da apólice:";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonExit.Location = new System.Drawing.Point(54, 508);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 61);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonReturn.Location = new System.Drawing.Point(654, 508);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(145, 61);
            this.buttonReturn.TabIndex = 8;
            this.buttonReturn.Text = "Voltar";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAdvance
            // 
            this.buttonAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdvance.Location = new System.Drawing.Point(819, 508);
            this.buttonAdvance.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdvance.Name = "buttonAdvance";
            this.buttonAdvance.Size = new System.Drawing.Size(145, 61);
            this.buttonAdvance.TabIndex = 7;
            this.buttonAdvance.Text = "Avançar";
            this.buttonAdvance.UseVisualStyleBackColor = true;
            this.buttonAdvance.Click += new System.EventHandler(this.buttonAdvance_Click);
            // 
            // apolicesTableAdapter
            // 
            this.apolicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = this.apolicesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marcaIDComboBox
            // 
            this.marcaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "MarcaID", true));
            this.marcaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.marcasBindingSource, "Marca", true));
            this.marcaIDComboBox.DataSource = this.marcasBindingSource;
            this.marcaIDComboBox.DisplayMember = "Marca";
            this.marcaIDComboBox.FormattingEnabled = true;
            this.marcaIDComboBox.Location = new System.Drawing.Point(255, 153);
            this.marcaIDComboBox.Name = "marcaIDComboBox";
            this.marcaIDComboBox.Size = new System.Drawing.Size(231, 28);
            this.marcaIDComboBox.TabIndex = 11;
            this.marcaIDComboBox.ValueMember = "ID";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.corretoraDataSet;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // modeloIDComboBox
            // 
            this.modeloIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apolicesBindingSource, "ModeloID", true));
            this.modeloIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelosBindingSource, "Modelo", true));
            this.modeloIDComboBox.DataSource = this.modelosBindingSource;
            this.modeloIDComboBox.DisplayMember = "Modelo";
            this.modeloIDComboBox.FormattingEnabled = true;
            this.modeloIDComboBox.Location = new System.Drawing.Point(255, 203);
            this.modeloIDComboBox.Name = "modeloIDComboBox";
            this.modeloIDComboBox.Size = new System.Drawing.Size(232, 28);
            this.modeloIDComboBox.TabIndex = 12;
            this.modeloIDComboBox.ValueMember = "ModeloID";
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.corretoraDataSet;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // FormSimulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1000, 582);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdvance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSimulacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSimulacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSimulacao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonAdvance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource apolicesBindingSource;
        private CorretoraDataSetTableAdapters.ApolicesTableAdapter apolicesTableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox valorDoBemTextBox;
        private System.Windows.Forms.TextBox anoModeloTextBox;
        private System.Windows.Forms.TextBox anoFabricacaoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox marcaIDComboBox;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private CorretoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.ComboBox modeloIDComboBox;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private CorretoraDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
    }
}