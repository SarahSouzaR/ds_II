﻿namespace CidadeInteligente
{
    partial class frmFuncionarios
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
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCodPessoaF = new System.Windows.Forms.TextBox();
            this.lblRamal = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCodPessoaF = new System.Windows.Forms.Label();
            this.lblTitleFunc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(335, 163);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 35);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Location = new System.Drawing.Point(236, 163);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 35);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtRamal
            // 
            this.txtRamal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamal.Location = new System.Drawing.Point(125, 106);
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(134, 20);
            this.txtRamal.TabIndex = 19;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(435, 106);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(171, 20);
            this.txtSalario.TabIndex = 18;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(398, 64);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(208, 20);
            this.txtCargo.TabIndex = 17;
            // 
            // txtCodPessoaF
            // 
            this.txtCodPessoaF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPessoaF.Location = new System.Drawing.Point(168, 64);
            this.txtCodPessoaF.Name = "txtCodPessoaF";
            this.txtCodPessoaF.Size = new System.Drawing.Size(91, 20);
            this.txtCodPessoaF.TabIndex = 16;
            // 
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamal.Location = new System.Drawing.Point(22, 110);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(64, 16);
            this.lblRamal.TabIndex = 15;
            this.lblRamal.Text = "Ramal: ";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(319, 110);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(80, 16);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Salário: ";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(319, 66);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(64, 16);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.Text = "Cargo: ";
            // 
            // lblCodPessoaF
            // 
            this.lblCodPessoaF.AutoSize = true;
            this.lblCodPessoaF.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPessoaF.Location = new System.Drawing.Point(22, 66);
            this.lblCodPessoaF.Name = "lblCodPessoaF";
            this.lblCodPessoaF.Size = new System.Drawing.Size(128, 16);
            this.lblCodPessoaF.TabIndex = 12;
            this.lblCodPessoaF.Text = "Código Pessoa: ";
            // 
            // lblTitleFunc
            // 
            this.lblTitleFunc.AutoSize = true;
            this.lblTitleFunc.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFunc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleFunc.Location = new System.Drawing.Point(164, 18);
            this.lblTitleFunc.Name = "lblTitleFunc";
            this.lblTitleFunc.Size = new System.Drawing.Size(310, 23);
            this.lblTitleFunc.TabIndex = 11;
            this.lblTitleFunc.Text = "CADASTRO DOS FUNCIONÁRIOS";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 233);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtRamal);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCodPessoaF);
            this.Controls.Add(this.lblRamal);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblCodPessoaF);
            this.Controls.Add(this.lblTitleFunc);
            this.Name = "frmFuncionarios";
            this.Text = "frmFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtCodPessoaF;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCodPessoaF;
        private System.Windows.Forms.Label lblTitleFunc;
    }
}