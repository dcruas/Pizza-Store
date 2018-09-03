using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frmPedidos : Form
        
    {
        private PedidoBLL pedidoBLL;
        private ItemPedidoBLL itempedidoBLL;

        public frmPedidos()
        {
            InitializeComponent();
            pedidoBLL = new PedidoBLL();
            itempedidoBLL = new ItemPedidoBLL();
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidoBLL.MostrarTodosPedidos();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void frmPedidos_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codpedido;
            codpedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells[0].Value);
            dgvItens.DataSource = null;
            dgvItens.DataSource = itempedidoBLL.MostrarItemPedido(codpedido);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do contato?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pedidoBLL.ExcluirPedido(int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString()));
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = pedidoBLL.MostrarTodosPedidos();
            }
        }
    
    }
}
