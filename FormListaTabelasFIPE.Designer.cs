
namespace RADProjetoFinal
{
    partial class FormListaTabelasFIPE
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
            this.viewTabelasFIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTabelasFIPETableAdapter = new RADProjetoFinal.CorretoraDataSetTableAdapters.ViewTabelasFIPETableAdapter();
            this.tableAdapterManager = new RADProjetoFinal.CorretoraDataSetTableAdapters.TableAdapterManager();
            this.viewTabelasFIPEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisaMarca = new System.Windows.Forms.Label();
            this.txtPesquisaMarcas = new System.Windows.Forms.TextBox();
            this.txtPesquisaModelo = new System.Windows.Forms.TextBox();
            this.lblPesquisarModelo = new System.Windows.Forms.Label();
            this.btnAbrirCRUD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelasFIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelasFIPEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // corretoraDataSet
            // 
            this.corretoraDataSet.DataSetName = "CorretoraDataSet";
            this.corretoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewTabelasFIPEBindingSource
            // 
            this.viewTabelasFIPEBindingSource.DataMember = "ViewTabelasFIPE";
            this.viewTabelasFIPEBindingSource.DataSource = this.corretoraDataSet;
            // 
            // viewTabelasFIPETableAdapter
            // 
            this.viewTabelasFIPETableAdapter.ClearBeforeFill = true;
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
            // viewTabelasFIPEDataGridView
            // 
            this.viewTabelasFIPEDataGridView.AutoGenerateColumns = false;
            this.viewTabelasFIPEDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewTabelasFIPEDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewTabelasFIPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTabelasFIPEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.viewTabelasFIPEDataGridView.DataSource = this.viewTabelasFIPEBindingSource;
            this.viewTabelasFIPEDataGridView.Location = new System.Drawing.Point(12, 125);
            this.viewTabelasFIPEDataGridView.Name = "viewTabelasFIPEDataGridView";
            this.viewTabelasFIPEDataGridView.RowHeadersWidth = 51;
            this.viewTabelasFIPEDataGridView.RowTemplate.Height = 24;
            this.viewTabelasFIPEDataGridView.Size = new System.Drawing.Size(776, 266);
            this.viewTabelasFIPEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Modelo";
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
            // lblPesquisaMarca
            // 
            this.lblPesquisaMarca.AutoSize = true;
            this.lblPesquisaMarca.Location = new System.Drawing.Point(12, 52);
            this.lblPesquisaMarca.Name = "lblPesquisaMarca";
            this.lblPesquisaMarca.Size = new System.Drawing.Size(143, 17);
            this.lblPesquisaMarca.TabIndex = 2;
            this.lblPesquisaMarca.Text = "Pesquisar por Marca:";
            // 
            // txtPesquisaMarcas
            // 
            this.txtPesquisaMarcas.Location = new System.Drawing.Point(170, 52);
            this.txtPesquisaMarcas.Name = "txtPesquisaMarcas";
            this.txtPesquisaMarcas.Size = new System.Drawing.Size(121, 22);
            this.txtPesquisaMarcas.TabIndex = 3;
            this.txtPesquisaMarcas.TextChanged += new System.EventHandler(this.txtPesquisaMarcas_TextChanged);
            // 
            // txtPesquisaModelo
            // 
            this.txtPesquisaModelo.Location = new System.Drawing.Point(170, 93);
            this.txtPesquisaModelo.Name = "txtPesquisaModelo";
            this.txtPesquisaModelo.Size = new System.Drawing.Size(121, 22);
            this.txtPesquisaModelo.TabIndex = 4;
            this.txtPesquisaModelo.TextChanged += new System.EventHandler(this.txtPesquisaModelo_TextChanged);
            // 
            // lblPesquisarModelo
            // 
            this.lblPesquisarModelo.AutoSize = true;
            this.lblPesquisarModelo.Location = new System.Drawing.Point(14, 93);
            this.lblPesquisarModelo.Name = "lblPesquisarModelo";
            this.lblPesquisarModelo.Size = new System.Drawing.Size(150, 17);
            this.lblPesquisarModelo.TabIndex = 5;
            this.lblPesquisarModelo.Text = "Pesquisar por Modelo:";
            // 
            // btnAbrirCRUD
            // 
            this.btnAbrirCRUD.Location = new System.Drawing.Point(184, 397);
            this.btnAbrirCRUD.Name = "btnAbrirCRUD";
            this.btnAbrirCRUD.Size = new System.Drawing.Size(406, 41);
            this.btnAbrirCRUD.TabIndex = 6;
            this.btnAbrirCRUD.Text = "Alterar Ou Adicionar Cadastros";
            this.btnAbrirCRUD.UseVisualStyleBackColor = true;
            this.btnAbrirCRUD.Click += new System.EventHandler(this.btnAbrirCRUD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tabelas Fipe";
            // 
            // FormListaTabelasFIPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirCRUD);
            this.Controls.Add(this.lblPesquisarModelo);
            this.Controls.Add(this.txtPesquisaModelo);
            this.Controls.Add(this.txtPesquisaMarcas);
            this.Controls.Add(this.lblPesquisaMarca);
            this.Controls.Add(this.viewTabelasFIPEDataGridView);
            this.Name = "FormListaTabelasFIPE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaTabelasFIPE";
            this.Load += new System.EventHandler(this.FormListaTabelasFIPE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelasFIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelasFIPEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CorretoraDataSet corretoraDataSet;
        private System.Windows.Forms.BindingSource viewTabelasFIPEBindingSource;
        private CorretoraDataSetTableAdapters.ViewTabelasFIPETableAdapter viewTabelasFIPETableAdapter;
        private CorretoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView viewTabelasFIPEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblPesquisaMarca;
        private System.Windows.Forms.TextBox txtPesquisaMarcas;
        private System.Windows.Forms.TextBox txtPesquisaModelo;
        private System.Windows.Forms.Label lblPesquisarModelo;
        private System.Windows.Forms.Button btnAbrirCRUD;
        private System.Windows.Forms.Label label1;
    }
}