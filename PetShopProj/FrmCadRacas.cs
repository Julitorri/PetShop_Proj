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
    public partial class FrmCadRacas : Form
    {
        public FrmCadRacas()
        {
            InitializeComponent();
        }

       /* private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }*/

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmCadRacas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.raca' table. You can move, or remove it, as needed.
            this.racaTableAdapter.Fill(this.dataSet1.raca);

        }

        private void racaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
