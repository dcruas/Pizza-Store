namespace UI
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbIncluir = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnPedido = new System.Windows.Forms.ToolStripButton();
            this.txtLimpar = new System.Windows.Forms.ToolStripButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIncluir,
            this.tsbExcluir,
            this.btnPedido,
            this.txtLimpar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(771, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbIncluir
            // 
            this.tsbIncluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbIncluir.Image")));
            this.tsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIncluir.Name = "tsbIncluir";
            this.tsbIncluir.Size = new System.Drawing.Size(60, 22);
            this.tsbIncluir.Text = "Incluir";
            this.tsbIncluir.Click += new System.EventHandler(this.tsbIncluir_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Enabled = false;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(61, 22);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
            this.btnPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(62, 22);
            this.btnPedido.Text = "Fechar";
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // txtLimpar
            // 
            this.txtLimpar.Image = ((System.Drawing.Image)(resources.GetObject("txtLimpar.Image")));
            this.txtLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtLimpar.Name = "txtLimpar";
            this.txtLimpar.Size = new System.Drawing.Size(111, 22);
            this.txtLimpar.Text = "Limpar Campos";
            this.txtLimpar.Click += new System.EventHandler(this.txtLimpar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(27, 89);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(70, 87);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 20);
            this.txtValor.TabIndex = 6;
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(25, 124);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(724, 185);
            this.dgvProduto.TabIndex = 8;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            this.dgvProduto.DoubleClick += new System.EventHandler(this.dgvProduto_DoubleClick);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = global::UI.Properties.Resources.Search_16x;
            this.btnProcurar.Location = new System.Drawing.Point(334, 58);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(37, 29);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(70, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(46, 20);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código:";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 335);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmProduto";
            this.Text = "PizzaHÃT - Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbIncluir;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStripButton btnPedido;
        private System.Windows.Forms.ToolStripButton txtLimpar;
    }
}

