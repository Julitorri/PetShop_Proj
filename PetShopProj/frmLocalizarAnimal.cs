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
    public partial class frmLocalizarAnimal : Form
    {
        public frmLocalizarAnimal()
        {
            InitializeComponent();
        }

        private void frmLocalizarAnimal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_AnimaisClientes' table. You can move, or remove it, as needed.
            this.view_AnimaisClientesTableAdapter.Fill(this.dataSet1.View_AnimaisClientes);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            view_AnimaisClientesBindingSource.Filter = "ani_nome like '" + textNome.Text + "%'";
        }
        
        private void view_AnimaisClientesDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VariaveisGlobais.CodigoTroca = int.Parse(view_AnimaisClientesDataGridView.Rows
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
