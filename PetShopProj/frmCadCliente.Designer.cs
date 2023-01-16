namespace PetShopProj
{
    partial class frmCadCliente
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
            System.Windows.Forms.Label cli_codigoLabel;
            System.Windows.Forms.Label cli_nomeLabel;
            System.Windows.Forms.Label cli_celularLabel;
            System.Windows.Forms.Label cli_emailLabel;
            System.Windows.Forms.Label cli_cpfLabel;
            System.Windows.Forms.Label cli_enderecoLabel;
            System.Windows.Forms.Label cli_fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfoto = new System.Windows.Forms.Button();
            this.cli_codigoLabel1 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PetShopProj.DataSet1();
            this.cli_nomeTextBox = new System.Windows.Forms.TextBox();
            this.cli_celularTextBox = new System.Windows.Forms.TextBox();
            this.cli_emailTextBox = new System.Windows.Forms.TextBox();
            this.cli_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cli_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.clienteTableAdapter = new PetShopProj.DataSet1TableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new PetShopProj.DataSet1TableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            cli_codigoLabel = new System.Windows.Forms.Label();
            cli_nomeLabel = new System.Windows.Forms.Label();
            cli_celularLabel = new System.Windows.Forms.Label();
            cli_emailLabel = new System.Windows.Forms.Label();
            cli_cpfLabel = new System.Windows.Forms.Label();
            cli_enderecoLabel = new System.Windows.Forms.Label();
            cli_fotoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cli_codigoLabel
            // 
            cli_codigoLabel.AutoSize = true;
            cli_codigoLabel.Location = new System.Drawing.Point(23, 57);
            cli_codigoLabel.Name = "cli_codigoLabel";
            cli_codigoLabel.Size = new System.Drawing.Size(62, 17);
            cli_codigoLabel.TabIndex = 0;
            cli_codigoLabel.Text = "Código:";
            // 
            // cli_nomeLabel
            // 
            cli_nomeLabel.AutoSize = true;
            cli_nomeLabel.Location = new System.Drawing.Point(23, 93);
            cli_nomeLabel.Name = "cli_nomeLabel";
            cli_nomeLabel.Size = new System.Drawing.Size(52, 17);
            cli_nomeLabel.TabIndex = 2;
            cli_nomeLabel.Text = "Nome:";
            // 
            // cli_celularLabel
            // 
            cli_celularLabel.AutoSize = true;
            cli_celularLabel.Location = new System.Drawing.Point(23, 126);
            cli_celularLabel.Name = "cli_celularLabel";
            cli_celularLabel.Size = new System.Drawing.Size(77, 17);
            cli_celularLabel.TabIndex = 4;
            cli_celularLabel.Text = "Telemóvel:";
            // 
            // cli_emailLabel
            // 
            cli_emailLabel.AutoSize = true;
            cli_emailLabel.Location = new System.Drawing.Point(23, 165);
            cli_emailLabel.Name = "cli_emailLabel";
            cli_emailLabel.Size = new System.Drawing.Size(51, 17);
            cli_emailLabel.TabIndex = 6;
            cli_emailLabel.Text = "E-mail:";
            // 
            // cli_cpfLabel
            // 
            cli_cpfLabel.AutoSize = true;
            cli_cpfLabel.Location = new System.Drawing.Point(23, 204);
            cli_cpfLabel.Name = "cli_cpfLabel";
            cli_cpfLabel.Size = new System.Drawing.Size(31, 17);
            cli_cpfLabel.TabIndex = 8;
            cli_cpfLabel.Text = "NIF:";
            // 
            // cli_enderecoLabel
            // 
            cli_enderecoLabel.AutoSize = true;
            cli_enderecoLabel.Location = new System.Drawing.Point(23, 243);
            cli_enderecoLabel.Name = "cli_enderecoLabel";
            cli_enderecoLabel.Size = new System.Drawing.Size(63, 17);
            cli_enderecoLabel.TabIndex = 10;
            cli_enderecoLabel.Text = "Morada:";
            // 
            // cli_fotoLabel
            // 
            cli_fotoLabel.AutoSize = true;
            cli_fotoLabel.Location = new System.Drawing.Point(23, 279);
            cli_fotoLabel.Name = "cli_fotoLabel";
            cli_fotoLabel.Size = new System.Drawing.Size(41, 17);
            cli_fotoLabel.TabIndex = 12;
            cli_fotoLabel.Text = "Foto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfoto);
            this.groupBox1.Controls.Add(cli_codigoLabel);
            this.groupBox1.Controls.Add(this.cli_codigoLabel1);
            this.groupBox1.Controls.Add(cli_nomeLabel);
            this.groupBox1.Controls.Add(this.cli_nomeTextBox);
            this.groupBox1.Controls.Add(cli_celularLabel);
            this.groupBox1.Controls.Add(this.cli_celularTextBox);
            this.groupBox1.Controls.Add(cli_emailLabel);
            this.groupBox1.Controls.Add(this.cli_emailTextBox);
            this.groupBox1.Controls.Add(cli_cpfLabel);
            this.groupBox1.Controls.Add(this.cli_cpfMaskedTextBox);
            this.groupBox1.Controls.Add(cli_enderecoLabel);
            this.groupBox1.Controls.Add(this.cli_enderecoTextBox);
            this.groupBox1.Controls.Add(cli_fotoLabel);
            this.groupBox1.Controls.Add(this.cli_fotoPictureBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(600, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnfoto
            // 
            this.btnfoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfoto.BackgroundImage")));
            this.btnfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfoto.Location = new System.Drawing.Point(311, 410);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(37, 34);
            this.btnfoto.TabIndex = 14;
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // cli_codigoLabel1
            // 
            this.cli_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cli_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_codigo", true));
            this.cli_codigoLabel1.Location = new System.Drawing.Point(140, 56);
            this.cli_codigoLabel1.Name = "cli_codigoLabel1";
            this.cli_codigoLabel1.Size = new System.Drawing.Size(104, 23);
            this.cli_codigoLabel1.TabIndex = 1;
            this.cli_codigoLabel1.Text = "label1";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cli_nomeTextBox
            // 
            this.cli_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_nome", true));
            this.cli_nomeTextBox.Location = new System.Drawing.Point(140, 87);
            this.cli_nomeTextBox.Name = "cli_nomeTextBox";
            this.cli_nomeTextBox.Size = new System.Drawing.Size(265, 23);
            this.cli_nomeTextBox.TabIndex = 3;
            // 
            // cli_celularTextBox
            // 
            this.cli_celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_celular", true));
            this.cli_celularTextBox.Location = new System.Drawing.Point(140, 116);
            this.cli_celularTextBox.Name = "cli_celularTextBox";
            this.cli_celularTextBox.Size = new System.Drawing.Size(202, 23);
            this.cli_celularTextBox.TabIndex = 5;
            // 
            // cli_emailTextBox
            // 
            this.cli_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_email", true));
            this.cli_emailTextBox.Location = new System.Drawing.Point(140, 159);
            this.cli_emailTextBox.Name = "cli_emailTextBox";
            this.cli_emailTextBox.Size = new System.Drawing.Size(266, 23);
            this.cli_emailTextBox.TabIndex = 7;
            // 
            // cli_cpfMaskedTextBox
            // 
            this.cli_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_cpf", true));
            this.cli_cpfMaskedTextBox.Location = new System.Drawing.Point(140, 198);
            this.cli_cpfMaskedTextBox.Mask = "000000000";
            this.cli_cpfMaskedTextBox.Name = "cli_cpfMaskedTextBox";
            this.cli_cpfMaskedTextBox.Size = new System.Drawing.Size(203, 23);
            this.cli_cpfMaskedTextBox.TabIndex = 9;
            // 
            // cli_enderecoTextBox
            // 
            this.cli_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_endereco", true));
            this.cli_enderecoTextBox.Location = new System.Drawing.Point(140, 240);
            this.cli_enderecoTextBox.Name = "cli_enderecoTextBox";
            this.cli_enderecoTextBox.Size = new System.Drawing.Size(266, 23);
            this.cli_enderecoTextBox.TabIndex = 11;
            // 
            // cli_fotoPictureBox
            // 
            this.cli_fotoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cli_fotoPictureBox.BackgroundImage")));
            this.cli_fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cli_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "cli_foto", true));
            this.cli_fotoPictureBox.Location = new System.Drawing.Point(140, 279);
            this.cli_fotoPictureBox.Name = "cli_fotoPictureBox";
            this.cli_fotoPictureBox.Size = new System.Drawing.Size(165, 165);
            this.cli_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cli_fotoPictureBox.TabIndex = 13;
            this.cli_fotoPictureBox.TabStop = false;
            this.cli_fotoPictureBox.Click += new System.EventHandler(this.cli_fotoPictureBox_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShopProj.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clienteBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar,
            this.toolStripButton1});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(1040, 39);
            this.clienteBindingNavigator.TabIndex = 1;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.clienteBindingNavigatorSaveItem.Text = "Save Data";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.ToolTipText = "Cancel";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.ToolTipText = "Edit";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton1.Text = "Localizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Escolha uma foto";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 1005);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCadCliente";
            this.Text = "frmCadCliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cli_codigoLabel1;
        private System.Windows.Forms.TextBox cli_nomeTextBox;
        private System.Windows.Forms.TextBox cli_celularTextBox;
        private System.Windows.Forms.TextBox cli_emailTextBox;
        private System.Windows.Forms.MaskedTextBox cli_cpfMaskedTextBox;
        private System.Windows.Forms.TextBox cli_enderecoTextBox;
        private System.Windows.Forms.PictureBox cli_fotoPictureBox;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}