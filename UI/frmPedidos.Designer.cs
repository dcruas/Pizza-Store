namespace UI
{
    partial class frmPedidos
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
            this.gbpPedidos = new System.Windows.Forms.GroupBox();
            this.gpbItens = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbpPedidos.SuspendLayout();
            this.gpbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpPedidos
            // 
            this.gbpPedidos.Controls.Add(this.dgvPedidos);
            this.gbpPedidos.Location = new System.Drawing.Point(12, 12);
            this.gbpPedidos.Name = "gbpPedidos";
            this.gbpPedidos.Size = new System.Drawing.Size(969, 161);
            this.gbpPedidos.TabIndex = 0;
            this.gbpPedidos.TabStop = false;
            this.gbpPedidos.Text = "Pedidos:";
            // 
            // gpbItens
            // 
            this.gpbItens.Controls.Add(this.dgvItens);
            this.gpbItens.Location = new System.Drawing.Point(12, 236);
            this.gpbItens.Name = "gpbItens";
            this.gpbItens.Size = new System.Drawing.Size(969, 161);
            this.gpbItens.TabIndex = 1;
            this.gpbItens.TabStop = false;
            this.gpbItens.Text = "Itens:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(409, 403);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(6, 19);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(957, 127);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(6, 19);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(957, 127);
            this.dgvItens.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 428);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpbItens);
            this.Controls.Add(this.gbpPedidos);
            this.Name = "frmPedidos";
            this.Text = "PizzaHÃT - Todos os Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load_1);
            this.gbpPedidos.ResumeLayout(false);
            this.gpbItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpPedidos;
        private System.Windows.Forms.GroupBox gpbItens;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnCancelar;
    }
}