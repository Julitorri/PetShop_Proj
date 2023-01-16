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
    public partial class frmCadAnimais : Form
    {
        public frmCadAnimais()
        {
            InitializeComponent();
        }

        private void frmCadAnimais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.raca' table. You can move, or remove it, as needed.
            this.racaTableAdapter.Fill(this.dataSet1.raca);
            // TODO: This line of code loads data into the 'dataSet1.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dataSet1.cliente);
            // TODO: This line of code loads data into the 'dataSet1.animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.dataSet1.animal);

        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme a exlusão do registro", "Petshop",

                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(dataSet1.animal);
                }

            }
            catch (Exception)
            {
                animalTableAdapter.Fill(dataSet1.animal);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(dataSet1.animal);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled=true;

        }

        private void btnpetpic_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png) | *.jpg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar o arquivo", "Petshop", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ani_fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

         /*private void petpicbox_Click(object sender, EventArgs e)
         {
             try
             {
                 openFileDialog1.Filter = "Fotos (*.jpg; *.png) | *.jpg; *.png";
                 if (openFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                     petpicbox.Image = new Bitmap(openFileDialog1.FileName);
                 }
             }
             catch (Exception)
             {

                 MessageBox.Show("Erro ao carregar o arquivo", "Petshop", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
             }
         }*/
    }
}
