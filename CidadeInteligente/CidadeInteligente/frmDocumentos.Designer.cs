namespace CidadeInteligente
{
    partial class frmDocumentos
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
            this.txtReservista = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCNH = new System.Windows.Forms.TextBox();
            this.txtCodPessoaD = new System.Windows.Forms.TextBox();
            this.lblReservista = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCodPessoa = new System.Windows.Forms.Label();
            this.lblTitleDoc = new System.Windows.Forms.Label();
            this.lclCTPS = new System.Windows.Forms.Label();
            this.txtCTPS = new System.Windows.Forms.TextBox();
            this.lblCNH = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.lblCodDoc = new System.Windows.Forms.Label();
            this.txtCodDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(492, 186);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Location = new System.Drawing.Point(402, 186);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 35);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtReservista
            // 
            this.txtReservista.Location = new System.Drawing.Point(165, 138);
            this.txtReservista.Name = "txtReservista";
            this.txtReservista.Size = new System.Drawing.Size(134, 20);
            this.txtReservista.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(402, 100);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(175, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(124, 173);
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(175, 20);
            this.txtCNH.TabIndex = 7;
            // 
            // txtCodPessoaD
            // 
            this.txtCodPessoaD.Location = new System.Drawing.Point(191, 100);
            this.txtCodPessoaD.Name = "txtCodPessoaD";
            this.txtCodPessoaD.Size = new System.Drawing.Size(108, 20);
            this.txtCodPessoaD.TabIndex = 2;
            // 
            // lblReservista
            // 
            this.lblReservista.AutoSize = true;
            this.lblReservista.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservista.Location = new System.Drawing.Point(41, 140);
            this.lblReservista.Name = "lblReservista";
            this.lblReservista.Size = new System.Drawing.Size(104, 16);
            this.lblReservista.TabIndex = 15;
            this.lblReservista.Text = "Reservista: ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(348, 102);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 16);
            this.lblCPF.TabIndex = 14;
            this.lblCPF.Text = "CPF: ";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(348, 66);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(40, 16);
            this.lblRG.TabIndex = 13;
            this.lblRG.Text = "RG: ";
            // 
            // lblCodPessoa
            // 
            this.lblCodPessoa.AutoSize = true;
            this.lblCodPessoa.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPessoa.Location = new System.Drawing.Point(41, 102);
            this.lblCodPessoa.Name = "lblCodPessoa";
            this.lblCodPessoa.Size = new System.Drawing.Size(128, 16);
            this.lblCodPessoa.TabIndex = 12;
            this.lblCodPessoa.Text = "Código Pessoa: ";
            // 
            // lblTitleDoc
            // 
            this.lblTitleDoc.AutoSize = true;
            this.lblTitleDoc.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleDoc.Location = new System.Drawing.Point(187, 19);
            this.lblTitleDoc.Name = "lblTitleDoc";
            this.lblTitleDoc.Size = new System.Drawing.Size(286, 23);
            this.lblTitleDoc.TabIndex = 11;
            this.lblTitleDoc.Text = "CADASTRO DOS DOCUMENTOS";
            // 
            // lclCTPS
            // 
            this.lclCTPS.AutoSize = true;
            this.lclCTPS.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclCTPS.Location = new System.Drawing.Point(348, 140);
            this.lclCTPS.Name = "lclCTPS";
            this.lclCTPS.Size = new System.Drawing.Size(56, 16);
            this.lclCTPS.TabIndex = 22;
            this.lclCTPS.Text = "CTPS: ";
            // 
            // txtCTPS
            // 
            this.txtCTPS.Location = new System.Drawing.Point(402, 138);
            this.txtCTPS.Name = "txtCTPS";
            this.txtCTPS.Size = new System.Drawing.Size(175, 20);
            this.txtCTPS.TabIndex = 6;
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNH.Location = new System.Drawing.Point(41, 175);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(48, 16);
            this.lblCNH.TabIndex = 24;
            this.lblCNH.Text = "CNH: ";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(402, 64);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(175, 20);
            this.txtRG.TabIndex = 3;
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Location = new System.Drawing.Point(44, 244);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.Size = new System.Drawing.Size(549, 150);
            this.dgvDocumentos.TabIndex = 26;
            // 
            // lblCodDoc
            // 
            this.lblCodDoc.AutoSize = true;
            this.lblCodDoc.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodDoc.Location = new System.Drawing.Point(41, 66);
            this.lblCodDoc.Name = "lblCodDoc";
            this.lblCodDoc.Size = new System.Drawing.Size(152, 16);
            this.lblCodDoc.TabIndex = 27;
            this.lblCodDoc.Text = "Código Documento: ";
            // 
            // txtCodDoc
            // 
            this.txtCodDoc.Location = new System.Drawing.Point(191, 64);
            this.txtCodDoc.Name = "txtCodDoc";
            this.txtCodDoc.Size = new System.Drawing.Size(108, 20);
            this.txtCodDoc.TabIndex = 1;
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 419);
            this.Controls.Add(this.txtCodDoc);
            this.Controls.Add(this.lblCodDoc);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblCNH);
            this.Controls.Add(this.txtCTPS);
            this.Controls.Add(this.lclCTPS);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtReservista);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCNH);
            this.Controls.Add(this.txtCodPessoaD);
            this.Controls.Add(this.lblReservista);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCodPessoa);
            this.Controls.Add(this.lblTitleDoc);
            this.Name = "frmDocumentos";
            this.Text = "frmDocumentos";
            this.Load += new System.EventHandler(this.frmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtReservista;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCNH;
        private System.Windows.Forms.TextBox txtCodPessoaD;
        private System.Windows.Forms.Label lblReservista;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCodPessoa;
        private System.Windows.Forms.Label lblTitleDoc;
        private System.Windows.Forms.Label lclCTPS;
        private System.Windows.Forms.TextBox txtCTPS;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.Label lblCodDoc;
        private System.Windows.Forms.TextBox txtCodDoc;
    }
}