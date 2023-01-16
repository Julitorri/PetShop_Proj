namespace PetShopProj
{
    partial class frmLocalizarAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.view_AnimaisClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PetShopProj.DataSet1();
            this.view_AnimaisClientesTableAdapter = new PetShopProj.DataSet1TableAdapters.View_AnimaisClientesTableAdapter();
            this.tableAdapterManager = new PetShopProj.DataSet1TableAdapters.TableAdapterManager();
            this.view_AnimaisClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Animal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(488, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(12, 45);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(374, 22);
            this.textNome.TabIndex = 6;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // view_AnimaisClientesBindingSource
            // 
            this.view_AnimaisClientesBindingSource.DataMember = "View_AnimaisClientes";
            this.view_AnimaisClientesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_AnimaisClientesTableAdapter
            // 
            this.view_AnimaisClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShopProj.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_AnimaisClientesDataGridView
            // 
            this.view_AnimaisClientesDataGridView.AllowUserToAddRows = false;
            this.view_AnimaisClientesDataGridView.AllowUserToDeleteRows = false;
            this.view_AnimaisClientesDataGridView.AutoGenerateColumns = false;
            this.view_AnimaisClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_AnimaisClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.view_AnimaisClientesDataGridView.DataSource = this.view_AnimaisClientesBindingSource;
            this.view_AnimaisClientesDataGridView.Location = new System.Drawing.Point(16, 73);
            this.view_AnimaisClientesDataGridView.Name = "view_AnimaisClientesDataGridView";
            this.view_AnimaisClientesDataGridView.ReadOnly = true;
            this.view_AnimaisClientesDataGridView.Size = new System.Drawing.Size(547, 152);
            this.view_AnimaisClientesDataGridView.TabIndex = 8;
            this.view_AnimaisClientesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_AnimaisClientesDataGridView_CellDoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ani_codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ani_nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Animal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ani_agressivo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Agressivo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ani_alergia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Alergia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cli_nome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frmLocalizarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 609);
            this.ControlBox = false;
            this.Controls.Add(this.view_AnimaisClientesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLocalizarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Localizar Animal";
            this.Load += new System.EventHandler(this.frmLocalizarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textNome;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource view_AnimaisClientesBindingSource;
        private DataSet1TableAdapters.View_AnimaisClientesTableAdapter view_AnimaisClientesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_AnimaisClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}