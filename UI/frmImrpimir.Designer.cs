namespace UI
{
    partial class frmImrpimir
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
            this.cmbImprimir = new System.Windows.Forms.ComboBox();
            this.lblImpressora = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbImprimir
            // 
            this.cmbImprimir.FormattingEnabled = true;
            this.cmbImprimir.Location = new System.Drawing.Point(28, 36);
            this.cmbImprimir.Name = "cmbImprimir";
            this.cmbImprimir.Size = new System.Drawing.Size(283, 21);
            this.cmbImprimir.TabIndex = 0;
            this.cmbImprimir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblImpressora
            // 
            this.lblImpressora.AutoSize = true;
            this.lblImpressora.Location = new System.Drawing.Point(25, 20);
            this.lblImpressora.Name = "lblImpressora";
            this.lblImpressora.Size = new System.Drawing.Size(61, 13);
            this.lblImpressora.TabIndex = 1;
            this.lblImpressora.Text = "Impressora:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(317, 17);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(95, 42);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(28, 82);
            this.txtImprimir.Multiline = true;
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(719, 338);
            this.txtImprimir.TabIndex = 3;
            // 
            // frmImrpimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtImprimir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblImpressora);
            this.Controls.Add(this.cmbImprimir);
            this.Name = "frmImrpimir";
            this.Text = "PizzaHAT - Imprimir Pedido";
            this.Load += new System.EventHandler(this.frmImrpimir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbImprimir;
        private System.Windows.Forms.Label lblImpressora;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtImprimir;
    }
}