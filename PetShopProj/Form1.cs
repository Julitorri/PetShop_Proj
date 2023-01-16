using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel= false;
            cliente.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(cliente);
            cliente.Show();   
            pansel.Top = btnclientes.Top;
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            panelcenter.Controls.Clear();
            pansel.Top = btninicio.Top;
        }

        private void btnracas_Click(object sender, EventArgs e)
        {
            FrmCadRacas racas = new FrmCadRacas();
            racas.TopLevel = false;
            racas.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(racas);
            racas.Show();
            pansel.Top = btnracas.Top;
        }

        private void btnanimais_Click(object sender, EventArgs e)
        {
            frmCadAnimais animais = new frmCadAnimais();
            animais.TopLevel = false;
            animais.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(animais);
            animais.Show();
            pansel.Top = btnanimais.Top;
        }

        private void btnservicos_Click(object sender, EventArgs e)
        {
            frmCadServicos servicos = new frmCadServicos();
            servicos.TopLevel = false;
            servicos.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(servicos);
            servicos.Show();
            pansel.Top = btnservicos.Top;
        }

        private void btnagendamentos_Click(object sender, EventArgs e)
        {
            frmCadAgendamentos agendamentos = new frmCadAgendamentos();
            agendamentos.TopLevel = false;
            agendamentos.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(agendamentos);
            agendamentos.Show();
            pansel.Top = btnagendamentos.Top;
        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_DetalhesAgendamentos' table. You can move, or remove it, as needed.
            this.view_DetalhesAgendamentosTableAdapter.Fill(this.dataSet1.View_DetalhesAgendamentos);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {   //recarregar os dados na view
            view_DetalhesAgendamentosTableAdapter.Fill(dataSet1.View_DetalhesAgendamentos);
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" 
            + DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Em andamento'";
            int QTDandamento = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());
            view_DetalhesAgendamentosBindingSource.RemoveFilter(); //retirou o filtro anteiror
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" +
                DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Agendado'";
            int QTDagendado = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());
            lblAndamento.Text = QTDandamento.ToString();
            LblAgendado.Text = QTDagendado.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalhesAgendamentos Detalhes = new frmDetalhesAgendamentos();
            Detalhes.TopLevel = false;
            Detalhes.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(Detalhes);
            Detalhes.Show();
            //pansel.Top = btnDetalhes.Top;
        }
    }
}
