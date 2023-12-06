
namespace RADProjetoFinal
{
    partial class FormListaModelo
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
            this.corretoraDataSet = new RADProjetoFinal.CorretoraDataSet();
            this.viewModelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewModelosTableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ViewModelosTableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.viewModelosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.Label();
            this.txtMarcaPesquisar = new System.Windows.Forms.TextBox();
            this.btnAbrirCRUD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewModelosDataGridView
            // 
            this.viewModelosDataGridView.AutoGenerateColumns = false;
            this.viewModelosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewModelosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewModelosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewModelosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.viewModelosDataGridView.DataSource = this.viewModelosBindingSource;
            this.viewModelosDataGridView.Location = new System.Drawing.Point(12, 108);
            this.viewModelosDataGridView.Name = "viewModelosDataGridView";
            this.viewModelosDataGridView.RowHeadersWidth = 51;
            this.viewModelosDataGridView.RowTemplate.Height = 24;
            this.viewModelosDataGridView.Size = new System.Drawing.Size(776, 323);
            this.viewModelosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ModeloID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ModeloID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
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
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(12, 74);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(143, 17);
            this.Marca.TabIndex = 2;
            this.Marca.Text = "Pesquisar por Marca:";
            // 
            // txtMarcaPesquisar
            // 
            this.txtMarcaPesquisar.Location = new System.Drawing.Point(161, 74);
            this.txtMarcaPesquisar.Name = "txtMarcaPesquisar";
            this.txtMarcaPesquisar.Size = new System.Drawing.Size(100, 22);
            this.txtMarcaPesquisar.TabIndex = 3;
            this.txtMarcaPesquisar.TextChanged += new System.EventHandler(this.txtMarcaPesquisar_TextChanged);
            // 
            // btnAbrirCRUD
            // 
            this.btnAbrirCRUD.Location = new System.Drawing.Point(242, 437);
            this.btnAbrirCRUD.Name = "btnAbrirCRUD";
            this.btnAbrirCRUD.Size = new System.Drawing.Size(264, 41);
            this.btnAbrirCRUD.TabIndex = 4;
            this.btnAbrirCRUD.Text = "Alterar ou Adicionar Cadastros";
            this.btnAbrirCRUD.UseVisualStyleBackColor = true;
            this.btnAbrirCRUD.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modelos";
            // 
            // FormListaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirCRUD);
            this.Controls.Add(this.txtMarcaPesquisar);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.viewModelosDataGridView);
            this.Name = "FormListaModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaModelo";
            this.Load += new System.EventHandler(this.FormListaModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource viewModelosBindingSource;
        private CorretoraDataSetTableAdapters.ViewModelosTableAdapter viewModelosTableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView viewModelosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.TextBox txtMarcaPesquisar;
        private System.Windows.Forms.Button btnAbrirCRUD;
        private System.Windows.Forms.Label label1;
    }
}