namespace Prova2611_SarahSouza
{
    partial class Emprestimo
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
            this.txtDtDevolucao = new System.Windows.Forms.TextBox();
            this.txtNmLivro = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblDtDevolucao = new System.Windows.Forms.Label();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.cboAluno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisaLivro = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDtDevolucao
            // 
            this.txtDtDevolucao.Location = new System.Drawing.Point(139, 172);
            this.txtDtDevolucao.Name = "txtDtDevolucao";
            this.txtDtDevolucao.Size = new System.Drawing.Size(235, 20);
            this.txtDtDevolucao.TabIndex = 4;
            // 
            // txtNmLivro
            // 
            this.txtNmLivro.Location = new System.Drawing.Point(139, 66);
            this.txtNmLivro.Name = "txtNmLivro";
            this.txtNmLivro.Size = new System.Drawing.Size(235, 20);
            this.txtNmLivro.TabIndex = 1;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(22, 108);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(40, 13);
            this.lblTurma.TabIndex = 0;
            this.lblTurma.Text = "Turma:";
            // 
            // lblDtDevolucao
            // 
            this.lblDtDevolucao.AutoSize = true;
            this.lblDtDevolucao.Location = new System.Drawing.Point(22, 175);
            this.lblDtDevolucao.Name = "lblDtDevolucao";
            this.lblDtDevolucao.Size = new System.Drawing.Size(112, 13);
            this.lblDtDevolucao.TabIndex = 0;
            this.lblDtDevolucao.Text = "Data para Devolução:";
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Location = new System.Drawing.Point(22, 69);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(79, 13);
            this.lblNomeLivro.TabIndex = 0;
            this.lblNomeLivro.Text = "Nome do Livro:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(127, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Empréstimo de Livros:";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(24, 138);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno:";
            // 
            // cboTurma
            // 
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Location = new System.Drawing.Point(139, 100);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(121, 21);
            this.cboTurma.TabIndex = 2;
            this.cboTurma.SelectedIndexChanged += new System.EventHandler(this.cboTurma_SelectedIndexChanged);
            // 
            // cboAluno
            // 
            this.cboAluno.FormattingEnabled = true;
            this.cboAluno.Location = new System.Drawing.Point(139, 135);
            this.cboAluno.Name = "cboAluno";
            this.cboAluno.Size = new System.Drawing.Size(235, 21);
            this.cboAluno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livros em Uso:";
            // 
            // dgvLivro
            // 
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(27, 271);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(584, 150);
            this.dgvLivro.TabIndex = 0;
            this.dgvLivro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellContentDoubleClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(447, 161);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(447, 122);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(447, 80);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(22, 452);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(159, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquise os livros indisponíveis:";
            // 
            // txtPesquisaLivro
            // 
            this.txtPesquisaLivro.Location = new System.Drawing.Point(187, 449);
            this.txtPesquisaLivro.Name = "txtPesquisaLivro";
            this.txtPesquisaLivro.Size = new System.Drawing.Size(254, 20);
            this.txtPesquisaLivro.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(447, 446);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(593, 448);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(108, 20);
            this.txtId.TabIndex = 11;
            this.txtId.Text = "0";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(566, 451);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(610, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 62);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar Para Cadastro de Estudante";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 495);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisaLivro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAluno);
            this.Controls.Add(this.cboTurma);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txtDtDevolucao);
            this.Controls.Add(this.txtNmLivro);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblDtDevolucao);
            this.Controls.Add(this.lblNomeLivro);
            this.Controls.Add(this.lblTitle);
            this.Name = "Emprestimo";
            this.Text = "Emprestimo";
            this.Load += new System.EventHandler(this.Emprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDtDevolucao;
        private System.Windows.Forms.TextBox txtNmLivro;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblDtDevolucao;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.ComboBox cboAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaLivro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnVoltar;
    }
}