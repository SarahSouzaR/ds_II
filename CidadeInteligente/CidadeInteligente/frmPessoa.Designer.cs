namespace CidadeInteligente
{
    partial class frmPessoa
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
            this.lblTitlePessoa = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEstCivil = new System.Windows.Forms.TextBox();
            this.txtDtNasc = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeInteligenteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPesquisaPessoa = new System.Windows.Forms.DataGridView();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeInteligenteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePessoa
            // 
            this.lblTitlePessoa.AutoSize = true;
            this.lblTitlePessoa.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePessoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitlePessoa.Location = new System.Drawing.Point(130, 19);
            this.lblTitlePessoa.Name = "lblTitlePessoa";
            this.lblTitlePessoa.Size = new System.Drawing.Size(250, 23);
            this.lblTitlePessoa.TabIndex = 0;
            this.lblTitlePessoa.Text = "CADASTRO DAS PESSOAS";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: ";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(15, 103);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(88, 16);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço: ";
            // 
            // lblEstCivil
            // 
            this.lblEstCivil.AutoSize = true;
            this.lblEstCivil.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCivil.Location = new System.Drawing.Point(15, 138);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(120, 16);
            this.lblEstCivil.TabIndex = 3;
            this.lblEstCivil.Text = "Estado Civil: ";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNasc.Location = new System.Drawing.Point(15, 173);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(168, 16);
            this.lblDtNasc.TabIndex = 4;
            this.lblDtNasc.Text = "Data de Nascimento: ";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(189, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(189, 101);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(265, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtEstCivil
            // 
            this.txtEstCivil.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstCivil.Location = new System.Drawing.Point(189, 136);
            this.txtEstCivil.Name = "txtEstCivil";
            this.txtEstCivil.Size = new System.Drawing.Size(190, 20);
            this.txtEstCivil.TabIndex = 3;
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtNasc.Location = new System.Drawing.Point(189, 171);
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(134, 20);
            this.txtDtNasc.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Location = new System.Drawing.Point(221, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 35);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(309, 213);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 35);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Classes.Pessoa);
            // 
            // dgvPesquisaPessoa
            // 
            this.dgvPesquisaPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaPessoa.Location = new System.Drawing.Point(32, 274);
            this.dgvPesquisaPessoa.Name = "dgvPesquisaPessoa";
            this.dgvPesquisaPessoa.Size = new System.Drawing.Size(452, 150);
            this.dgvPesquisaPessoa.TabIndex = 7;
            this.dgvPesquisaPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisaPessoa_CellDoubleClick);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnApagar.Location = new System.Drawing.Point(133, 213);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(82, 35);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Location = new System.Drawing.Point(391, 213);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 35);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 447);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.dgvPesquisaPessoa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDtNasc);
            this.Controls.Add(this.txtEstCivil);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblEstCivil);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitlePessoa);
            this.Name = "frmPessoa";
            this.Text = "frmPessoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPessoa_FormClosing);
            this.Load += new System.EventHandler(this.frmPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeInteligenteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePessoa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEstCivil;
        private System.Windows.Forms.TextBox txtDtNasc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.BindingSource cidadeInteligenteDataSetBindingSource;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.DataGridView dgvPesquisaPessoa;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}