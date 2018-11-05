namespace Estoque_de_Produtos_0409
{
    partial class Incluir
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
            this.txtDataValIncluir = new System.Windows.Forms.TextBox();
            this.txtEstoqueIncluir = new System.Windows.Forms.TextBox();
            this.txtProdutoIncluir = new System.Windows.Forms.TextBox();
            this.txtValorIncluir = new System.Windows.Forms.TextBox();
            this.txtCodigoIncluir = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDataValIncluir
            // 
            this.txtDataValIncluir.Location = new System.Drawing.Point(116, 145);
            this.txtDataValIncluir.Name = "txtDataValIncluir";
            this.txtDataValIncluir.Size = new System.Drawing.Size(100, 20);
            this.txtDataValIncluir.TabIndex = 40;
            // 
            // txtEstoqueIncluir
            // 
            this.txtEstoqueIncluir.Location = new System.Drawing.Point(116, 117);
            this.txtEstoqueIncluir.Name = "txtEstoqueIncluir";
            this.txtEstoqueIncluir.Size = new System.Drawing.Size(100, 20);
            this.txtEstoqueIncluir.TabIndex = 39;
            // 
            // txtProdutoIncluir
            // 
            this.txtProdutoIncluir.Location = new System.Drawing.Point(116, 65);
            this.txtProdutoIncluir.Name = "txtProdutoIncluir";
            this.txtProdutoIncluir.Size = new System.Drawing.Size(100, 20);
            this.txtProdutoIncluir.TabIndex = 38;
            // 
            // txtValorIncluir
            // 
            this.txtValorIncluir.Location = new System.Drawing.Point(116, 91);
            this.txtValorIncluir.Name = "txtValorIncluir";
            this.txtValorIncluir.Size = new System.Drawing.Size(100, 20);
            this.txtValorIncluir.TabIndex = 37;
            // 
            // txtCodigoIncluir
            // 
            this.txtCodigoIncluir.Location = new System.Drawing.Point(116, 39);
            this.txtCodigoIncluir.Name = "txtCodigoIncluir";
            this.txtCodigoIncluir.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoIncluir.TabIndex = 36;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(184, 201);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 35;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(58, 201);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 34;
            this.btIncluir.Text = "Excluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data de Validade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código";
            // 
            // Incluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtDataValIncluir);
            this.Controls.Add(this.txtEstoqueIncluir);
            this.Controls.Add(this.txtProdutoIncluir);
            this.Controls.Add(this.txtValorIncluir);
            this.Controls.Add(this.txtCodigoIncluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Incluir";
            this.Text = "Incluir";
            this.Load += new System.EventHandler(this.Incluir_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataValIncluir;
        private System.Windows.Forms.TextBox txtEstoqueIncluir;
        private System.Windows.Forms.TextBox txtProdutoIncluir;
        private System.Windows.Forms.TextBox txtValorIncluir;
        private System.Windows.Forms.TextBox txtCodigoIncluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}