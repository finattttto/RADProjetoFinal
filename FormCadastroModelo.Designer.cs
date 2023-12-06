namespace RADProjetoFinal
{
    partial class FormCadastroModelo
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
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label modeloIDLabel;
            System.Windows.Forms.Label marcaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroModelo));
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelosTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ModelosTableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.marcasTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.MarcasTableAdapter();
            this.modelosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.modelosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.modeloIDTextBox = new System.Windows.Forms.TextBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.corretoraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewModelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewModelosTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ViewModelosTableAdapter();
            this.modelosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            modeloLabel = new System.Windows.Forms.Label();
            modeloIDLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingNavigator)).BeginInit();
            this.modelosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(358, 395);
            modeloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 2;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloIDLabel
            // 
            modeloIDLabel.AutoSize = true;
            modeloIDLabel.Location = new System.Drawing.Point(101, 395);
            modeloIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeloIDLabel.Name = "modeloIDLabel";
            modeloIDLabel.Size = new System.Drawing.Size(75, 17);
            modeloIDLabel.TabIndex = 4;
            modeloIDLabel.Text = "Modelo ID:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(598, 391);
            marcaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 6;
            marcaLabel.Text = "Marca:";
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = this.marcasTableAdapter;
            this.tableAdapterManager.ModelosTableAdapter = this.modelosTableAdapter;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // modelosBindingNavigator
            // 
            this.modelosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.modelosBindingNavigator.BindingSource = this.modelosBindingSource;
            this.modelosBindingNavigator.CountItem = null;
            this.modelosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.modelosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modelosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.modelosBindingNavigatorSaveItem});
            this.modelosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.modelosBindingNavigator.MoveFirstItem = null;
            this.modelosBindingNavigator.MoveLastItem = null;
            this.modelosBindingNavigator.MoveNextItem = null;
            this.modelosBindingNavigator.MovePreviousItem = null;
            this.modelosBindingNavigator.Name = "modelosBindingNavigator";
            this.modelosBindingNavigator.PositionItem = null;
            this.modelosBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.modelosBindingNavigator.TabIndex = 0;
            this.modelosBindingNavigator.Text = "bindingNavigator1";
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
            // modelosBindingNavigatorSaveItem
            // 
            this.modelosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modelosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("modelosBindingNavigatorSaveItem.Image")));
            this.modelosBindingNavigatorSaveItem.Name = "modelosBindingNavigatorSaveItem";
            this.modelosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.modelosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.modelosBindingNavigatorSaveItem.Click += new System.EventHandler(this.modelosBindingNavigatorSaveItem_Click);
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(426, 391);
            this.modeloTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(132, 22);
            this.modeloTextBox.TabIndex = 3;
            // 
            // modeloIDTextBox
            // 
            this.modeloIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "ModeloID", true));
            this.modeloIDTextBox.Location = new System.Drawing.Point(188, 391);
            this.modeloIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeloIDTextBox.Name = "modeloIDTextBox";
            this.modeloIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.modeloIDTextBox.TabIndex = 5;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.corretoraDataSet;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBindingSource, "Marca", true));
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelosBindingSource, "MarcaID", true));
            this.marcaComboBox.DataSource = this.marcasBindingSource1;
            this.marcaComboBox.DisplayMember = "Marca";
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(659, 387);
            this.marcaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(160, 24);
            this.marcaComboBox.TabIndex = 7;
            this.marcaComboBox.ValueMember = "ID";
            // 
            // marcasBindingSource1
            // 
            this.marcasBindingSource1.DataMember = "Marcas";
            this.marcasBindingSource1.DataSource = this.corretoraDataSetBindingSource;
            // 
            // corretoraDataSetBindingSource
            // 
            this.corretoraDataSetBindingSource.DataSource = this.corretoraDataSet;
            this.corretoraDataSetBindingSource.Position = 0;
            // 
            // viewModelosBindingSource
            // 
            this.viewModelosBindingSource.DataMember = "ViewModelos";
            this.viewModelosBindingSource.DataSource = this.corretoraDataSet;
            // 
            // viewModelosTableAdapter
            // 
            this.viewModelosTableAdapter.ClearBeforeFill = true;
            // 
            // modelosDataGridView
            // 
            this.modelosDataGridView.AutoGenerateColumns = false;
            this.modelosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modelosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.modelosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1});
            this.modelosDataGridView.DataSource = this.modelosBindingSource;
            this.modelosDataGridView.Location = new System.Drawing.Point(12, 30);
            this.modelosDataGridView.Name = "modelosDataGridView";
            this.modelosDataGridView.RowHeadersWidth = 51;
            this.modelosDataGridView.RowTemplate.Height = 24;
            this.modelosDataGridView.Size = new System.Drawing.Size(1043, 300);
            this.modelosDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ModeloID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ModeloID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MarcaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MarcaID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FormCadastroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 565);
            this.Controls.Add(this.modelosDataGridView);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(modeloIDLabel);
            this.Controls.Add(this.modeloIDTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.modelosBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastroModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroModelo";
            this.Load += new System.EventHandler(this.FormCadastroModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingNavigator)).EndInit();
            this.modelosBindingNavigator.ResumeLayout(false);
            this.modelosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private CorretoraDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator modelosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton modelosBindingNavigatorSaveItem;
        private CorretoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox modeloIDTextBox;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.BindingSource marcasBindingSource1;
        private System.Windows.Forms.BindingSource corretoraDataSetBindingSource;
        private System.Windows.Forms.BindingSource viewModelosBindingSource;
        private CorretoraDataSetTableAdapters.ViewModelosTableAdapter viewModelosTableAdapter;
        private System.Windows.Forms.DataGridView modelosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}