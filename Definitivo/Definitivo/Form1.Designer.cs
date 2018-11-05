namespace Definitivo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDeFabricaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btExcFor = new System.Windows.Forms.Button();
            this.btLocaliza = new System.Windows.Forms.Button();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDeFabricaçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // localDeFabricaçãoToolStripMenuItem
            // 
            this.localDeFabricaçãoToolStripMenuItem.Name = "localDeFabricaçãoToolStripMenuItem";
            this.localDeFabricaçãoToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.localDeFabricaçãoToolStripMenuItem.Text = "Cadastrar Gerente de Fornecimento";
            this.localDeFabricaçãoToolStripMenuItem.Click += new System.EventHandler(this.localDeFabricaçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(27, 43);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(157, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome do Fornecedor (Empresa)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email do Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 62);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(477, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(32, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(477, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(532, 43);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(90, 29);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(532, 130);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(90, 29);
            this.btAtualizar.TabIndex = 6;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 58);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cadastro de Gerentes de Fornecimento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(629, 107);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(112, 52);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sair do Sistema";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 305);
            this.dataGridView1.TabIndex = 9;
            // 
            // btExcFor
            // 
            this.btExcFor.Location = new System.Drawing.Point(532, 85);
            this.btExcFor.Name = "btExcFor";
            this.btExcFor.Size = new System.Drawing.Size(90, 29);
            this.btExcFor.TabIndex = 10;
            this.btExcFor.Text = "Excluir";
            this.btExcFor.UseVisualStyleBackColor = true;
            this.btExcFor.Click += new System.EventHandler(this.btExcFor_Click);
            // 
            // btLocaliza
            // 
            this.btLocaliza.Location = new System.Drawing.Point(532, 175);
            this.btLocaliza.Name = "btLocaliza";
            this.btLocaliza.Size = new System.Drawing.Size(90, 29);
            this.btLocaliza.TabIndex = 11;
            this.btLocaliza.Text = "Localizar";
            this.btLocaliza.UseVisualStyleBackColor = true;
            this.btLocaliza.Click += new System.EventHandler(this.btLocaliza_Click);
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(31, 180);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(477, 20);
            this.txtbusca.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Localizar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.btLocaliza);
            this.Controls.Add(this.btExcFor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cadastro de Fornecedor (Empresa)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDeFabricaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btExcFor;
        private System.Windows.Forms.Button btLocaliza;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label label1;
    }
}

