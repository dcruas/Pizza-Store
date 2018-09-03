using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DTO;


namespace UI
{
    public partial class frmImrpimir : Form
    {

        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();


        public frmImrpimir(List<ItemPedido> ItensPedidos, Pedido pedido)
        {
            InitializeComponent();
            CarregarListaDeImpressoras();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            ItemPedido ItemPedido = new ItemPedido();

            txtImprimir.AppendText("==================Pizzaria - PizzaHÃT===================\n");
            txtImprimir.AppendText("====================================================\n");
            txtImprimir.AppendText("Código do pedido: " + pedido.pedido.ToString() + "\n");

            foreach (ItemPedido item in ItensPedidos)
            {
                txtImprimir.AppendText("Item:" + item.nomeproduto + "\t \t Qtde:" + item.quantidade.ToString() + "\n");

            }

            txtImprimir.AppendText("Valor Total: R$" + pedido.valortotal.ToString() + "\n");
            txtImprimir.AppendText("Observação:" + pedido.observacao.ToString() + "\n");
            txtImprimir.AppendText("====================================================");

        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtImprimir.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }


        private void CarregarListaDeImpressoras()
        {
            cmbImprimir.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbImprimir.Items.Add(printer);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmImrpimir_Load(object sender, EventArgs e)
        {

        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

    }   
}
