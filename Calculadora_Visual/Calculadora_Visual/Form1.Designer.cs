namespace Calculadora_Visual
{
    partial class Calculadora
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
            this.n1label = new System.Windows.Forms.Label();
            this.n2label = new System.Windows.Forms.Label();
            this.rlabel = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.zerar = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.pot = new System.Windows.Forms.Button();
            this.desligar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1label
            // 
            this.n1label.AutoSize = true;
            this.n1label.Location = new System.Drawing.Point(12, 28);
            this.n1label.Name = "n1label";
            this.n1label.Size = new System.Drawing.Size(71, 13);
            this.n1label.TabIndex = 0;
            this.n1label.Text = "1º Número (x)";
            // 
            // n2label
            // 
            this.n2label.AutoSize = true;
            this.n2label.Location = new System.Drawing.Point(229, 28);
            this.n2label.Name = "n2label";
            this.n2label.Size = new System.Drawing.Size(71, 13);
            this.n2label.TabIndex = 1;
            this.n2label.Text = "2º Número (y)";
            // 
            // rlabel
            // 
            this.rlabel.AutoSize = true;
            this.rlabel.Location = new System.Drawing.Point(139, 85);
            this.rlabel.Name = "rlabel";
            this.rlabel.Size = new System.Drawing.Size(55, 13);
            this.rlabel.TabIndex = 2;
            this.rlabel.Text = "Resultado";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(88, 25);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 3;
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(200, 82);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 4;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(306, 25);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 5;
            // 
            // adicao
            // 
            this.adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicao.Location = new System.Drawing.Point(12, 169);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(75, 61);
            this.adicao.TabIndex = 6;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(113, 169);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(75, 61);
            this.subtracao.TabIndex = 7;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(205, 169);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(75, 61);
            this.raiz.TabIndex = 8;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // zerar
            // 
            this.zerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zerar.Location = new System.Drawing.Point(306, 169);
            this.zerar.Name = "zerar";
            this.zerar.Size = new System.Drawing.Size(75, 61);
            this.zerar.TabIndex = 9;
            this.zerar.Text = "C";
            this.zerar.UseVisualStyleBackColor = true;
            this.zerar.Click += new System.EventHandler(this.zerar_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(12, 255);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 67);
            this.mult.TabIndex = 10;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(113, 255);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 67);
            this.div.TabIndex = 11;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // pot
            // 
            this.pot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pot.Location = new System.Drawing.Point(205, 255);
            this.pot.Name = "pot";
            this.pot.Size = new System.Drawing.Size(75, 67);
            this.pot.TabIndex = 12;
            this.pot.Text = "x ^ y";
            this.pot.UseVisualStyleBackColor = true;
            this.pot.Click += new System.EventHandler(this.pot_Click);
            // 
            // desligar
            // 
            this.desligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desligar.Location = new System.Drawing.Point(306, 255);
            this.desligar.Name = "desligar";
            this.desligar.Size = new System.Drawing.Size(75, 67);
            this.desligar.TabIndex = 13;
            this.desligar.Text = "OFF";
            this.desligar.UseVisualStyleBackColor = true;
            this.desligar.Click += new System.EventHandler(this.desligar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(429, 350);
            this.Controls.Add(this.desligar);
            this.Controls.Add(this.pot);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.zerar);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.rlabel);
            this.Controls.Add(this.n2label);
            this.Controls.Add(this.n1label);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label n1label;
        private System.Windows.Forms.Label n2label;
        private System.Windows.Forms.Label rlabel;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button zerar;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button pot;
        private System.Windows.Forms.Button desligar;
    }
}

