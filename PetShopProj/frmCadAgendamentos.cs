using PetShopProj.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProj
{
    public partial class frmCadAgendamentos : Form
    {
        public frmCadAgendamentos()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(dataSet1.agendamento);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo! Informe os serviços");
                txtCodServ.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");

            }
        }

        private void frmCadAgendamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_Total_servicos' table. You can move, or remove it, as needed.
            this.view_Total_servicosTableAdapter.Fill(this.dataSet1.View_Total_servicos);
            // TODO: This line of code loads data into the 'dataSet1.View_ServicosAgendamento' table. You can move, or remove it, as needed.
            this.view_ServicosAgendamentoTableAdapter.Fill(this.dataSet1.View_ServicosAgendamento);
            // TODO: This line of code loads data into the 'petshopDataSet.View_ServicosAgendamento' table. You can move, or remove it, as needed.
            //this.view_ServicosAgendamentoTableAdapter.Fill(this.DataSet1.View_ServicosAgendamento);
            // TODO: This line of code loads data into the 'dataSet1.agendamento_servicos' table. You can move, or remove it, as needed.
            this.agendamento_servicosTableAdapter.Fill(this.dataSet1.agendamento_servicos);
            // TODO: This line of code loads data into the 'dataSet1.animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.dataSet1.animal);
            // TODO: This line of code loads data into the 'dataSet1.agendamento' table. You can move, or remove it, as needed.
            this.agendamentoTableAdapter.Fill(this.dataSet1.agendamento);

        }

        private void ag_horarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void ag_animalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void agendamentoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ag_situacaoComboBox.Text = "Agendado";
            ag_dataDateTimePicker.Text = DateTime.Now.ToShortDateString();
            ag_horarioTextBox.Text = DateTime.Now.ToShortTimeString();
            ag_totalTextBox.Text = "0.00";
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodServ_TextChanged(object sender, EventArgs e)
        {
            Atualizar_Grid();
        }

        private void txtCodServ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodServ.Text != "")
            {
                servicoBindingSource.Filter = "serv_codigo = " + txtCodServ.Text;
                if (servicoBindingSource.Count == 1) //encontrou o serviço
                {
                    //cria uma variável com todos os serviços encontrados
                    DataRowView ServicoEncontrado = (DataRowView)servicoBindingSource.Current;
                    txtDescServ.Text = ServicoEncontrado["serv_descricao"].ToString();
                    txtValUnit.Text = ServicoEncontrado["serv_preco"].ToString();
                    txtQtd.Text = "1";
                    txtQtd.SelectAll();
                    txtQtd.Focus();

                }
                else //abrir o cadastro para ele localizar
                {
                    frmCadServicos serv = new frmCadServicos();
                    serv.ShowDialog(); //jogar valores para a textbox
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                agendamento_servicosTableAdapter.InserirServico(int.Parse(ag_codigoTextBox.Text),
                                int.Parse(txtCodServ.Text), int.Parse(txtQtd.Text), decimal.Parse(txtValUnit.Text));
                //limpar todas as textboxs
                txtCodServ.Clear();
                txtDescServ.Clear();
                txtQtd.Clear();
                txtValUnit.Clear();
                txtCodServ.Focus();

                Atualizar_Grid();
            }
            catch (Exception)
            {

                MessageBox.Show("Tente novamente.");
            }
            Total();
        }

        private void view_ServicosAgendamentoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void Atualizar_Grid()
        {
            try
            {
                if (txtCodServ.Text != "") //pesquisar
                {
                    //recarrega dados
                    view_ServicosAgendamentoTableAdapter.Fill(dataSet1.View_ServicosAgendamento);
                    //filtra pelo cod do agendamento
                    view_ServicosAgendamentoBindingSource.Filter = "ag_serv_agendamento =" + txtCodServ.Text;
                }
            }
            catch (Exception)
            {


            }

        }

        private void txtValUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtValUnit.Text != "")
            {
                btnAdd_Click(sender, e);
            }
        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQtd.Text != "")
            {
                txtValUnit.SelectAll();
                txtValUnit.Focus();
            }
        }

        private void view_ServicosAgendamentoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigo = 0;
                codigo = int.Parse(view_ServicosAgendamentoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                agendamento_servicosTableAdapter.RemoverServico(codigo);
            }
            catch (Exception)
            {

                throw;
            }
            Atualizar_Grid();
            Total();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Após finalizado, não poderá ser alterado", "Petshop",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ag_situacaoComboBox.Text = "Finalizado"; //Muda o texto da combobox
                agendamentoBindingSource.EndEdit(); //finalizar edição
                agendamentoTableAdapter.Update(dataSet1.agendamento); //salva alterações
                MessageBox.Show("Agendamento finalizado.");
                Finalizado(); //bloquear se estiver finalizado
            }
        }
        private void Finalizado()
        {
            if (ag_situacaoComboBox.Text == "Finalizado") 
            {
                agendamentoBindingNavigatorSaveItem.Enabled = false; //bloqueia o salvar
                bindingNavigatorDeleteItem.Enabled = false; // o deletar
                toolStripButton1.Enabled = false; // o finalizar
                groupBox2.Enabled = false;
            }
            else { 
                agendamentoBindingNavigatorSaveItem.Enabled = true; //bloqueia o salvar
                bindingNavigatorDeleteItem.Enabled = true; // o deletar
                toolStripButton1.Enabled = true; // o finalizar
                groupBox2.Enabled = true;
            }
        }
        private void ag_codigoTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualizar_Grid();          
        }
        private void agendamentoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Finalizado();
        }
      
        private void txtDescServ_TextChanged(object sender, EventArgs e)
        {

        }
        private void Total()
        {
            if(ag_codigoTextBox.Text != "")
            {
                view_Total_servicosTableAdapter.Fill(dataSet1.View_Total_servicos);
                view_Total_servicosBindingSource.Filter = "ag_serv_agendamento = " +
                    ag_codigoTextBox.Text;
                    if(view_Total_servicosBindingSource.Count==1)
                {
                        DataRowView Resultado = (DataRowView)view_Total_servicosBindingSource.Current;
                        ag_totalTextBox.Text = Resultado["Total"].ToString();
                        agendamentoTableAdapter.Update(dataSet1.agendamento);
                }
                else
                {
                    ag_totalTextBox.Text = "0.00";
                    agendamentoTableAdapter.Update(dataSet1.agendamento);
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoTroca = 0;
            frmLocalizarAnimal loca = new frmLocalizarAnimal();
            loca.ShowDialog();
            if (VariaveisGlobais.CodigoTroca > 0) //ou seja, se ele encontrou algum registro
            {
                //posicionar o código localizado
                animalBindingSource.Position = animalBindingSource.Find("ani_codigo",
                    VariaveisGlobais.CodigoTroca);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
