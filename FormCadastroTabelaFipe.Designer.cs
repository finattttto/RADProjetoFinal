
namespace RADProjetoFinal
{
    partial class FormCadastroTabelaFipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroTabelaFipe));
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label marcaIDLabel;
            System.Windows.Forms.Label modeloIDLabel;
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.tabelaFIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaFIPETableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.TabelaFIPETableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.tabelaFIPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaFIPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaFIPEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.marcaIDComboBox = new System.Windows.Forms.ComboBox();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelosTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ModelosTableAdapter();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.MarcasTableAdapter();
            this.modelosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modeloIDComboBox = new System.Windows.Forms.ComboBox();
            this.modelosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            anoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            marcaIDLabel = new System.Windows.Forms.Label();
            modeloIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).BeginInit();
            this.tabelaFIPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaFIPEBindingSource
            // 
            this.tabelaFIPEBindingSource.DataMember = "TabelaFIPE";
            this.tabelaFIPEBindingSource.DataSource = this.corretoraDataSet;
            // 
            // tabelaFIPETableAdapter
            // 
            this.tabelaFIPETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = this.marcasTableAdapter;
            this.tableAdapterManager.ModelosTableAdapter = this.modelosTableAdapter;
            this.tableAdapterManager.TabelaFIPETableAdapter = this.tabelaFIPETableAdapter;
            this.tableAdapterManager.UpdateOrder = RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabelaFIPEBindingNavigator
            // 
            this.tabelaFIPEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaFIPEBindingNavigator.BindingSource = this.tabelaFIPEBindingSource;
            this.tabelaFIPEBindingNavigator.CountItem = null;
            this.tabelaFIPEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaFIPEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tabelaFIPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaFIPEBindingNavigatorSaveItem});
            this.tabelaFIPEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabelaFIPEBindingNavigator.MoveFirstItem = null;
            this.tabelaFIPEBindingNavigator.MoveLastItem = null;
            this.tabelaFIPEBindingNavigator.MoveNextItem = null;
            this.tabelaFIPEBindingNavigator.MovePreviousItem = null;
            this.tabelaFIPEBindingNavigator.Name = "tabelaFIPEBindingNavigator";
            this.tabelaFIPEBindingNavigator.PositionItem = null;
            this.tabelaFIPEBindingNavigator.Size = new System.Drawing.Size(872, 27);
            this.tabelaFIPEBindingNavigator.TabIndex = 0;
            this.tabelaFIPEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tabelaFIPEBindingNavigatorSaveItem
            // 
            this.tabelaFIPEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaFIPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaFIPEBindingNavigatorSaveItem.Image")));
            this.tabelaFIPEBindingNavigatorSaveItem.Name = "tabelaFIPEBindingNavigatorSaveItem";
            this.tabelaFIPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabelaFIPEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaFIPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaFIPEBindingNavigatorSaveItem_Click);
            // 
            // tabelaFIPEDataGridView
            // 
            this.tabelaFIPEDataGridView.AllowUserToAddRows = false;
            this.tabelaFIPEDataGridView.AutoGenerateColumns = false;
            this.tabelaFIPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFIPEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabelaFIPEDataGridView.DataSource = this.tabelaFIPEBindingSource;
            this.tabelaFIPEDataGridView.Location = new System.Drawing.Point(40, 47);
            this.tabelaFIPEDataGridView.Name = "tabelaFIPEDataGridView";
            this.tabelaFIPEDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabelaFIPEDataGridView.RowTemplate.Height = 24;
            this.tabelaFIPEDataGridView.Size = new System.Drawing.Size(731, 220);
            this.tabelaFIPEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MarcaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MarcaID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ModeloID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ModeloID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(42, 392);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(37, 17);
            anoLabel.TabIndex = 2;
            anoLabel.Text = "Ano:";
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "Ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(85, 389);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 22);
            this.anoTextBox.TabIndex = 3;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(199, 392);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
            valorLabel.TabIndex = 4;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(250, 389);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 22);
            this.valorTextBox.TabIndex = 5;
            // 
            // marcaIDLabel
            // 
            marcaIDLabel.AutoSize = true;
            marcaIDLabel.Location = new System.Drawing.Point(373, 394);
            marcaIDLabel.Name = "marcaIDLabel";
            marcaIDLabel.Size = new System.Drawing.Size(68, 17);
            marcaIDLabel.TabIndex = 6;
            marcaIDLabel.Text = "Marca ID:";
            // 
            // marcaIDComboBox
            // 
            this.marcaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "MarcaID", true));
            this.marcaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaFIPEBindingSource, "MarcaID", true));
            this.marcaIDComboBox.DataSource = this.marcasBindingSource;
            this.marcaIDComboBox.DisplayMember = "Marca";
            this.marcaIDComboBox.FormattingEnabled = true;
            this.marcaIDComboBox.Location = new System.Drawing.Point(447, 391);
            this.marcaIDComboBox.Name = "marcaIDComboBox";
            this.marcaIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.marcaIDComboBox.TabIndex = 7;
            this.marcaIDComboBox.ValueMember = "ID";
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
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.corretoraDataSet;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // modelosBindingSource1
            // 
            this.modelosBindingSource1.DataMember = "Modelos";
            this.modelosBindingSource1.DataSource = this.corretoraDataSet;
            // 
            // modeloIDLabel
            // 
            modeloIDLabel.AutoSize = true;
            modeloIDLabel.Location = new System.Drawing.Point(574, 394);
            modeloIDLabel.Name = "modeloIDLabel";
            modeloIDLabel.Size = new System.Drawing.Size(75, 17);
            modeloIDLabel.TabIndex = 8;
            modeloIDLabel.Text = "Modelo ID:";
            // 
            // modeloIDComboBox
            // 
            this.modeloIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaFIPEBindingSource, "ModeloID", true));
            this.modeloIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaFIPEBindingSource, "ModeloID", true));
            this.modeloIDComboBox.DataSource = this.modelosBindingSource2;
            this.modeloIDComboBox.DisplayMember = "Modelo";
            this.modeloIDComboBox.FormattingEnabled = true;
            this.modeloIDComboBox.Location = new System.Drawing.Point(655, 391);
            this.modeloIDComboBox.Name = "modeloIDComboBox";
            this.modeloIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.modeloIDComboBox.TabIndex = 9;
            this.modeloIDComboBox.ValueMember = "ModeloID";
            // 
            // modelosBindingSource2
            // 
            this.modelosBindingSource2.DataMember = "Modelos";
            this.modelosBindingSource2.DataSource = this.corretoraDataSet;
            // 
            // FormCadastroTabelaFipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 518);
            this.Controls.Add(modeloIDLabel);
            this.Controls.Add(this.modeloIDComboBox);
            this.Controls.Add(marcaIDLabel);
            this.Controls.Add(this.marcaIDComboBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.tabelaFIPEDataGridView);
            this.Controls.Add(this.tabelaFIPEBindingNavigator);
            this.Name = "FormCadastroTabelaFipe";
            this.Text = "FormCadastroTabelaFipe";
            this.Load += new System.EventHandler(this.FormCadastroTabelaFipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).EndInit();
            this.tabelaFIPEBindingNavigator.ResumeLayout(false);
            this.tabelaFIPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource tabelaFIPEBindingSource;
        private CorretoraDataSetTableAdapters.TabelaFIPETableAdapter tabelaFIPETableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaFIPEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tabelaFIPEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaFIPEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CorretoraDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox marcaIDComboBox;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private CorretoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private System.Windows.Forms.BindingSource modelosBindingSource1;
        private System.Windows.Forms.ComboBox modeloIDComboBox;
        private System.Windows.Forms.BindingSource modelosBindingSource2;
    }
}