namespace EtecMetodoGenerics
{
    partial class Pedidos
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
            this.gdvPedidos = new System.Windows.Forms.DataGridView();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.nmProduto = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.nmMarca = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDtPedido = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbData = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.clientePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvPedidos
            // 
            this.gdvPedidos.AutoGenerateColumns = false;
            this.gdvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvPedidos.DataSource = this.clientePedidoBindingSource;
            this.gdvPedidos.Location = new System.Drawing.Point(12, 158);
            this.gdvPedidos.Name = "gdvPedidos";
            this.gdvPedidos.Size = new System.Drawing.Size(545, 195);
            this.gdvPedidos.TabIndex = 0;
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(73, 45);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(134, 20);
            this.txbProduto.TabIndex = 1;
            // 
            // nmProduto
            // 
            this.nmProduto.AutoSize = true;
            this.nmProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmProduto.Location = new System.Drawing.Point(8, 48);
            this.nmProduto.Name = "nmProduto";
            this.nmProduto.Size = new System.Drawing.Size(55, 13);
            this.nmProduto.TabIndex = 2;
            this.nmProduto.Text = "Produto:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(421, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // nmMarca
            // 
            this.nmMarca.AutoSize = true;
            this.nmMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMarca.Location = new System.Drawing.Point(17, 125);
            this.nmMarca.Name = "nmMarca";
            this.nmMarca.Size = new System.Drawing.Size(46, 13);
            this.nmMarca.TabIndex = 4;
            this.nmMarca.Text = "Marca:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(421, 45);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(421, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDtPedido
            // 
            this.lblDtPedido.AutoSize = true;
            this.lblDtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtPedido.Location = new System.Drawing.Point(21, 74);
            this.lblDtPedido.Name = "lblDtPedido";
            this.lblDtPedido.Size = new System.Drawing.Size(42, 13);
            this.lblDtPedido.TabIndex = 8;
            this.lblDtPedido.Text = "Data: ";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(73, 122);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(134, 20);
            this.txbMarca.TabIndex = 5;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(73, 70);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(134, 20);
            this.txbData.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(19, 99);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(44, 13);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(73, 16);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(134, 20);
            this.txbID.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(28, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID:";
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(73, 96);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(134, 20);
            this.txbPreco.TabIndex = 13;
            // 
            // clientePedidoBindingSource
            // 
            this.clientePedidoBindingSource.DataSource = typeof(Classes.ClientePedido);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(588, 398);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.lblDtPedido);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.nmMarca);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.nmProduto);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.gdvPedidos);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvPedidos;
        private System.Windows.Forms.BindingSource clientePedidoBindingSource;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label nmProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label nmMarca;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDtPedido;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbPreco;
    }
}