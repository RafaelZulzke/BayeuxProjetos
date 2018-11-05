namespace Menu
{
	partial class FRMPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Nusados = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularMédiaToolStripMenuItem,
            this.somarValoresToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1,
            this.sairToolStripMenuItem2});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // calcularMédiaToolStripMenuItem
            // 
            this.calcularMédiaToolStripMenuItem.Name = "calcularMédiaToolStripMenuItem";
            this.calcularMédiaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.calcularMédiaToolStripMenuItem.Text = "&Calcular Média";
            this.calcularMédiaToolStripMenuItem.Click += new System.EventHandler(this.calcularMédiaToolStripMenuItem_Click);
            // 
            // somarValoresToolStripMenuItem
            // 
            this.somarValoresToolStripMenuItem.Name = "somarValoresToolStripMenuItem";
            this.somarValoresToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.somarValoresToolStripMenuItem.Text = "&Maior Número";
            this.somarValoresToolStripMenuItem.Click += new System.EventHandler(this.somarValoresToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sairToolStripMenuItem.Text = "Menor Número";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.sairToolStripMenuItem1.Text = "Soma";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem2
            // 
            this.sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            this.sairToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.sairToolStripMenuItem2.Text = "Sair";
            this.sairToolStripMenuItem2.Click += new System.EventHandler(this.sairToolStripMenuItem2_Click);
            // 
            // Nusados
            // 
            this.Nusados.FormattingEnabled = true;
            this.Nusados.Location = new System.Drawing.Point(12, 84);
            this.Nusados.Name = "Nusados";
            this.Nusados.Size = new System.Drawing.Size(120, 95);
            this.Nusados.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entrada de Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nusados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somarValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem2;
        private System.Windows.Forms.ListBox Nusados;
        private System.Windows.Forms.Button button1;
	}
}

