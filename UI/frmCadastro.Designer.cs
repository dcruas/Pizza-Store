namespace UI
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbProdutos = new System.Windows.Forms.ToolStripButton();
            this.btnMonitorar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.gpbPedidos = new System.Windows.Forms.GroupBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnProcurarPedido = new System.Windows.Forms.Button();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbQtde = new System.Windows.Forms.ComboBox();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.txtcodpedido = new System.Windows.Forms.TextBox();
            this.lblcodpedido = new System.Windows.Forms.Label();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.btnRemoverLista = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cmbDescricao = new System.Windows.Forms.ComboBox();
            this.txtcodproduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gpbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProdutos,
            this.btnMonitorar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1576, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbProdutos
            // 
            this.tsbProdutos.Image = ((System.Drawing.Image)(resources.GetObject("tsbProdutos.Image")));
            this.tsbProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProdutos.Name = "tsbProdutos";
            this.tsbProdutos.Size = new System.Drawing.Size(75, 22);
            this.tsbProdutos.Text = "Produtos";
            this.tsbProdutos.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // btnMonitorar
            // 
            this.btnMonitorar.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitorar.Image")));
            this.btnMonitorar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMonitorar.Name = "btnMonitorar";
            this.btnMonitorar.Size = new System.Drawing.Size(125, 22);
            this.btnMonitorar.Text = "Monitorar Pedidos";
            this.btnMonitorar.Click += new System.EventHandler(this.btnMonitorar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(117, 22);
            this.tsbCancelar.Text = "Fechar Programa";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(19, 143);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(246, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(16, 127);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(90, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(88, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome do Cliente:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(76, 31);
            this.txtTelefone.MaxLength = 8;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(160, 20);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 34);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // button1
            // 
            this.button1.Image = global::UI.Properties.Resources.Search_16x;
            this.button1.Location = new System.Drawing.Point(242, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1549, 209);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(402, 19);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(1141, 184);
            this.dgvCliente.TabIndex = 22;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(190, 180);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(103, 180);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(21, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(19, 71);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 13);
            this.lblData.TabIndex = 17;
            this.lblData.Text = "Código:";
            // 
            // gpbPedidos
            // 
            this.gpbPedidos.Controls.Add(this.btnCancelarPedido);
            this.gpbPedidos.Controls.Add(this.dgvPedidos);
            this.gpbPedidos.Controls.Add(this.btnProcurarPedido);
            this.gpbPedidos.Controls.Add(this.lblPedido);
            this.gpbPedidos.Controls.Add(this.txtPedido);
            this.gpbPedidos.Location = new System.Drawing.Point(775, 271);
            this.gpbPedidos.Name = "gpbPedidos";
            this.gpbPedidos.Size = new System.Drawing.Size(786, 452);
            this.gpbPedidos.TabIndex = 18;
            this.gpbPedidos.TabStop = false;
            this.gpbPedidos.Text = "Histórico de pedidos";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Enabled = false;
            this.btnCancelarPedido.Location = new System.Drawing.Point(12, 411);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(101, 29);
            this.btnCancelarPedido.TabIndex = 29;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 64);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(758, 339);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.Click += new System.EventHandler(this.dgvPedidos_Click);
            this.dgvPedidos.DoubleClick += new System.EventHandler(this.dgvPedidos_DoubleClick);
            // 
            // btnProcurarPedido
            // 
            this.btnProcurarPedido.Image = global::UI.Properties.Resources.Search_16x;
            this.btnProcurarPedido.Location = new System.Drawing.Point(137, 26);
            this.btnProcurarPedido.Name = "btnProcurarPedido";
            this.btnProcurarPedido.Size = new System.Drawing.Size(36, 30);
            this.btnProcurarPedido.TabIndex = 28;
            this.btnProcurarPedido.UseVisualStyleBackColor = true;
            this.btnProcurarPedido.Click += new System.EventHandler(this.btnProcurarPedido_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(9, 35);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(43, 13);
            this.lblPedido.TabIndex = 26;
            this.lblPedido.Text = "Pedido:";
            // 
            // txtPedido
            // 
            this.txtPedido.Enabled = false;
            this.txtPedido.Location = new System.Drawing.Point(58, 32);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(73, 20);
            this.txtPedido.TabIndex = 27;
            this.txtPedido.TextChanged += new System.EventHandler(this.txtPedido_TextChanged);
            this.txtPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedido_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbQtde);
            this.groupBox2.Controls.Add(this.btnNovoPedido);
            this.groupBox2.Controls.Add(this.txtcodpedido);
            this.groupBox2.Controls.Add(this.lblcodpedido);
            this.groupBox2.Controls.Add(this.btnSalvarAlteracao);
            this.groupBox2.Controls.Add(this.btnRemoverLista);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnFaturar);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.lblQuantidade);
            this.groupBox2.Controls.Add(this.cmbDescricao);
            this.groupBox2.Controls.Add(this.txtcodproduto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.lblItem);
            this.groupBox2.Controls.Add(this.dgvCarrinho);
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 452);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrinho:";
            // 
            // cmbQtde
            // 
            this.cmbQtde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQtde.FormattingEnabled = true;
            this.cmbQtde.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbQtde.Location = new System.Drawing.Point(379, 134);
            this.cmbQtde.Name = "cmbQtde";
            this.cmbQtde.Size = new System.Drawing.Size(50, 21);
            this.cmbQtde.TabIndex = 34;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Enabled = false;
            this.btnNovoPedido.Location = new System.Drawing.Point(12, 26);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(124, 30);
            this.btnNovoPedido.TabIndex = 33;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtcodpedido
            // 
            this.txtcodpedido.Enabled = false;
            this.txtcodpedido.Location = new System.Drawing.Point(22, 91);
            this.txtcodpedido.Name = "txtcodpedido";
            this.txtcodpedido.Size = new System.Drawing.Size(59, 20);
            this.txtcodpedido.TabIndex = 32;
            this.txtcodpedido.TextChanged += new System.EventHandler(this.txtcodpedido_TextChanged);
            // 
            // lblcodpedido
            // 
            this.lblcodpedido.AutoSize = true;
            this.lblcodpedido.Location = new System.Drawing.Point(19, 75);
            this.lblcodpedido.Name = "lblcodpedido";
            this.lblcodpedido.Size = new System.Drawing.Size(62, 13);
            this.lblcodpedido.TabIndex = 31;
            this.lblcodpedido.Text = "CodPedido:";
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.Enabled = false;
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(623, 219);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(113, 23);
            this.btnSalvarAlteracao.TabIndex = 30;
            this.btnSalvarAlteracao.Text = "Salvar Alteração";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracao.Click += new System.EventHandler(this.btnSalvarAlteracao_Click);
            // 
            // btnRemoverLista
            // 
            this.btnRemoverLista.Enabled = false;
            this.btnRemoverLista.Location = new System.Drawing.Point(623, 248);
            this.btnRemoverLista.Name = "btnRemoverLista";
            this.btnRemoverLista.Size = new System.Drawing.Size(113, 23);
            this.btnRemoverLista.TabIndex = 25;
            this.btnRemoverLista.Text = "Remover da Lista";
            this.btnRemoverLista.UseVisualStyleBackColor = true;
            this.btnRemoverLista.Click += new System.EventHandler(this.btnRemoverLista_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(272, 27);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 29);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Limpar Campos";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFaturar
            // 
            this.btnFaturar.Enabled = false;
            this.btnFaturar.Location = new System.Drawing.Point(142, 26);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(123, 29);
            this.btnFaturar.TabIndex = 22;
            this.btnFaturar.Text = "Salvar Pedido";
            this.btnFaturar.UseVisualStyleBackColor = true;
            this.btnFaturar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(620, 364);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Pedido:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(623, 380);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 20;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Enabled = false;
            this.btnIncluir.Location = new System.Drawing.Point(623, 191);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(113, 23);
            this.btnIncluir.TabIndex = 17;
            this.btnIncluir.Text = "Incluir no carrinho";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(19, 167);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(454, 20);
            this.txtObservacao.TabIndex = 16;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(379, 117);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(33, 13);
            this.lblQuantidade.TabIndex = 15;
            this.lblQuantidade.Text = "Qtde:";
            // 
            // cmbDescricao
            // 
            this.cmbDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescricao.FormattingEnabled = true;
            this.cmbDescricao.Location = new System.Drawing.Point(163, 134);
            this.cmbDescricao.Name = "cmbDescricao";
            this.cmbDescricao.Size = new System.Drawing.Size(195, 21);
            this.cmbDescricao.TabIndex = 12;
            this.cmbDescricao.SelectedIndexChanged += new System.EventHandler(this.cmbDescricao_SelectedIndexChanged);
            // 
            // txtcodproduto
            // 
            this.txtcodproduto.Enabled = false;
            this.txtcodproduto.Location = new System.Drawing.Point(78, 134);
            this.txtcodproduto.Name = "txtcodproduto";
            this.txtcodproduto.Size = new System.Drawing.Size(67, 20);
            this.txtcodproduto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(78, 118);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código:";
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(21, 133);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(41, 20);
            this.txtItem.TabIndex = 3;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(18, 117);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item:";
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(19, 196);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.Size = new System.Drawing.Size(584, 207);
            this.dgvCarrinho.TabIndex = 1;
            this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellContentClick);
            this.dgvCarrinho.Click += new System.EventHandler(this.dgvCarrinho_Click);
            this.dgvCarrinho.DoubleClick += new System.EventHandler(this.dgvCarrinho_DoubleClick);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbPedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCadastro";
            this.Text = "PizzaHãt - A melhor pizza";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gpbPedidos.ResumeLayout(false);
            this.gpbPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbProdutos;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox gpbPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRemoverLista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFaturar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cmbDescricao;
        private System.Windows.Forms.TextBox txtcodproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnProcurarPedido;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.TextBox txtcodpedido;
        private System.Windows.Forms.Label lblcodpedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.ToolStripButton btnMonitorar;
        private System.Windows.Forms.ComboBox cmbQtde;
    }
}