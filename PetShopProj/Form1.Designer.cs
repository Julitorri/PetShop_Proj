namespace PetShopProj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelleft = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LblAgendado = new System.Windows.Forms.Label();
            this.lblAndamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pansel = new System.Windows.Forms.Panel();
            this.btnagendamentos = new System.Windows.Forms.Button();
            this.btnservicos = new System.Windows.Forms.Button();
            this.btnanimais = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnracas = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.dataSet1 = new PetShopProj.DataSet1();
            this.view_DetalhesAgendamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DetalhesAgendamentosTableAdapter = new PetShopProj.DataSet1TableAdapters.View_DetalhesAgendamentosTableAdapter();
            this.tableAdapterManager = new PetShopProj.DataSet1TableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.agendamento_servicosTableAdapter1 = new PetShopProj.DataSet1TableAdapters.agendamento_servicosTableAdapter();
            this.panelleft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.CadetBlue;
            this.panelleft.Controls.Add(this.groupBox1);
            this.panelleft.Controls.Add(this.pansel);
            this.panelleft.Controls.Add(this.btnagendamentos);
            this.panelleft.Controls.Add(this.btnservicos);
            this.panelleft.Controls.Add(this.btnanimais);
            this.panelleft.Controls.Add(this.btnclientes);
            this.panelleft.Controls.Add(this.btnracas);
            this.panelleft.Controls.Add(this.btninicio);
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Margin = new System.Windows.Forms.Padding(2);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(155, 623);
            this.panelleft.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.LblAgendado);
            this.groupBox1.Controls.Add(this.lblAndamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(11, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(26, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Detalhes...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblAgendado
            // 
            this.LblAgendado.AutoSize = true;
            this.LblAgendado.Location = new System.Drawing.Point(95, 59);
            this.LblAgendado.Name = "LblAgendado";
            this.LblAgendado.Size = new System.Drawing.Size(13, 16);
            this.LblAgendado.TabIndex = 3;
            this.LblAgendado.Text = "0";
            // 
            // lblAndamento
            // 
            this.lblAndamento.AutoSize = true;
            this.lblAndamento.Location = new System.Drawing.Point(95, 31);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(13, 16);
            this.lblAndamento.TabIndex = 2;
            this.lblAndamento.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agendado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Em andamento:";
            // 
            // pansel
            // 
            this.pansel.BackColor = System.Drawing.Color.RoyalBlue;
            this.pansel.Location = new System.Drawing.Point(3, 86);
            this.pansel.Margin = new System.Windows.Forms.Padding(2);
            this.pansel.Name = "pansel";
            this.pansel.Size = new System.Drawing.Size(6, 39);
            this.pansel.TabIndex = 6;
            // 
            // btnagendamentos
            // 
            this.btnagendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagendamentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagendamentos.ForeColor = System.Drawing.Color.White;
            this.btnagendamentos.Location = new System.Drawing.Point(8, 385);
            this.btnagendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnagendamentos.Name = "btnagendamentos";
            this.btnagendamentos.Size = new System.Drawing.Size(124, 40);
            this.btnagendamentos.TabIndex = 5;
            this.btnagendamentos.Text = "Agendamentos";
            this.btnagendamentos.UseVisualStyleBackColor = true;
            this.btnagendamentos.Click += new System.EventHandler(this.btnagendamentos_Click);
            // 
            // btnservicos
            // 
            this.btnservicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnservicos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservicos.ForeColor = System.Drawing.Color.White;
            this.btnservicos.Location = new System.Drawing.Point(8, 323);
            this.btnservicos.Margin = new System.Windows.Forms.Padding(2);
            this.btnservicos.Name = "btnservicos";
            this.btnservicos.Size = new System.Drawing.Size(124, 40);
            this.btnservicos.TabIndex = 4;
            this.btnservicos.Text = "Serviços";
            this.btnservicos.UseVisualStyleBackColor = true;
            this.btnservicos.Click += new System.EventHandler(this.btnservicos_Click);
            // 
            // btnanimais
            // 
            this.btnanimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanimais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanimais.ForeColor = System.Drawing.Color.White;
            this.btnanimais.Location = new System.Drawing.Point(8, 262);
            this.btnanimais.Margin = new System.Windows.Forms.Padding(2);
            this.btnanimais.Name = "btnanimais";
            this.btnanimais.Size = new System.Drawing.Size(124, 40);
            this.btnanimais.TabIndex = 3;
            this.btnanimais.Text = "Animais";
            this.btnanimais.UseVisualStyleBackColor = true;
            this.btnanimais.Click += new System.EventHandler(this.btnanimais_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Location = new System.Drawing.Point(8, 148);
            this.btnclientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(124, 40);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnracas
            // 
            this.btnracas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnracas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnracas.ForeColor = System.Drawing.Color.White;
            this.btnracas.Location = new System.Drawing.Point(8, 204);
            this.btnracas.Margin = new System.Windows.Forms.Padding(2);
            this.btnracas.Name = "btnracas";
            this.btnracas.Size = new System.Drawing.Size(124, 40);
            this.btnracas.TabIndex = 1;
            this.btnracas.Text = "Raças";
            this.btnracas.UseVisualStyleBackColor = true;
            this.btnracas.Click += new System.EventHandler(this.btnracas_Click);
            // 
            // btninicio
            // 
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.ForeColor = System.Drawing.Color.White;
            this.btninicio.Location = new System.Drawing.Point(8, 86);
            this.btninicio.Margin = new System.Windows.Forms.Padding(2);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(124, 40);
            this.btninicio.TabIndex = 0;
            this.btninicio.Text = "Início";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneltop.Controls.Add(this.btnclose);
            this.paneltop.Controls.Add(this.btnmin);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(749, 44);
            this.paneltop.TabIndex = 1;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltop_Paint);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(553, 12);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(20, 18);
            this.btnclose.TabIndex = 1;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(525, 12);
            this.btnmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(17, 18);
            this.btnmin.TabIndex = 0;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // panelcenter
            // 
            this.panelcenter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelcenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcenter.BackgroundImage")));
            this.panelcenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcenter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelcenter.Location = new System.Drawing.Point(149, 40);
            this.panelcenter.Margin = new System.Windows.Forms.Padding(2);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(600, 654);
            this.panelcenter.TabIndex = 2;
            this.panelcenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcenter_Paint);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_DetalhesAgendamentosBindingSource
            // 
            this.view_DetalhesAgendamentosBindingSource.DataMember = "View_DetalhesAgendamentos";
            this.view_DetalhesAgendamentosBindingSource.DataSource = this.dataSet1;
            // 
            // view_DetalhesAgendamentosTableAdapter
            // 
            this.view_DetalhesAgendamentosTableAdapter.ClearBeforeFill = true;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // agendamento_servicosTableAdapter1
            // 
            this.agendamento_servicosTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 694);
            this.Controls.Add(this.panelcenter);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelleft);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelleft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button btnagendamentos;
        private System.Windows.Forms.Button btnservicos;
        private System.Windows.Forms.Button btnanimais;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnracas;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Panel pansel;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource view_DetalhesAgendamentosBindingSource;
        private DataSet1TableAdapters.View_DetalhesAgendamentosTableAdapter view_DetalhesAgendamentosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblAgendado;
        private System.Windows.Forms.Label lblAndamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DataSet1TableAdapters.agendamento_servicosTableAdapter agendamento_servicosTableAdapter1;
    }
}

