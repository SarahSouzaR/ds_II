namespace ScratchOut
{
    partial class frmTarefas
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
            this.lblTopo = new System.Windows.Forms.Label();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDtTermino = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtPrazo = new System.Windows.Forms.MaskedTextBox();
            this.txtDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDtTermino = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopo.Location = new System.Drawing.Point(570, 16);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(120, 26);
            this.lblTopo.TabIndex = 0;
            this.lblTopo.Text = "TAREFAS";
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefa.Location = new System.Drawing.Point(21, 85);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(123, 16);
            this.lblTarefa.TabIndex = 1;
            this.lblTarefa.Text = "Título da Tarefa:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(18, 154);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(83, 16);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.Location = new System.Drawing.Point(268, 85);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(56, 16);
            this.lblPrazo.TabIndex = 3;
            this.lblPrazo.Text = "Prazo: ";
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInicio.Location = new System.Drawing.Point(410, 85);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(108, 16);
            this.lblDtInicio.TabIndex = 4;
            this.lblDtInicio.Text = "Data de Início:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 16);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID Tarefa:";
            // 
            // lblDtTermino
            // 
            this.lblDtTermino.AutoSize = true;
            this.lblDtTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtTermino.Location = new System.Drawing.Point(543, 85);
            this.lblDtTermino.Name = "lblDtTermino";
            this.lblDtTermino.Size = new System.Drawing.Size(128, 16);
            this.lblDtTermino.TabIndex = 6;
            this.lblDtTermino.Text = "Data do Término:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(21, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(21, 110);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(195, 20);
            this.txtTarefa.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(21, 179);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(233, 66);
            this.txtDescricao.TabIndex = 9;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Location = new System.Drawing.Point(24, 282);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.Size = new System.Drawing.Size(647, 228);
            this.dgvTarefas.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(319, 195);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(506, 195);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(587, 195);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(425, 195);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(569, 555);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Pesquisar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Título da Tarefa:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(360, 556);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(198, 20);
            this.textBox7.TabIndex = 20;
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(271, 110);
            this.txtPrazo.Mask = "__/__/____ ";
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(100, 20);
            this.txtPrazo.TabIndex = 21;
            // 
            // txtDtInicio
            // 
            this.txtDtInicio.Location = new System.Drawing.Point(413, 110);
            this.txtDtInicio.Mask = "__/__/____";
            this.txtDtInicio.Name = "txtDtInicio";
            this.txtDtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtDtInicio.TabIndex = 22;
            // 
            // txtDtTermino
            // 
            this.txtDtTermino.Location = new System.Drawing.Point(546, 110);
            this.txtDtTermino.Mask = "__/__/____";
            this.txtDtTermino.Name = "txtDtTermino";
            this.txtDtTermino.Size = new System.Drawing.Size(100, 20);
            this.txtDtTermino.TabIndex = 23;
            // 
            // frmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 614);
            this.Controls.Add(this.txtDtTermino);
            this.Controls.Add(this.txtDtInicio);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvTarefas);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDtTermino);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDtInicio);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lblTopo);
            this.Name = "frmTarefas";
            this.Text = "Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopo;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDtTermino;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.MaskedTextBox txtPrazo;
        private System.Windows.Forms.MaskedTextBox txtDtInicio;
        private System.Windows.Forms.MaskedTextBox txtDtTermino;
    }
}

