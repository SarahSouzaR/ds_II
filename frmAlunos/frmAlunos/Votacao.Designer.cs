namespace frmAlunos
{
    partial class frmVotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVotacao));
            this.btnVotar = new System.Windows.Forms.Button();
            this.lblTituloVotacao = new System.Windows.Forms.Label();
            this.lblRMCandidato = new System.Windows.Forms.Label();
            this.lblRMEleitor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnVotar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVotar.FlatAppearance.BorderSize = 2;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Location = new System.Drawing.Point(97, 168);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            // 
            // lblTituloVotacao
            // 
            this.lblTituloVotacao.AutoSize = true;
            this.lblTituloVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVotacao.Location = new System.Drawing.Point(42, 29);
            this.lblTituloVotacao.Name = "lblTituloVotacao";
            this.lblTituloVotacao.Size = new System.Drawing.Size(213, 17);
            this.lblTituloVotacao.TabIndex = 3;
            this.lblTituloVotacao.Text = "Vote no Cantidato Escolhido";
            // 
            // lblRMCandidato
            // 
            this.lblRMCandidato.AutoSize = true;
            this.lblRMCandidato.Location = new System.Drawing.Point(28, 82);
            this.lblRMCandidato.Name = "lblRMCandidato";
            this.lblRMCandidato.Size = new System.Drawing.Size(93, 13);
            this.lblRMCandidato.TabIndex = 4;
            this.lblRMCandidato.Text = "RM do Candidato:";
            this.lblRMCandidato.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRMEleitor
            // 
            this.lblRMEleitor.AutoSize = true;
            this.lblRMEleitor.Location = new System.Drawing.Point(28, 119);
            this.lblRMEleitor.Name = "lblRMEleitor";
            this.lblRMEleitor.Size = new System.Drawing.Size(77, 13);
            this.lblRMEleitor.TabIndex = 5;
            this.lblRMEleitor.Text = "RM do Eleitor: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // frmVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRMEleitor);
            this.Controls.Add(this.lblRMCandidato);
            this.Controls.Add(this.lblTituloVotacao);
            this.Controls.Add(this.btnVotar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVotacao";
            this.Text = "Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Label lblTituloVotacao;
        private System.Windows.Forms.Label lblRMCandidato;
        private System.Windows.Forms.Label lblRMEleitor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

    }
}