namespace Estoque_de_Produtos_0409
{
    partial class Alterar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtCodigoAlterar = new System.Windows.Forms.TextBox();
            this.txtValorAlterar = new System.Windows.Forms.TextBox();
            this.txtProdutoAlterar = new System.Windows.Forms.TextBox();
            this.txtEstoqueAlterar = new System.Windows.Forms.TextBox();
            this.txtDataValAlterar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Validade";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(37, 227);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(163, 227);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtCodigoAlterar
            // 
            this.txtCodigoAlterar.Location = new System.Drawing.Point(95, 65);
            this.txtCodigoAlterar.Name = "txtCodigoAlterar";
            this.txtCodigoAlterar.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAlterar.TabIndex = 12;
            // 
            // txtValorAlterar
            // 
            this.txtValorAlterar.Location = new System.Drawing.Point(95, 117);
            this.txtValorAlterar.Name = "txtValorAlterar";
            this.txtValorAlterar.Size = new System.Drawing.Size(100, 20);
            this.txtValorAlterar.TabIndex = 13;
            // 
            // txtProdutoAlterar
            // 
            this.txtProdutoAlterar.Location = new System.Drawing.Point(95, 94);
            this.txtProdutoAlterar.Name = "txtProdutoAlterar";
            this.txtProdutoAlterar.Size = new System.Drawing.Size(100, 20);
            this.txtProdutoAlterar.TabIndex = 14;
            // 
            // txtEstoqueAlterar
            // 
            this.txtEstoqueAlterar.Location = new System.Drawing.Point(95, 143);
            this.txtEstoqueAlterar.Name = "txtEstoqueAlterar";
            this.txtEstoqueAlterar.Size = new System.Drawing.Size(100, 20);
            this.txtEstoqueAlterar.TabIndex = 15;
            // 
            // txtDataValAlterar
            // 
            this.txtDataValAlterar.Location = new System.Drawing.Point(95, 171);
            this.txtDataValAlterar.Name = "txtDataValAlterar";
            this.txtDataValAlterar.Size = new System.Drawing.Size(100, 20);
            this.txtDataValAlterar.TabIndex = 16;
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtDataValAlterar);
            this.Controls.Add(this.txtEstoqueAlterar);
            this.Controls.Add(this.txtProdutoAlterar);
            this.Controls.Add(this.txtValorAlterar);
            this.Controls.Add(this.txtCodigoAlterar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alterar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Alterar_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtCodigoAlterar;
        private System.Windows.Forms.TextBox txtValorAlterar;
        private System.Windows.Forms.TextBox txtProdutoAlterar;
        private System.Windows.Forms.TextBox txtEstoqueAlterar;
        private System.Windows.Forms.TextBox txtDataValAlterar;
    }
}

