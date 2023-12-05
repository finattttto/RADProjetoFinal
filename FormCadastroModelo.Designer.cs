
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
            System.Windows.Forms.Label modeloIDLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label marcaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroModelo));
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelosTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ModelosTableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.marcasTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.MarcasTableAdapter();
            this.modelosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.modelosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modeloIDTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKModelosMarcaID2D27B809BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marcasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.modelosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            modeloIDLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingNavigator)).BeginInit();
            this.modelosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelosMarcaID2D27B809BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloIDLabel
            // 
            modeloIDLabel.AutoSize = true;
            modeloIDLabel.Location = new System.Drawing.Point(59, 324);
            modeloIDLabel.Name = "modeloIDLabel";
            modeloIDLabel.Size = new System.Drawing.Size(75, 17);
            modeloIDLabel.TabIndex = 1;
            modeloIDLabel.Text = "Modelo ID:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(254, 327);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 3;
            modeloLabel.Text = "Modelo:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(444, 327);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 5;
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
            this.modelosBindingNavigator.AddNewItem = null;
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
            this.modelosBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.modelosBindingNavigator.TabIndex = 0;
            this.modelosBindingNavigator.Text = "bindingNavigator1";
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
            // modeloIDTextBox
            // 
            this.modeloIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "ModeloID", true));
            this.modeloIDTextBox.Location = new System.Drawing.Point(140, 321);
            this.modeloIDTextBox.Name = "modeloIDTextBox";
            this.modeloIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.modeloIDTextBox.TabIndex = 2;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelosBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(318, 324);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 22);
            this.modeloTextBox.TabIndex = 4;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.corretoraDataSet;
            // 
            // fKModelosMarcaID2D27B809BindingSource
            // 
            this.fKModelosMarcaID2D27B809BindingSource.DataMember = "FK__Modelos__MarcaID__2D27B809";
            this.fKModelosMarcaID2D27B809BindingSource.DataSource = this.marcasBindingSource;
            // 
            // marcasBindingSource1
            // 
            this.marcasBindingSource1.DataMember = "Marcas";
            this.marcasBindingSource1.DataSource = this.corretoraDataSet;
            // 
            // marcasBindingSource2
            // 
            this.marcasBindingSource2.DataMember = "Marcas";
            this.marcasBindingSource2.DataSource = this.corretoraDataSet;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBindingSource, "Marca", true));
            this.marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelosBindingSource, "MarcaID", true));
            this.marcaComboBox.DataSource = this.marcasBindingSource3;
            this.marcaComboBox.DisplayMember = "Marca";
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(501, 324);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(121, 24);
            this.marcaComboBox.TabIndex = 6;
            this.marcaComboBox.ValueMember = "ID";
            // 
            // marcasBindingSource3
            // 
            this.marcasBindingSource3.DataMember = "Marcas";
            this.marcasBindingSource3.DataSource = this.corretoraDataSet;
            // 
            // modelosBindingSource1
            // 
            this.modelosBindingSource1.DataMember = "Modelos";
            this.modelosBindingSource1.DataSource = this.corretoraDataSet;
            // 
            // modelosDataGridView
            // 
            this.modelosDataGridView.AllowUserToAddRows = false;
            this.modelosDataGridView.AutoGenerateColumns = false;
            this.modelosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.modelosDataGridView.DataSource = this.modelosBindingSource;
            this.modelosDataGridView.Location = new System.Drawing.Point(62, 53);
            this.modelosDataGridView.Name = "modelosDataGridView";
            this.modelosDataGridView.RowHeadersWidth = 51;
            this.modelosDataGridView.RowTemplate.Height = 24;
            this.modelosDataGridView.Size = new System.Drawing.Size(692, 220);
            this.modelosDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            // FormCadastroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.modelosDataGridView);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(modeloIDLabel);
            this.Controls.Add(this.modeloIDTextBox);
            this.Controls.Add(this.modelosBindingNavigator);
            this.Name = "FormCadastroModelo";
            this.Text = "FormCadastroModelo";
            this.Load += new System.EventHandler(this.FormCadastroModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingNavigator)).EndInit();
            this.modelosBindingNavigator.ResumeLayout(false);
            this.modelosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelosMarcaID2D27B809BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton modelosBindingNavigatorSaveItem;
        private CorretoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.TextBox modeloIDTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private System.Windows.Forms.BindingSource marcasBindingSource2;
        private System.Windows.Forms.BindingSource marcasBindingSource1;
        private System.Windows.Forms.BindingSource fKModelosMarcaID2D27B809BindingSource;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.BindingSource modelosBindingSource1;
        private System.Windows.Forms.BindingSource marcasBindingSource3;
        private System.Windows.Forms.DataGridView modelosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    }
}