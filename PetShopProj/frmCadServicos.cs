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
    public partial class frmCadServicos : Form
    {
        public frmCadServicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmCadServicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.servico' table. You can move, or remove it, as needed.
            this.servicoTableAdapter.Fill(this.dataSet1.servico);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void serv_tempoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
