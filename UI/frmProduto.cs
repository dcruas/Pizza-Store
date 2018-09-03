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
using DTO;




namespace UI
{
    public partial class frmProduto : Form
    {
        private ProdutoBLL produtoBLL;

        public frmProduto()
        {
            InitializeComponent();

            produtoBLL = new ProdutoBLL();
            dgvProduto.DataSource = null;
            dgvProduto.DataSource = produtoBLL.MostrarProduto();
         
        }

       
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void tsbIncluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.nome = txtNome.Text;
            produto.valorproduto = int.Parse(txtValor.Text);
            if (txtCodigo.Text == "")
            {
                
                produtoBLL.IncluirProduto(produto);
            }
            else
            {
                produtoBLL.AtualizarProduto(produto);
                
            }
            dgvProduto.DataSource = null;
            dgvProduto.DataSource = produtoBLL.MostrarProduto();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            //frmCadastro FormCadastro = new frmCadastro(this, dgvPedido, 2);
            //FormCadastro.Show();
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do contato?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                produtoBLL.ExcluirProduto(int.Parse(dgvProduto.CurrentRow.Cells[0].Value.ToString()));
                dgvProduto.DataSource = null;
                dgvProduto.DataSource = produtoBLL.MostrarProduto();
            }
        }
        

        public void AtualizarCampos()
        {
            //dgvContato.AutoGenerateColumns = false;
           // dgvPedido.DataSource = null;
            //dgvPedido.DataSource = pedidoBLL.MostrarPedidos(int.Parse(txtTelefone.Text));
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtNome.Text = "";
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbExcluir.Enabled = true;
        }
    }
}
