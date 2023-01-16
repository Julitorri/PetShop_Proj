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
    public partial class frmLocalizarCliente : Form
    {
        public frmLocalizarCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmLocalizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dataSet1.cliente);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "cli_nome like '" + textNome .Text + "%'";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            VariaveisGlobais.CodigoTroca = int.Parse(clienteDataGridView.Rows
                [e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                VariaveisGlobais.CodigoTroca = 0;
            }
            this.Dispose();

        }
    }
}
