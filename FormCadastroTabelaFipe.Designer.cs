
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
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.tabelaFIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaFIPETableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.TabelaFIPETableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.marcasTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.MarcasTableAdapter();
            this.modelosTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ModelosTableAdapter();
            this.tabelaFIPEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabelaFIPEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaFIPEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).BeginInit();
            this.tabelaFIPEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
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
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // tabelaFIPEBindingNavigator
            // 
            this.tabelaFIPEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaFIPEBindingNavigator.BindingSource = this.tabelaFIPEBindingSource;
            this.tabelaFIPEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaFIPEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaFIPEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tabelaFIPEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaFIPEBindingNavigatorSaveItem});
            this.tabelaFIPEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabelaFIPEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaFIPEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaFIPEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaFIPEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaFIPEBindingNavigator.Name = "tabelaFIPEBindingNavigator";
            this.tabelaFIPEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaFIPEBindingNavigator.Size = new System.Drawing.Size(800, 27);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tabelaFIPEBindingNavigatorSaveItem
            // 
            this.tabelaFIPEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaFIPEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaFIPEBindingNavigatorSaveItem.Image")));
            this.tabelaFIPEBindingNavigatorSaveItem.Name = "tabelaFIPEBindingNavigatorSaveItem";
            this.tabelaFIPEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tabelaFIPEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaFIPEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaFIPEBindingNavigatorSaveItem_Click);
            // 
            // tabelaFIPEDataGridView
            // 
            this.tabelaFIPEDataGridView.AutoGenerateColumns = false;
            this.tabelaFIPEDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaFIPEDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabelaFIPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFIPEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tabelaFIPEDataGridView.DataSource = this.tabelaFIPEBindingSource;
            this.tabelaFIPEDataGridView.Location = new System.Drawing.Point(0, 32);
            this.tabelaFIPEDataGridView.Name = "tabelaFIPEDataGridView";
            this.tabelaFIPEDataGridView.RowHeadersWidth = 51;
            this.tabelaFIPEDataGridView.RowTemplate.Height = 24;
            this.tabelaFIPEDataGridView.Size = new System.Drawing.Size(800, 419);
            this.tabelaFIPEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MarcaID";
            this.dataGridViewTextBoxColumn1.DataSource = this.marcasBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Marca";
            this.dataGridViewTextBoxColumn1.HeaderText = "MarcaID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.corretoraDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ModeloID";
            this.dataGridViewTextBoxColumn2.DataSource = this.modelosBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "ModeloID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ModeloID";
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.corretoraDataSet;
            // 
            // FormCadastroTabelaFipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.tabelaFIPEDataGridView);
            this.Controls.Add(this.tabelaFIPEBindingNavigator);
            this.Name = "FormCadastroTabelaFipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroTabelaFipe";
            this.Load += new System.EventHandler(this.FormCadastroTabelaFipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingNavigator)).EndInit();
            this.tabelaFIPEBindingNavigator.ResumeLayout(false);
            this.tabelaFIPEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabelaFIPEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaFIPEDataGridView;
        private CorretoraDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private CorretoraDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
    }
}