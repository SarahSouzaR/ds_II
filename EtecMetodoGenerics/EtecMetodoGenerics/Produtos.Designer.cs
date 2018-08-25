namespace EtecMetodoGenerics
{
    partial class Produtos
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
            this.components = new System.ComponentModel.Container();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblPrecoUnit = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbFabric = new System.Windows.Forms.TextBox();
            this.txbPrecoUnit = new System.Windows.Forms.TextBox();
            this.txbValidade = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblTelFabric = new System.Windows.Forms.Label();
            this.txbTelFabric = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.clientePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(29, 213);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(499, 148);
            this.dgvProdutos.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(26, 28);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(55, 13);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(26, 54);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(71, 13);
            this.lblFabricante.TabIndex = 2;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblPrecoUnit
            // 
            this.lblPrecoUnit.AutoSize = true;
            this.lblPrecoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnit.Location = new System.Drawing.Point(26, 80);
            this.lblPrecoUnit.Name = "lblPrecoUnit";
            this.lblPrecoUnit.Size = new System.Drawing.Size(71, 13);
            this.lblPrecoUnit.TabIndex = 3;
            this.lblPrecoUnit.Text = "Preço Unit:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(26, 106);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(76, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(26, 132);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(60, 13);
            this.lblValidade.TabIndex = 5;
            this.lblValidade.Text = "Validade:";
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(138, 25);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(152, 20);
            this.txbProduto.TabIndex = 6;
            // 
            // txbFabric
            // 
            this.txbFabric.Location = new System.Drawing.Point(138, 51);
            this.txbFabric.Name = "txbFabric";
            this.txbFabric.Size = new System.Drawing.Size(152, 20);
            this.txbFabric.TabIndex = 7;
            // 
            // txbPrecoUnit
            // 
            this.txbPrecoUnit.Location = new System.Drawing.Point(138, 77);
            this.txbPrecoUnit.Name = "txbPrecoUnit";
            this.txbPrecoUnit.Size = new System.Drawing.Size(152, 20);
            this.txbPrecoUnit.TabIndex = 8;
            // 
            // txbValidade
            // 
            this.txbValidade.Location = new System.Drawing.Point(138, 129);
            this.txbValidade.Name = "txbValidade";
            this.txbValidade.Size = new System.Drawing.Size(152, 20);
            this.txbValidade.TabIndex = 9;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(138, 103);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(152, 20);
            this.txbQuantidade.TabIndex = 10;
            // 
            // lblTelFabric
            // 
            this.lblTelFabric.AutoSize = true;
            this.lblTelFabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFabric.Location = new System.Drawing.Point(26, 161);
            this.lblTelFabric.Name = "lblTelFabric";
            this.lblTelFabric.Size = new System.Drawing.Size(97, 13);
            this.lblTelFabric.TabIndex = 11;
            this.lblTelFabric.Text = "Tel. Fabricante:";
            // 
            // txbTelFabric
            // 
            this.txbTelFabric.Location = new System.Drawing.Point(138, 158);
            this.txbTelFabric.Name = "txbTelFabric";
            this.txbTelFabric.Size = new System.Drawing.Size(152, 20);
            this.txbTelFabric.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(373, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(373, 70);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(373, 122);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(26, 189);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "ID:";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(138, 186);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(152, 20);
            this.txbId.TabIndex = 17;
            // 
            // clientePedidoBindingSource
            // 
            this.clientePedidoBindingSource.DataSource = typeof(Classes.ClientePedido);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 373);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txbTelFabric);
            this.Controls.Add(this.lblTelFabric);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbValidade);
            this.Controls.Add(this.txbPrecoUnit);
            this.Controls.Add(this.txbFabric);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPrecoUnit);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblPrecoUnit;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbFabric;
        private System.Windows.Forms.TextBox txbPrecoUnit;
        private System.Windows.Forms.TextBox txbValidade;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblTelFabric;
        private System.Windows.Forms.TextBox txbTelFabric;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.BindingSource clientePedidoBindingSource;
    }
}