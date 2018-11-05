namespace MEDIA_Visual
{
    partial class FormMedia
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
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n4c = new System.Windows.Forms.TextBox();
            this.n3c = new System.Windows.Forms.TextBox();
            this.n2c = new System.Windows.Forms.TextBox();
            this.n1c = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmaiorLB = new System.Windows.Forms.Label();
            this.nmaior = new System.Windows.Forms.TextBox();
            this.sitc = new System.Windows.Forms.TextBox();
            this.mediac = new System.Windows.Forms.TextBox();
            this.verifica = new System.Windows.Forms.Button();
            this.sit = new System.Windows.Forms.Label();
            this.mediaLb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(20, 50);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(39, 13);
            this.n1.TabIndex = 0;
            this.n1.Text = "Nota 1";
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(20, 95);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(39, 13);
            this.n2.TabIndex = 1;
            this.n2.Text = "Nota 2";
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Location = new System.Drawing.Point(20, 139);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(39, 13);
            this.n3.TabIndex = 2;
            this.n3.Text = "Nota 3";
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Location = new System.Drawing.Point(20, 181);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(39, 13);
            this.n4.TabIndex = 3;
            this.n4.Text = "Nota 4";
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n4c
            // 
            this.n4c.Location = new System.Drawing.Point(65, 178);
            this.n4c.Name = "n4c";
            this.n4c.Size = new System.Drawing.Size(100, 20);
            this.n4c.TabIndex = 4;
            this.n4c.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n3c
            // 
            this.n3c.Location = new System.Drawing.Point(65, 136);
            this.n3c.Name = "n3c";
            this.n3c.Size = new System.Drawing.Size(100, 20);
            this.n3c.TabIndex = 5;
            this.n3c.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // n2c
            // 
            this.n2c.Location = new System.Drawing.Point(65, 92);
            this.n2c.Name = "n2c";
            this.n2c.Size = new System.Drawing.Size(100, 20);
            this.n2c.TabIndex = 6;
            this.n2c.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // n1c
            // 
            this.n1c.Location = new System.Drawing.Point(65, 47);
            this.n1c.Name = "n1c";
            this.n1c.Size = new System.Drawing.Size(100, 20);
            this.n1c.TabIndex = 7;
            this.n1c.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmaiorLB);
            this.groupBox1.Controls.Add(this.nmaior);
            this.groupBox1.Controls.Add(this.sitc);
            this.groupBox1.Controls.Add(this.mediac);
            this.groupBox1.Controls.Add(this.n1c);
            this.groupBox1.Controls.Add(this.verifica);
            this.groupBox1.Controls.Add(this.n1);
            this.groupBox1.Controls.Add(this.sit);
            this.groupBox1.Controls.Add(this.n2c);
            this.groupBox1.Controls.Add(this.mediaLb);
            this.groupBox1.Controls.Add(this.n2);
            this.groupBox1.Controls.Add(this.n3c);
            this.groupBox1.Controls.Add(this.n3);
            this.groupBox1.Controls.Add(this.n4c);
            this.groupBox1.Controls.Add(this.n4);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // nmaiorLB
            // 
            this.nmaiorLB.AutoSize = true;
            this.nmaiorLB.Location = new System.Drawing.Point(258, 151);
            this.nmaiorLB.Name = "nmaiorLB";
            this.nmaiorLB.Size = new System.Drawing.Size(104, 13);
            this.nmaiorLB.TabIndex = 9;
            this.nmaiorLB.Text = "Maior Nota do Aluno";
            // 
            // nmaior
            // 
            this.nmaior.Location = new System.Drawing.Point(368, 148);
            this.nmaior.Name = "nmaior";
            this.nmaior.Size = new System.Drawing.Size(100, 20);
            this.nmaior.TabIndex = 10;
            this.nmaior.TextChanged += new System.EventHandler(this.nmaior_TextChanged);
            // 
            // sitc
            // 
            this.sitc.Location = new System.Drawing.Point(338, 112);
            this.sitc.Name = "sitc";
            this.sitc.Size = new System.Drawing.Size(100, 20);
            this.sitc.TabIndex = 13;
            // 
            // mediac
            // 
            this.mediac.Location = new System.Drawing.Point(338, 74);
            this.mediac.Name = "mediac";
            this.mediac.Size = new System.Drawing.Size(100, 20);
            this.mediac.TabIndex = 12;
            // 
            // verifica
            // 
            this.verifica.Location = new System.Drawing.Point(411, 207);
            this.verifica.Name = "verifica";
            this.verifica.Size = new System.Drawing.Size(75, 23);
            this.verifica.TabIndex = 11;
            this.verifica.Text = "Verificar";
            this.verifica.UseVisualStyleBackColor = true;
            this.verifica.Click += new System.EventHandler(this.verifica_Click);
            // 
            // sit
            // 
            this.sit.AutoSize = true;
            this.sit.Location = new System.Drawing.Point(283, 115);
            this.sit.Name = "sit";
            this.sit.Size = new System.Drawing.Size(49, 13);
            this.sit.TabIndex = 10;
            this.sit.Text = "Situação";
            // 
            // mediaLb
            // 
            this.mediaLb.AutoSize = true;
            this.mediaLb.Location = new System.Drawing.Point(296, 77);
            this.mediaLb.Name = "mediaLb";
            this.mediaLb.Size = new System.Drawing.Size(36, 13);
            this.mediaLb.TabIndex = 9;
            this.mediaLb.Text = "Média";
            // 
            // FormMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 415);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMedia";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMedia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.TextBox n4c;
        private System.Windows.Forms.TextBox n3c;
        private System.Windows.Forms.TextBox n2c;
        private System.Windows.Forms.TextBox n1c;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mediaLb;
        private System.Windows.Forms.Label sit;
        private System.Windows.Forms.Button verifica;
        private System.Windows.Forms.TextBox mediac;
        private System.Windows.Forms.TextBox sitc;
        private System.Windows.Forms.Label nmaiorLB;
        private System.Windows.Forms.TextBox nmaior;
    }
}

