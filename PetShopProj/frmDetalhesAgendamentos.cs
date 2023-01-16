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
    public partial class frmDetalhesAgendamentos : Form
    {
        public frmDetalhesAgendamentos()
        {
            InitializeComponent();
        }

        private void frmDetalhesAgendamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_DetalhesAgendamentos' table. You can move, or remove it, as needed.
            this.view_DetalhesAgendamentosTableAdapter.Fill(this.dataSet1.View_DetalhesAgendamentos);
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '"
                + DateTime.Now.ToShortDateString() + "'";

        }
    }
}
