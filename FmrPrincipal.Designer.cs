
namespace Geek
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mspGeek = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.pbxVenda = new System.Windows.Forms.PictureBox();
            this.pbxProduto = new System.Windows.Forms.PictureBox();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.mspGeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(135, 354);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 16);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(698, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(984, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sair";
            // 
            // mspGeek
            // 
            this.mspGeek.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mspGeek.Location = new System.Drawing.Point(0, 0);
            this.mspGeek.Name = "mspGeek";
            this.mspGeek.Size = new System.Drawing.Size(1185, 24);
            this.mspGeek.TabIndex = 8;
            this.mspGeek.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // pedidoVendaToolStripMenuItem
            // 
            this.pedidoVendaToolStripMenuItem.Name = "pedidoVendaToolStripMenuItem";
            this.pedidoVendaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pedidoVendaToolStripMenuItem.Text = "Pedido | Venda";
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::Geek.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(884, 110);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(232, 241);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 3;
            this.pbxSair.TabStop = false;
            // 
            // pbxVenda
            // 
            this.pbxVenda.Image = global::Geek.Properties.Resources.venda;
            this.pbxVenda.Location = new System.Drawing.Point(605, 110);
            this.pbxVenda.Name = "pbxVenda";
            this.pbxVenda.Size = new System.Drawing.Size(232, 241);
            this.pbxVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenda.TabIndex = 2;
            this.pbxVenda.TabStop = false;
            // 
            // pbxProduto
            // 
            this.pbxProduto.Image = global::Geek.Properties.Resources.produto;
            this.pbxProduto.Location = new System.Drawing.Point(330, 110);
            this.pbxProduto.Name = "pbxProduto";
            this.pbxProduto.Size = new System.Drawing.Size(232, 241);
            this.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProduto.TabIndex = 1;
            this.pbxProduto.TabStop = false;
            // 
            // pbxCliente
            // 
            this.pbxCliente.Image = global::Geek.Properties.Resources.cliente;
            this.pbxCliente.Location = new System.Drawing.Point(49, 110);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(232, 241);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 0;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxVenda);
            this.Controls.Add(this.pbxProduto);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.mspGeek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspGeek;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.mspGeek.ResumeLayout(false);
            this.mspGeek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.PictureBox pbxProduto;
        private System.Windows.Forms.PictureBox pbxVenda;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip mspGeek;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

