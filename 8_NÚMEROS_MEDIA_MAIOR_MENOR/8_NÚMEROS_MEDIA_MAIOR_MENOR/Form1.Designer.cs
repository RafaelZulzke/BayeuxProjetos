namespace _8_NÚMEROS_MEDIA_MAIOR_MENOR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medianum = new System.Windows.Forms.TextBox();
            this.maiornum = new System.Windows.Forms.TextBox();
            this.menornum = new System.Windows.Forms.TextBox();
            this.Verificanum = new System.Windows.Forms.Button();
            this.Nusados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Media dos Numeros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maior Numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menor Numero";
            // 
            // medianum
            // 
            this.medianum.Enabled = false;
            this.medianum.Location = new System.Drawing.Point(136, 35);
            this.medianum.Name = "medianum";
            this.medianum.Size = new System.Drawing.Size(100, 20);
            this.medianum.TabIndex = 3;
            this.medianum.TextChanged += new System.EventHandler(this.medianum_TextChanged);
            // 
            // maiornum
            // 
            this.maiornum.Enabled = false;
            this.maiornum.Location = new System.Drawing.Point(136, 73);
            this.maiornum.Name = "maiornum";
            this.maiornum.Size = new System.Drawing.Size(100, 20);
            this.maiornum.TabIndex = 4;
            // 
            // menornum
            // 
            this.menornum.Enabled = false;
            this.menornum.Location = new System.Drawing.Point(136, 114);
            this.menornum.Name = "menornum";
            this.menornum.Size = new System.Drawing.Size(100, 20);
            this.menornum.TabIndex = 5;
            // 
            // Verificanum
            // 
            this.Verificanum.Location = new System.Drawing.Point(152, 198);
            this.Verificanum.Name = "Verificanum";
            this.Verificanum.Size = new System.Drawing.Size(106, 23);
            this.Verificanum.TabIndex = 6;
            this.Verificanum.Text = "Inserção de Dados";
            this.Verificanum.UseVisualStyleBackColor = true;
            this.Verificanum.Click += new System.EventHandler(this.Verificanum_Click);
            // 
            // Nusados
            // 
            this.Nusados.FormattingEnabled = true;
            this.Nusados.Location = new System.Drawing.Point(12, 142);
            this.Nusados.Name = "Nusados";
            this.Nusados.Size = new System.Drawing.Size(120, 108);
            this.Nusados.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Nusados);
            this.Controls.Add(this.Verificanum);
            this.Controls.Add(this.menornum);
            this.Controls.Add(this.maiornum);
            this.Controls.Add(this.medianum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medianum;
        private System.Windows.Forms.TextBox maiornum;
        private System.Windows.Forms.TextBox menornum;
        private System.Windows.Forms.Button Verificanum;
        private System.Windows.Forms.ListBox Nusados;
    }
}

