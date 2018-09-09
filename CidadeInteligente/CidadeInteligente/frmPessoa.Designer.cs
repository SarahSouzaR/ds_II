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
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.cdPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEstCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeInteligenteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeInteligenteDataSet = new CidadeInteligente.CidadeInteligenteDataSet();
            this.lblCdPessoa = new System.Windows.Forms.Label();
            this.txtCdPessoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeInteligenteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeInteligenteDataSet)).BeginInit();
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
            this.btnSalvar.Location = new System.Drawing.Point(318, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(416, 213);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 35);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AutoGenerateColumns = false;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdPessoaDataGridViewTextBoxColumn,
            this.nmPessoaDataGridViewTextBoxColumn,
            this.dsEnderecoDataGridViewTextBoxColumn,
            this.dsEstCivilDataGridViewTextBoxColumn,
            this.dtNascimentoDataGridViewTextBoxColumn});
            this.dgvPessoas.DataSource = this.pessoaBindingSource;
            this.dgvPessoas.Location = new System.Drawing.Point(18, 270);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(468, 150);
            this.dgvPessoas.TabIndex = 11;
            // 
            // cdPessoaDataGridViewTextBoxColumn
            // 
            this.cdPessoaDataGridViewTextBoxColumn.DataPropertyName = "cd_Pessoa";
            this.cdPessoaDataGridViewTextBoxColumn.HeaderText = "cd_Pessoa";
            this.cdPessoaDataGridViewTextBoxColumn.Name = "cdPessoaDataGridViewTextBoxColumn";
            // 
            // nmPessoaDataGridViewTextBoxColumn
            // 
            this.nmPessoaDataGridViewTextBoxColumn.DataPropertyName = "nm_Pessoa";
            this.nmPessoaDataGridViewTextBoxColumn.HeaderText = "nm_Pessoa";
            this.nmPessoaDataGridViewTextBoxColumn.Name = "nmPessoaDataGridViewTextBoxColumn";
            // 
            // dsEnderecoDataGridViewTextBoxColumn
            // 
            this.dsEnderecoDataGridViewTextBoxColumn.DataPropertyName = "ds_Endereco";
            this.dsEnderecoDataGridViewTextBoxColumn.HeaderText = "ds_Endereco";
            this.dsEnderecoDataGridViewTextBoxColumn.Name = "dsEnderecoDataGridViewTextBoxColumn";
            // 
            // dsEstCivilDataGridViewTextBoxColumn
            // 
            this.dsEstCivilDataGridViewTextBoxColumn.DataPropertyName = "ds_EstCivil";
            this.dsEstCivilDataGridViewTextBoxColumn.HeaderText = "ds_EstCivil";
            this.dsEstCivilDataGridViewTextBoxColumn.Name = "dsEstCivilDataGridViewTextBoxColumn";
            // 
            // dtNascimentoDataGridViewTextBoxColumn
            // 
            this.dtNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dt_Nascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.HeaderText = "dt_Nascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.Name = "dtNascimentoDataGridViewTextBoxColumn";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Classes.Pessoa);
            // 
            // cidadeInteligenteDataSetBindingSource
            // 
            this.cidadeInteligenteDataSetBindingSource.DataSource = this.cidadeInteligenteDataSet;
            this.cidadeInteligenteDataSetBindingSource.Position = 0;
            // 
            // cidadeInteligenteDataSet
            // 
            this.cidadeInteligenteDataSet.DataSetName = "CidadeInteligenteDataSet";
            this.cidadeInteligenteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCdPessoa
            // 
            this.lblCdPessoa.AutoSize = true;
            this.lblCdPessoa.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdPessoa.Location = new System.Drawing.Point(15, 213);
            this.lblCdPessoa.Name = "lblCdPessoa";
            this.lblCdPessoa.Size = new System.Drawing.Size(128, 16);
            this.lblCdPessoa.TabIndex = 12;
            this.lblCdPessoa.Text = "Código Pessoa: ";
            // 
            // txtCdPessoa
            // 
            this.txtCdPessoa.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdPessoa.Location = new System.Drawing.Point(149, 211);
            this.txtCdPessoa.Name = "txtCdPessoa";
            this.txtCdPessoa.Size = new System.Drawing.Size(84, 20);
            this.txtCdPessoa.TabIndex = 5;
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 442);
            this.Controls.Add(this.txtCdPessoa);
            this.Controls.Add(this.lblCdPessoa);
            this.Controls.Add(this.dgvPessoas);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeInteligenteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeInteligenteDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.BindingSource cidadeInteligenteDataSetBindingSource;
        private CidadeInteligenteDataSet cidadeInteligenteDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsEstCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.Label lblCdPessoa;
        private System.Windows.Forms.TextBox txtCdPessoa;
    }
}