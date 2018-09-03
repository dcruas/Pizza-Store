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
using System.Data.SqlClient;

namespace UI
{
    public partial class frmCadastro : Form
    {
        PedidoBLL PedidoBLL;
        ClienteBLL ClienteBLL;
        ItemPedidoBLL ItemPedidoBLL;
        
        List<ItemPedido> ItensPedidos = new List<ItemPedido>();


        public frmCadastro()
        {
           InitializeComponent();

            PedidoBLL = new PedidoBLL();
            ClienteBLL = new ClienteBLL();
            ItemPedidoBLL = new ItemPedidoBLL();
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = ClienteBLL.MostrarCliente();


        }

        protected void FillCombobox()
        {
            SqlConnection conexao;

            conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");
            
            DataSet ds = new DataSet();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("select NM_PRODUTO, CD_PRODUTO from TB_PRODUTO group by CD_PRODUTO, NM_PRODUTO", conexao);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                da.Fill(ds);
                cmbDescricao.DisplayMember = "NM_PRODUTO";
                cmbDescricao.ValueMember = "CD_PRODUTO";
                cmbDescricao.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conexao.Close();

            }
        }

        private void VerificarDigito(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        public void ConsultarGrid(int verificador)
        {

            if (verificador == 0)
            {
                txtCodigo.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtTelefone.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtEndereco.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();

            }
            else if (verificador == 1)
            {
                txtcodpedido.Text = dgvPedidos.CurrentRow.Cells[0].Value.ToString();
                txtObservacao.Text = dgvPedidos.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {

            }


        }

        

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto();
            produto.Show();
            
            
                        
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTelefone.TextLength == 8)
            {
                List<Cliente> Clientes = new List<Cliente>();
                Cliente cliente = new Cliente();
                dgvCliente.DataSource = null;
                cliente = ClienteBLL.ConsultarCliente(int.Parse(txtTelefone.Text));
                Clientes.Add(cliente);
                dgvCliente.DataSource = Clientes;
                
                txtCodigo.Text = cliente.codigo.ToString();
                txtNome.Text = cliente.nome.ToString();
                txtEndereco.Text = cliente.endereco.ToString();
               
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Cliente não encontrado, verifique se todas as informações estão corretas");
                }
                else
                {
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvPedidos.DataSource = null;
                    dgvPedidos.DataSource = PedidoBLL.MostrarPedidos(int.Parse(txtCodigo.Text));
                    txtPedido.Enabled = true;
                    dgvPedidos.Columns[3].Visible = false;
                    dgvPedidos.Columns[4].Visible = false;
                    dgvPedidos.Columns[5].Visible = false;
                    btnNovoPedido.Enabled = true;
                }
                
            }
            else
            {
                txtTelefone.Text = "";
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = ClienteBLL.MostrarCliente();
                MessageBox.Show("O telefone precisa ter 8 digítos");

            }

            
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            List<Cliente> Clientes = new List<Cliente>();
            Cliente cliente = new Cliente();
            int verificadortelefone = 1;
            if (txtTelefone.TextLength == 8 && txtNome.TextLength > 6 && txtEndereco.TextLength > 6)
            {
                cliente.nome = txtNome.Text;
                cliente.telefone = int.Parse(txtTelefone.Text);
                cliente.endereco = txtEndereco.Text;
                Clientes = ClienteBLL.MostrarCliente();
                

                foreach (Cliente pessoa in Clientes)
                {
                    if (pessoa.telefone == int.Parse(txtTelefone.Text))
                    {
                        verificadortelefone = 0;
                        break;
                    }
                    else
                    {
                        verificadortelefone = 1;
                    }
                }

                if (verificadortelefone == 0)
                {
                    MessageBox.Show("Esse cadastro já existe, verifique se o número de telefone está correto");
                }
                else
                {
                    
                    dgvCliente.DataSource = null;
                    ClienteBLL.IncluirCliente(cliente);
                    dgvCliente.DataSource = ClienteBLL.MostrarCliente();
                    MessageBox.Show("Registro efetuado com sucesso");
                }

            }
            else
            {
                MessageBox.Show("Verifique se você digitou todos os campos e confirme se o telefone tem 8 digitos");
            }


           
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificarDigito(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.codigo = int.Parse(txtCodigo.Text);
            cliente.nome = txtNome.Text;
            cliente.telefone = int.Parse(txtTelefone.Text);
            cliente.endereco = txtEndereco.Text;
            ClienteBLL.AtualizarCliente(cliente);

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtCodigo.Text = "";
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            dgvCarrinho.DataSource = null;
            dgvCliente.DataSource = ClienteBLL.MostrarCliente();



        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();
           
            cliente = ClienteBLL.ConsultarCliente(int.Parse(dgvCliente.CurrentRow.Cells[2].Value.ToString()));
            txtCodigo.Text = cliente.codigo.ToString();
            txtNome.Text = cliente.nome.ToString();
            txtEndereco.Text = cliente.endereco.ToString();
            txtTelefone.Text = cliente.telefone.ToString();


            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = PedidoBLL.MostrarPedidos(int.Parse(dgvCliente.CurrentRow.Cells[0].Value.ToString()));
            txtPedido.Enabled = true;
            dgvPedidos.Columns[3].Visible = false;
            dgvPedidos.Columns[4].Visible = false;
            dgvPedidos.Columns[5].Visible = false;
            btnNovoPedido.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do contato?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClienteBLL.ExcluirCliente(int.Parse(dgvCliente.CurrentRow.Cells[0].Value.ToString()));
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = ClienteBLL.MostrarCliente();
            }
        }

        private void btnProcurarPedido_Click(object sender, EventArgs e)
        {
           dgvCarrinho.DataSource = null;
           int codpedido = int.Parse(txtPedido.Text);
           ItensPedidos = ItemPedidoBLL.MostrarItemPedido(codpedido);
            txtcodpedido.Text = codpedido.ToString();
            dgvCarrinho.DataSource = ItensPedidos;
            btnCancelar.Enabled = true;
            btnIncluir.Enabled = true;
            btnSalvarAlteracao.Enabled = false;
            btnRemoverLista.Enabled = false;
            btnFaturar.Enabled = true;

            FillCombobox();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            DateTime dateTime = DateTime.Now;


            string dia = dateTime.Day.ToString();
            string mes = dateTime.Month.ToString();
            string ano = dateTime.Year.ToString();
            pedido.datapedido = ano + "-" + mes + "-" + dia;
            pedido.cd_cliente = int.Parse(txtCodigo.Text);
            pedido.observacao = txtObservacao.Text;
            pedido.status = "1";
            pedido.valortotal = 0;

            if (txtcodpedido.Text == "") 
            txtcodpedido.Text = PedidoBLL.IncluirPedido(pedido).ToString(); 
            else            
            ItemPedidoBLL.ExcluirItemPedido(int.Parse(txtcodpedido.Text)); 

            foreach (ItemPedido item in ItensPedidos)
            {
                item.codpedido = int.Parse(txtcodpedido.Text);
                ItemPedidoBLL.IncluirItemPedido(item); 
                
            }
           
            pedido.valortotal = PedidoBLL.FinalizarPedido(int.Parse(txtcodpedido.Text));
            txtTotal.Text = "R$" + pedido.valortotal;
            dgvCarrinho.DataSource = null;
            ItensPedidos = ItemPedidoBLL.MostrarItemPedido(int.Parse(txtcodpedido.Text)); 
            dgvCarrinho.DataSource = ItensPedidos;
            dgvCarrinho.Columns[2].Visible = false;
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = PedidoBLL.MostrarPedidos(int.Parse(txtCodigo.Text));
            dgvPedidos.Columns[3].Visible = false;
            dgvPedidos.Columns[4].Visible = false;
            dgvPedidos.Columns[5].Visible = false;
            frmImrpimir imprimir = new frmImrpimir(ItensPedidos, pedido);
            imprimir.Show();



        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvPedidos_DoubleClick(object sender, EventArgs e)
        {
            dgvCarrinho.DataSource = null;
            int codpedido = int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            ItensPedidos = ItemPedidoBLL.MostrarItemPedido(codpedido);
            txtcodpedido.Text = codpedido.ToString();
            dgvCarrinho.DataSource = ItensPedidos;
            btnCancelar.Enabled = true;
            btnIncluir.Enabled = true;
            btnSalvarAlteracao.Enabled = false;
            btnRemoverLista.Enabled = false;
            btnFaturar.Enabled = true;
            btnCancelarPedido.Enabled = true;
            

            FillCombobox();
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            double quantidadetotal;
            ItemPedido item = new ItemPedido();
            item.codproduto = int.Parse(txtcodproduto.Text);
            item.nomeproduto = cmbDescricao.Text;
            if (cmbQtde.SelectedIndex == 0)
                item.quantidade = 0.5;
            else
            item.quantidade = double.Parse(cmbQtde.SelectedItem.ToString());

            ItensPedidos.Add(item);

            if (item.quantidade == 0.5)
            {
                btnFaturar.Enabled = false;
                cmbQtde.Enabled = false;
                if (dgvCarrinho.Rows.Count > 0)
                {
                    quantidadetotal = double.Parse(dgvCarrinho.Rows[dgvCarrinho.Rows.Count - 1].Cells[4].Value.ToString());
                    if (item.quantidade + quantidadetotal == 1)
                    {
                        btnFaturar.Enabled = true;
                        cmbQtde.Enabled = true;

                    }

                }


            }

            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = ItensPedidos;
            dgvCarrinho.Columns[2].Visible = false;


        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
           
            
         
        }

        private void cmbDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcodproduto.Text = cmbDescricao.SelectedValue.ToString();
        }

        private void dgvCarrinho_DoubleClick(object sender, EventArgs e)
        {

          txtItem.Text= dgvCarrinho.CurrentRow.Cells[0].Value.ToString();
          txtcodproduto.Text = dgvCarrinho.CurrentRow.Cells[1].Value.ToString();
          cmbDescricao.SelectedValue = dgvCarrinho.CurrentRow.Cells[1].Value;
          cmbQtde.SelectedItem = dgvCarrinho.CurrentRow.Cells[4].Value.ToString();
            btnSalvarAlteracao.Enabled = true;
            btnRemoverLista.Enabled = true;

        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            foreach (ItemPedido item in ItensPedidos)
            {
                if (item.codigo == int.Parse(txtItem.Text))
                {

                    item.codproduto = int.Parse(txtcodproduto.Text);
                    item.quantidade = double.Parse(cmbQtde.SelectedItem.ToString());
                }
            }
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = ItensPedidos;
        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            txtcodpedido.Text = "";
            txtItem.Text = "";
            txtcodproduto.Text = "";
            cmbQtde.Text = "";
            txtObservacao.Text = "";
            dgvCarrinho.DataSource = null;
            ItensPedidos.Clear();

            btnFaturar.Enabled = false;
            btnIncluir.Enabled = false;
            btnSalvarAlteracao.Enabled = false;
            btnRemoverLista.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbQtde.Enabled = true;
            txtcodpedido.Text = "";
            txtItem.Text = "";
            txtcodproduto.Text = "";
            cmbQtde.Text = "";
            txtObservacao.Text = "";
            dgvCarrinho.DataSource = null;
            ItensPedidos.Clear();

            FillCombobox();
            btnIncluir.Enabled = true;
            btnSalvarAlteracao.Enabled = false;
            btnRemoverLista.Enabled = false;
            btnFaturar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnRemoverLista_Click(object sender, EventArgs e)
        {
            string itemcodigo = dgvCarrinho.CurrentRow.Cells[0].Value.ToString();
            int i = 0;

            foreach (ItemPedido item in ItensPedidos)
            {
                if (item.codigo ==  int.Parse(itemcodigo))
                {
                    i = ItensPedidos.IndexOf(item);
                }
            }
            ItensPedidos.RemoveAt(i);

        }

        private void dgvPedidos_Click(object sender, EventArgs e)
        {
            /*string codpedido = dgvPedidos.CurrentRow.Cells[0].Value.ToString();
            PedidoBLL.ExcluirPedido(int.Parse(codpedido));
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = PedidoBLL.MostrarPedidos(int.Parse(txtCodigo.Text));
            btnCancelarPedido.Enabled = false;*/
        }

        private void dgvCarrinho_Click(object sender, EventArgs e)
        {
            txtItem.Text = dgvCarrinho.CurrentRow.Cells[0].Value.ToString();
            txtcodproduto.Text = dgvCarrinho.CurrentRow.Cells[1].Value.ToString();
            btnSalvarAlteracao.Enabled = true;
            btnRemoverLista.Enabled = true;

        }

        private void txtcodpedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificarDigito(e);
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMonitorar_Click(object sender, EventArgs e)
        {
            frmPedidos Pedido = new frmPedidos();
            Pedido.Show();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento do pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PedidoBLL.ExcluirPedido(int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString()));
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = PedidoBLL.MostrarPedidos(int.Parse(txtCodigo.Text));
                dgvPedidos.Columns[3].Visible = false;
                dgvPedidos.Columns[4].Visible = false;
                dgvPedidos.Columns[5].Visible = false;
            }
        }
    }
}
