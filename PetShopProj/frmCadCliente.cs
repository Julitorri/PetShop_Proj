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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dataSet1.cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try {  
            this.Validate();
            this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(dataSet1.cliente);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo!");
            }
            catch (Exception){
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled=false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled=true;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme a exlusão do registro", "Petshop",

                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(dataSet1.cliente);
                }

            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(dataSet1.cliente);
                MessageBox.Show("Registro não pode ser excluído");
            }
            
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png) | *.jpg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

               MessageBox.Show("Erro ao carregar o arquivo" , "Petshop", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            
        }

        private void cli_fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoTroca = 0;
            frmLocalizarCliente loca = new frmLocalizarCliente();
            loca.ShowDialog();
            if(VariaveisGlobais.CodigoTroca>0) //ou seja, se ele encontrou algum registro
            {
                //posicionar o código localizado
                clienteBindingSource.Position = clienteBindingSource.Find("cli_codigo",VariaveisGlobais.CodigoTroca);

            }
        }
    }
}
                
