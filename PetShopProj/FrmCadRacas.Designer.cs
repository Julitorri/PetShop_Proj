namespace PetShopProj
{
    partial class FrmCadRacas
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
            System.Windows.Forms.Label raca_codigoLabel;
            System.Windows.Forms.Label raca_nomeLabel;
            System.Windows.Forms.Label raca_pais_origemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadRacas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raca_codigoLabel1 = new System.Windows.Forms.Label();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PetShopProj.DataSet1();
            this.raca_nomeTextBox = new System.Windows.Forms.TextBox();
            this.raca_pais_origemTextBox = new System.Windows.Forms.TextBox();
            this.racaTableAdapter = new PetShopProj.DataSet1TableAdapters.racaTableAdapter();
            this.tableAdapterManager = new PetShopProj.DataSet1TableAdapters.TableAdapterManager();
            this.racaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.racaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            raca_codigoLabel = new System.Windows.Forms.Label();
            raca_nomeLabel = new System.Windows.Forms.Label();
            raca_pais_origemLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).BeginInit();
            this.racaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // raca_codigoLabel
            // 
            raca_codigoLabel.AutoSize = true;
            raca_codigoLabel.Location = new System.Drawing.Point(12, 35);
            raca_codigoLabel.Name = "raca_codigoLabel";
            raca_codigoLabel.Size = new System.Drawing.Size(72, 21);
            raca_codigoLabel.TabIndex = 0;
            raca_codigoLabel.Text = "Código:";
            // 
            // raca_nomeLabel
            // 
            raca_nomeLabel.AutoSize = true;
            raca_nomeLabel.Location = new System.Drawing.Point(12, 65);
            raca_nomeLabel.Name = "raca_nomeLabel";
            raca_nomeLabel.Size = new System.Drawing.Size(128, 21);
            raca_nomeLabel.TabIndex = 2;
            raca_nomeLabel.Text = "Nome da raça:";
            // 
            // raca_pais_origemLabel
            // 
            raca_pais_origemLabel.AutoSize = true;
            raca_pais_origemLabel.Location = new System.Drawing.Point(12, 104);
            raca_pais_origemLabel.Name = "raca_pais_origemLabel";
            raca_pais_origemLabel.Size = new System.Drawing.Size(126, 21);
            raca_pais_origemLabel.TabIndex = 4;
            raca_pais_origemLabel.Text = "País de origem:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(raca_codigoLabel);
            this.groupBox1.Controls.Add(this.raca_codigoLabel1);
            this.groupBox1.Controls.Add(raca_nomeLabel);
            this.groupBox1.Controls.Add(this.raca_nomeTextBox);
            this.groupBox1.Controls.Add(raca_pais_origemLabel);
            this.groupBox1.Controls.Add(this.raca_pais_origemTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da raça";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // raca_codigoLabel1
            // 
            this.raca_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.raca_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_codigo", true));
            this.raca_codigoLabel1.Enabled = false;
            this.raca_codigoLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raca_codigoLabel1.Location = new System.Drawing.Point(156, 36);
            this.raca_codigoLabel1.Name = "raca_codigoLabel1";
            this.raca_codigoLabel1.Size = new System.Drawing.Size(100, 23);
            this.raca_codigoLabel1.TabIndex = 1;
            this.raca_codigoLabel1.Text = "label1";
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raca_nomeTextBox
            // 
            this.raca_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_nome", true));
            this.raca_nomeTextBox.Location = new System.Drawing.Point(156, 62);
            this.raca_nomeTextBox.Name = "raca_nomeTextBox";
            this.raca_nomeTextBox.Size = new System.Drawing.Size(100, 27);
            this.raca_nomeTextBox.TabIndex = 3;
            // 
            // raca_pais_origemTextBox
            // 
            this.raca_pais_origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_pais_origem", true));
            this.raca_pais_origemTextBox.Location = new System.Drawing.Point(156, 91);
            this.raca_pais_origemTextBox.Name = "raca_pais_origemTextBox";
            this.raca_pais_origemTextBox.Size = new System.Drawing.Size(100, 27);
            this.raca_pais_origemTextBox.TabIndex = 5;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShopProj.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // racaBindingNavigator
            // 
            this.racaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.racaBindingNavigator.BindingSource = this.racaBindingSource;
            this.racaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.racaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.racaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.racaBindingNavigatorSaveItem});
            this.racaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.racaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.racaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.racaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.racaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.racaBindingNavigator.Name = "racaBindingNavigator";
            this.racaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.racaBindingNavigator.Size = new System.Drawing.Size(714, 25);
            this.racaBindingNavigator.TabIndex = 1;
            this.racaBindingNavigator.Text = "bindingNavigator1";
            this.racaBindingNavigator.RefreshItems += new System.EventHandler(this.racaBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // racaBindingNavigatorSaveItem
            // 
            this.racaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.racaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("racaBindingNavigatorSaveItem.Image")));
            this.racaBindingNavigatorSaveItem.Name = "racaBindingNavigatorSaveItem";
            this.racaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.racaBindingNavigatorSaveItem.Text = "Save Data";
            this.racaBindingNavigatorSaveItem.Click += new System.EventHandler(this.racaBindingNavigatorSaveItem_Click);
            // 
            // FrmCadRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 561);
            this.Controls.Add(this.racaBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadRacas";
            this.Text = "FrmCadRacas";
            this.Load += new System.EventHandler(this.FrmCadRacas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).EndInit();
            this.racaBindingNavigator.ResumeLayout(false);
            this.racaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private DataSet1TableAdapters.racaTableAdapter racaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator racaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton racaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label raca_codigoLabel1;
        private System.Windows.Forms.TextBox raca_nomeTextBox;
        private System.Windows.Forms.TextBox raca_pais_origemTextBox;
    }
}