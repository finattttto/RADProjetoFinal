
namespace RADProjetoFinal
{
    partial class FormCadastroCliente
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
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label orgaoEmissorLabel;
            System.Windows.Forms.Label cartMotoristaLabel;
            System.Windows.Forms.Label emissaoCartMotLabel;
            System.Windows.Forms.Label categoriaMotLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clienteIDLabel;
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.uFComboBox = new System.Windows.Forms.ComboBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.orgaoEmissorTextBox = new System.Windows.Forms.TextBox();
            this.cartMotoristaTextBox = new System.Windows.Forms.TextBox();
            this.emissaoCartMotDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaMotTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clienteIDTextBox = new System.Windows.Forms.TextBox();
            enderecoLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            orgaoEmissorLabel = new System.Windows.Forms.Label();
            cartMotoristaLabel = new System.Windows.Forms.Label();
            emissaoCartMotLabel = new System.Windows.Forms.Label();
            categoriaMotLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clienteIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(479, 23);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 0;
            enderecoLabel.Text = "Endereco:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(331, 23);
            cEPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 2;
            cEPLabel.Text = "CEP:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(13, 27);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(150, 23);
            cidadeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 6;
            cidadeLabel.Text = "Cidade:";
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(15, 23);
            uFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 8;
            uFLabel.Text = "UF:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(415, 63);
            telefoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 10;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(415, 30);
            celularLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 12;
            celularLabel.Text = "Celular:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(13, 93);
            cPFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 14;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(13, 121);
            rGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 16;
            rGLabel.Text = "RG:";
            // 
            // orgaoEmissorLabel
            // 
            orgaoEmissorLabel.AutoSize = true;
            orgaoEmissorLabel.Location = new System.Drawing.Point(12, 31);
            orgaoEmissorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            orgaoEmissorLabel.Name = "orgaoEmissorLabel";
            orgaoEmissorLabel.Size = new System.Drawing.Size(78, 13);
            orgaoEmissorLabel.TabIndex = 18;
            orgaoEmissorLabel.Text = "Orgao Emissor:";
            // 
            // cartMotoristaLabel
            // 
            cartMotoristaLabel.AutoSize = true;
            cartMotoristaLabel.Location = new System.Drawing.Point(450, 34);
            cartMotoristaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cartMotoristaLabel.Name = "cartMotoristaLabel";
            cartMotoristaLabel.Size = new System.Drawing.Size(63, 13);
            cartMotoristaLabel.TabIndex = 20;
            cartMotoristaLabel.Text = "No Carteira:";
            // 
            // emissaoCartMotLabel
            // 
            emissaoCartMotLabel.AutoSize = true;
            emissaoCartMotLabel.Location = new System.Drawing.Point(176, 31);
            emissaoCartMotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emissaoCartMotLabel.Name = "emissaoCartMotLabel";
            emissaoCartMotLabel.Size = new System.Drawing.Size(49, 13);
            emissaoCartMotLabel.TabIndex = 22;
            emissaoCartMotLabel.Text = "Emissao:";
            // 
            // categoriaMotLabel
            // 
            categoriaMotLabel.AutoSize = true;
            categoriaMotLabel.Location = new System.Drawing.Point(591, 30);
            categoriaMotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoriaMotLabel.Name = "categoriaMotLabel";
            categoriaMotLabel.Size = new System.Drawing.Size(60, 13);
            categoriaMotLabel.TabIndex = 24;
            categoriaMotLabel.Text = "Categorias:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(14, 57);
            dataNascimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 26;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(414, 99);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 28;
            emailLabel.Text = "Email:";
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.corretoraDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(539, 20);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(153, 20);
            this.enderecoTextBox.TabIndex = 1;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(217, 18);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(92, 20);
            this.cidadeTextBox.TabIndex = 7;
            // 
            // uFComboBox
            // 
            this.uFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "UF", true));
            this.uFComboBox.FormattingEnabled = true;
            this.uFComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.uFComboBox.Location = new System.Drawing.Point(70, 18);
            this.uFComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.uFComboBox.Name = "uFComboBox";
            this.uFComboBox.Size = new System.Drawing.Size(51, 21);
            this.uFComboBox.TabIndex = 9;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(511, 60);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(181, 20);
            this.telefoneTextBox.TabIndex = 11;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(511, 27);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(181, 20);
            this.celularTextBox.TabIndex = 13;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(110, 86);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(220, 20);
            this.cPFTextBox.TabIndex = 15;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(110, 114);
            this.rGTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(220, 20);
            this.rGTextBox.TabIndex = 17;
            // 
            // orgaoEmissorTextBox
            // 
            this.orgaoEmissorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "OrgaoEmissor", true));
            this.orgaoEmissorTextBox.Location = new System.Drawing.Point(96, 28);
            this.orgaoEmissorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orgaoEmissorTextBox.Name = "orgaoEmissorTextBox";
            this.orgaoEmissorTextBox.Size = new System.Drawing.Size(76, 20);
            this.orgaoEmissorTextBox.TabIndex = 19;
            // 
            // cartMotoristaTextBox
            // 
            this.cartMotoristaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CartMotorista", true));
            this.cartMotoristaTextBox.Location = new System.Drawing.Point(511, 28);
            this.cartMotoristaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cartMotoristaTextBox.Name = "cartMotoristaTextBox";
            this.cartMotoristaTextBox.Size = new System.Drawing.Size(76, 20);
            this.cartMotoristaTextBox.TabIndex = 21;
            // 
            // emissaoCartMotDateTimePicker
            // 
            this.emissaoCartMotDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "EmissaoCartMot", true));
            this.emissaoCartMotDateTimePicker.Location = new System.Drawing.Point(229, 28);
            this.emissaoCartMotDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.emissaoCartMotDateTimePicker.Name = "emissaoCartMotDateTimePicker";
            this.emissaoCartMotDateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.emissaoCartMotDateTimePicker.TabIndex = 23;
            // 
            // categoriaMotTextBox
            // 
            this.categoriaMotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CategoriaMot", true));
            this.categoriaMotTextBox.Location = new System.Drawing.Point(650, 27);
            this.categoriaMotTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoriaMotTextBox.Name = "categoriaMotTextBox";
            this.categoriaMotTextBox.Size = new System.Drawing.Size(64, 20);
            this.categoriaMotTextBox.TabIndex = 25;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(110, 57);
            this.dataNascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 27;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(511, 96);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(181, 20);
            this.emailTextBox.TabIndex = 29;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(301, 373);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(134, 40);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar Contratação";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.dataNascimentoDateTimePicker);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(dataNascimentoLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(celularLabel);
            this.groupBox1.Controls.Add(this.celularTextBox);
            this.groupBox1.Controls.Add(this.cPFTextBox);
            this.groupBox1.Controls.Add(cPFLabel);
            this.groupBox1.Controls.Add(this.rGTextBox);
            this.groupBox1.Controls.Add(rGLabel);
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 154);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(110, 27);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(220, 20);
            this.nomeTextBox.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cEPTextBox);
            this.groupBox2.Controls.Add(this.uFComboBox);
            this.groupBox2.Controls.Add(uFLabel);
            this.groupBox2.Controls.Add(cEPLabel);
            this.groupBox2.Controls.Add(cidadeLabel);
            this.groupBox2.Controls.Add(this.cidadeTextBox);
            this.groupBox2.Controls.Add(enderecoLabel);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Location = new System.Drawing.Point(24, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 66);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LocaLização:";
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(371, 20);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(103, 20);
            this.cEPTextBox.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.orgaoEmissorTextBox);
            this.groupBox3.Controls.Add(orgaoEmissorLabel);
            this.groupBox3.Controls.Add(this.emissaoCartMotDateTimePicker);
            this.groupBox3.Controls.Add(emissaoCartMotLabel);
            this.groupBox3.Controls.Add(this.categoriaMotTextBox);
            this.groupBox3.Controls.Add(categoriaMotLabel);
            this.groupBox3.Controls.Add(this.cartMotoristaTextBox);
            this.groupBox3.Controls.Add(cartMotoristaLabel);
            this.groupBox3.Location = new System.Drawing.Point(24, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 72);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações da CNH:";
            // 
            // clienteIDLabel
            // 
            clienteIDLabel.AutoSize = true;
            clienteIDLabel.Location = new System.Drawing.Point(282, 340);
            clienteIDLabel.Name = "clienteIDLabel";
            clienteIDLabel.Size = new System.Drawing.Size(56, 13);
            clienteIDLabel.TabIndex = 33;
            clienteIDLabel.Text = "Cliente ID:";
            // 
            // clienteIDTextBox
            // 
            this.clienteIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ClienteID", true));
            this.clienteIDTextBox.Location = new System.Drawing.Point(344, 337);
            this.clienteIDTextBox.Name = "clienteIDTextBox";
            this.clienteIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteIDTextBox.TabIndex = 34;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 452);
            this.Controls.Add(clienteIDLabel);
            this.Controls.Add(this.clienteIDTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CorretoraDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox uFComboBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.TextBox orgaoEmissorTextBox;
        private System.Windows.Forms.TextBox cartMotoristaTextBox;
        private System.Windows.Forms.DateTimePicker emissaoCartMotDateTimePicker;
        private System.Windows.Forms.TextBox categoriaMotTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.TextBox clienteIDTextBox;
    }
}