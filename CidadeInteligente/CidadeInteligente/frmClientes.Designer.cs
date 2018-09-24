namespace CidadeInteligente
{
    partial class frmClientes
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDtInclusao = new System.Windows.Forms.TextBox();
            this.txtCodPessoaC = new System.Windows.Forms.TextBox();
            this.lblDtInclusao = new System.Windows.Forms.Label();
            this.lblCodPessoaC = new System.Windows.Forms.Label();
            this.lblTitleFunc = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(298, 161);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 35);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Location = new System.Drawing.Point(210, 161);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 35);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDtInclusao
            // 
            this.txtDtInclusao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtInclusao.Location = new System.Drawing.Point(170, 123);
            this.txtDtInclusao.Name = "txtDtInclusao";
            this.txtDtInclusao.Size = new System.Drawing.Size(150, 20);
            this.txtDtInclusao.TabIndex = 3;
            // 
            // txtCodPessoaC
            // 
            this.txtCodPessoaC.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPessoaC.Location = new System.Drawing.Point(170, 95);
            this.txtCodPessoaC.Name = "txtCodPessoaC";
            this.txtCodPessoaC.Size = new System.Drawing.Size(91, 20);
            this.txtCodPessoaC.TabIndex = 2;
            // 
            // lblDtInclusao
            // 
            this.lblDtInclusao.AutoSize = true;
            this.lblDtInclusao.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInclusao.Location = new System.Drawing.Point(24, 125);
            this.lblDtInclusao.Name = "lblDtInclusao";
            this.lblDtInclusao.Size = new System.Drawing.Size(152, 16);
            this.lblDtInclusao.TabIndex = 24;
            this.lblDtInclusao.Text = "Data da Inclusão: ";
            // 
            // lblCodPessoaC
            // 
            this.lblCodPessoaC.AutoSize = true;
            this.lblCodPessoaC.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPessoaC.Location = new System.Drawing.Point(24, 97);
            this.lblCodPessoaC.Name = "lblCodPessoaC";
            this.lblCodPessoaC.Size = new System.Drawing.Size(128, 16);
            this.lblCodPessoaC.TabIndex = 23;
            this.lblCodPessoaC.Text = "Código Pessoa: ";
            // 
            // lblTitleFunc
            // 
            this.lblTitleFunc.AutoSize = true;
            this.lblTitleFunc.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFunc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleFunc.Location = new System.Drawing.Point(124, 20);
            this.lblTitleFunc.Name = "lblTitleFunc";
            this.lblTitleFunc.Size = new System.Drawing.Size(262, 23);
            this.lblTitleFunc.TabIndex = 22;
            this.lblTitleFunc.Text = "CADASTRO DOS CLIENTES";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(27, 225);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(452, 150);
            this.dgvCliente.TabIndex = 35;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Location = new System.Drawing.Point(386, 161);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 35);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 409);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDtInclusao);
            this.Controls.Add(this.txtCodPessoaC);
            this.Controls.Add(this.lblDtInclusao);
            this.Controls.Add(this.lblCodPessoaC);
            this.Controls.Add(this.lblTitleFunc);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDtInclusao;
        private System.Windows.Forms.TextBox txtCodPessoaC;
        private System.Windows.Forms.Label lblDtInclusao;
        private System.Windows.Forms.Label lblCodPessoaC;
        private System.Windows.Forms.Label lblTitleFunc;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnPesquisar;
    }
}