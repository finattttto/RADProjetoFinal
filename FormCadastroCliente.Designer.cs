
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
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(28, 79);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(73, 17);
            enderecoLabel.TabIndex = 0;
            enderecoLabel.Text = "Endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(137, 79);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 22);
            this.enderecoTextBox.TabIndex = 1;
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(28, 126);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(39, 17);
            cEPLabel.TabIndex = 2;
            cEPLabel.Text = "CEP:";
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(137, 126);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(100, 22);
            this.cEPTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(28, 41);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(137, 41);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeTextBox.TabIndex = 5;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(28, 163);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(56, 17);
            cidadeLabel.TabIndex = 6;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(137, 163);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cidadeTextBox.TabIndex = 7;
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(28, 268);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(30, 17);
            uFLabel.TabIndex = 8;
            uFLabel.Text = "UF:";
            // 
            // uFComboBox
            // 
            this.uFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "UF", true));
            this.uFComboBox.FormattingEnabled = true;
            this.uFComboBox.Location = new System.Drawing.Point(137, 268);
            this.uFComboBox.Name = "uFComboBox";
            this.uFComboBox.Size = new System.Drawing.Size(121, 24);
            this.uFComboBox.TabIndex = 9;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(28, 220);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(68, 17);
            telefoneLabel.TabIndex = 10;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(137, 220);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.telefoneTextBox.TabIndex = 11;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(362, 39);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(56, 17);
            celularLabel.TabIndex = 12;
            celularLabel.Text = "Celular:";
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(424, 36);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(100, 22);
            this.celularTextBox.TabIndex = 13;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(380, 79);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(38, 17);
            cPFLabel.TabIndex = 14;
            cPFLabel.Text = "CPF:";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(424, 76);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(100, 22);
            this.cPFTextBox.TabIndex = 15;
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(385, 124);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(33, 17);
            rGLabel.TabIndex = 16;
            rGLabel.Text = "RG:";
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(424, 121);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(100, 22);
            this.rGTextBox.TabIndex = 17;
            // 
            // orgaoEmissorLabel
            // 
            orgaoEmissorLabel.AutoSize = true;
            orgaoEmissorLabel.Location = new System.Drawing.Point(312, 166);
            orgaoEmissorLabel.Name = "orgaoEmissorLabel";
            orgaoEmissorLabel.Size = new System.Drawing.Size(106, 17);
            orgaoEmissorLabel.TabIndex = 18;
            orgaoEmissorLabel.Text = "Orgao Emissor:";
            // 
            // orgaoEmissorTextBox
            // 
            this.orgaoEmissorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "OrgaoEmissor", true));
            this.orgaoEmissorTextBox.Location = new System.Drawing.Point(424, 163);
            this.orgaoEmissorTextBox.Name = "orgaoEmissorTextBox";
            this.orgaoEmissorTextBox.Size = new System.Drawing.Size(100, 22);
            this.orgaoEmissorTextBox.TabIndex = 19;
            // 
            // cartMotoristaLabel
            // 
            cartMotoristaLabel.AutoSize = true;
            cartMotoristaLabel.Location = new System.Drawing.Point(318, 218);
            cartMotoristaLabel.Name = "cartMotoristaLabel";
            cartMotoristaLabel.Size = new System.Drawing.Size(100, 17);
            cartMotoristaLabel.TabIndex = 20;
            cartMotoristaLabel.Text = "Cart Motorista:";
            // 
            // cartMotoristaTextBox
            // 
            this.cartMotoristaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CartMotorista", true));
            this.cartMotoristaTextBox.Location = new System.Drawing.Point(424, 215);
            this.cartMotoristaTextBox.Name = "cartMotoristaTextBox";
            this.cartMotoristaTextBox.Size = new System.Drawing.Size(100, 22);
            this.cartMotoristaTextBox.TabIndex = 21;
            // 
            // emissaoCartMotLabel
            // 
            emissaoCartMotLabel.AutoSize = true;
            emissaoCartMotLabel.Location = new System.Drawing.Point(296, 267);
            emissaoCartMotLabel.Name = "emissaoCartMotLabel";
            emissaoCartMotLabel.Size = new System.Drawing.Size(122, 17);
            emissaoCartMotLabel.TabIndex = 22;
            emissaoCartMotLabel.Text = "Emissao Cart Mot:";
            // 
            // emissaoCartMotDateTimePicker
            // 
            this.emissaoCartMotDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "EmissaoCartMot", true));
            this.emissaoCartMotDateTimePicker.Location = new System.Drawing.Point(424, 263);
            this.emissaoCartMotDateTimePicker.Name = "emissaoCartMotDateTimePicker";
            this.emissaoCartMotDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.emissaoCartMotDateTimePicker.TabIndex = 23;
            // 
            // categoriaMotLabel
            // 
            categoriaMotLabel.AutoSize = true;
            categoriaMotLabel.Location = new System.Drawing.Point(318, 310);
            categoriaMotLabel.Name = "categoriaMotLabel";
            categoriaMotLabel.Size = new System.Drawing.Size(100, 17);
            categoriaMotLabel.TabIndex = 24;
            categoriaMotLabel.Text = "Categoria Mot:";
            // 
            // categoriaMotTextBox
            // 
            this.categoriaMotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CategoriaMot", true));
            this.categoriaMotTextBox.Location = new System.Drawing.Point(424, 307);
            this.categoriaMotTextBox.Name = "categoriaMotTextBox";
            this.categoriaMotTextBox.Size = new System.Drawing.Size(100, 22);
            this.categoriaMotTextBox.TabIndex = 25;
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(298, 366);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(120, 17);
            dataNascimentoLabel.TabIndex = 26;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(424, 362);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataNascimentoDateTimePicker.TabIndex = 27;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(85, 313);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 28;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(137, 310);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 29;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(categoriaMotLabel);
            this.Controls.Add(this.categoriaMotTextBox);
            this.Controls.Add(emissaoCartMotLabel);
            this.Controls.Add(this.emissaoCartMotDateTimePicker);
            this.Controls.Add(cartMotoristaLabel);
            this.Controls.Add(this.cartMotoristaTextBox);
            this.Controls.Add(orgaoEmissorLabel);
            this.Controls.Add(this.orgaoEmissorTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(uFLabel);
            this.Controls.Add(this.uFComboBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CorretoraDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
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
    }
}