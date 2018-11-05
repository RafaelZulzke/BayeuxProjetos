namespace Definitivo
{
    partial class Form2
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btLocalizaG = new System.Windows.Forms.Button();
            this.txtbusca2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(17, 79);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(302, 20);
            this.txtCidade.TabIndex = 1;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(17, 130);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(63, 20);
            this.txtEstado.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(14, 11);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(91, 13);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome do Gerente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(375, 52);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(96, 27);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Visualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(579, 52);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(96, 27);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(477, 86);
            this.btFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(96, 27);
            this.btFechar.TabIndex = 12;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 288);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btLocalizaG
            // 
            this.btLocalizaG.Location = new System.Drawing.Point(477, 120);
            this.btLocalizaG.Name = "btLocalizaG";
            this.btLocalizaG.Size = new System.Drawing.Size(96, 27);
            this.btLocalizaG.TabIndex = 14;
            this.btLocalizaG.Text = "Localizar";
            this.btLocalizaG.UseVisualStyleBackColor = true;
            this.btLocalizaG.Click += new System.EventHandler(this.btLocalizaG_Click);
            // 
            // txtbusca2
            // 
            this.txtbusca2.Location = new System.Drawing.Point(17, 179);
            this.txtbusca2.Name = "txtbusca2";
            this.txtbusca2.Size = new System.Drawing.Size(302, 20);
            this.txtbusca2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Localizar Ger. de Fornecimento por Estado";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbusca2);
            this.Controls.Add(this.btLocalizaG);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gerente de Fornecimento";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btLocalizaG;
        private System.Windows.Forms.TextBox txtbusca2;
        private System.Windows.Forms.Label label1;
    }
}