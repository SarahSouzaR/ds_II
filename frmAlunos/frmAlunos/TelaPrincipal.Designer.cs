namespace frmAlunos
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.candidatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleitorarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatarToolStripMenuItem,
            this.logarToolStripMenuItem,
            this.eleitorarToolStripMenuItem,
            this.candidatarToolStripMenuItem1,
            this.votarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // candidatarToolStripMenuItem
            // 
            this.candidatarToolStripMenuItem.Name = "candidatarToolStripMenuItem";
            this.candidatarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.candidatarToolStripMenuItem.Text = "Cadastrar";
            this.candidatarToolStripMenuItem.Click += new System.EventHandler(this.candidatarToolStripMenuItem_Click);
            // 
            // eleitorarToolStripMenuItem
            // 
            this.eleitorarToolStripMenuItem.Name = "eleitorarToolStripMenuItem";
            this.eleitorarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eleitorarToolStripMenuItem.Text = "Eleitorar";
            this.eleitorarToolStripMenuItem.Click += new System.EventHandler(this.eleitorarToolStripMenuItem_Click);
            // 
            // candidatarToolStripMenuItem1
            // 
            this.candidatarToolStripMenuItem1.Name = "candidatarToolStripMenuItem1";
            this.candidatarToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.candidatarToolStripMenuItem1.Text = "Candidatar";
            this.candidatarToolStripMenuItem1.Click += new System.EventHandler(this.candidatarToolStripMenuItem1_Click);
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.logarToolStripMenuItem.Text = "Logar";
            this.logarToolStripMenuItem.Click += new System.EventHandler(this.logarToolStripMenuItem_Click);
            // 
            // votarToolStripMenuItem
            // 
            this.votarToolStripMenuItem.Name = "votarToolStripMenuItem";
            this.votarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.votarToolStripMenuItem.Text = "Votar";
            this.votarToolStripMenuItem.Click += new System.EventHandler(this.votarToolStripMenuItem_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem candidatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleitorarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votarToolStripMenuItem;
    }
}