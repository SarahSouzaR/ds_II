namespace CadastroPessoa
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNmFuncionario = new System.Windows.Forms.TextBox();
            this.dgvFuncionarioMemoria = new System.Windows.Forms.DataGridView();
            this.btnSalvarOff = new System.Windows.Forms.Button();
            this.btnSalvarOnline = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.cboNmFuncionario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioMemoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(43, 259);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNmFuncionario
            // 
            this.txtNmFuncionario.Location = new System.Drawing.Point(102, 258);
            this.txtNmFuncionario.Name = "txtNmFuncionario";
            this.txtNmFuncionario.Size = new System.Drawing.Size(243, 20);
            this.txtNmFuncionario.TabIndex = 1;
            // 
            // dgvFuncionarioMemoria
            // 
            this.dgvFuncionarioMemoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarioMemoria.Location = new System.Drawing.Point(37, 63);
            this.dgvFuncionarioMemoria.Name = "dgvFuncionarioMemoria";
            this.dgvFuncionarioMemoria.Size = new System.Drawing.Size(668, 161);
            this.dgvFuncionarioMemoria.TabIndex = 2;
            // 
            // btnSalvarOff
            // 
            this.btnSalvarOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarOff.Location = new System.Drawing.Point(433, 345);
            this.btnSalvarOff.Name = "btnSalvarOff";
            this.btnSalvarOff.Size = new System.Drawing.Size(125, 32);
            this.btnSalvarOff.TabIndex = 5;
            this.btnSalvarOff.Text = "Salvar Off-Line";
            this.btnSalvarOff.UseVisualStyleBackColor = true;
            this.btnSalvarOff.Click += new System.EventHandler(this.btnSalvarOff_Click);
            // 
            // btnSalvarOnline
            // 
            this.btnSalvarOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarOnline.Location = new System.Drawing.Point(564, 345);
            this.btnSalvarOnline.Name = "btnSalvarOnline";
            this.btnSalvarOnline.Size = new System.Drawing.Size(166, 32);
            this.btnSalvarOnline.TabIndex = 6;
            this.btnSalvarOnline.Text = "Enviar para o Banco";
            this.btnSalvarOnline.UseVisualStyleBackColor = true;
            this.btnSalvarOnline.Click += new System.EventHandler(this.btnSalvarOnline_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Endereço:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(471, 291);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(190, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(471, 258);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(221, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // cboNmFuncionario
            // 
            this.cboNmFuncionario.FormattingEnabled = true;
            this.cboNmFuncionario.Location = new System.Drawing.Point(102, 26);
            this.cboNmFuncionario.Name = "cboNmFuncionario";
            this.cboNmFuncionario.Size = new System.Drawing.Size(378, 21);
            this.cboNmFuncionario.TabIndex = 7;
            this.cboNmFuncionario.SelectedValueChanged += new System.EventHandler(this.cboNmFuncionario_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(753, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboNmFuncionario);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarOnline);
            this.Controls.Add(this.btnSalvarOff);
            this.Controls.Add(this.dgvFuncionarioMemoria);
            this.Controls.Add(this.txtNmFuncionario);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioMemoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNmFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionarioMemoria;
        private System.Windows.Forms.Button btnSalvarOff;
        private System.Windows.Forms.Button btnSalvarOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ComboBox cboNmFuncionario;
        private System.Windows.Forms.Label label4;
    }
}

