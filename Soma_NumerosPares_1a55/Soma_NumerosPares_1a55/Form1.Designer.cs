namespace Soma_NumerosPares_1a55
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.relogiolabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.picimagem = new System.Windows.Forms.PictureBox();
            this.dglabrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soma dos Números Pares de 1 a 55";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soma
            // 
            this.soma.Enabled = false;
            this.soma.Location = new System.Drawing.Point(28, 251);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(205, 20);
            this.soma.TabIndex = 1;
            this.soma.TextChanged += new System.EventHandler(this.soma_TextChanged);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(12, 291);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(139, 23);
            this.calc.TabIndex = 2;
            this.calc.Text = "Calcular";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(170, 291);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 69);
            this.sair.TabIndex = 3;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // relogiolabel
            // 
            this.relogiolabel.AutoSize = true;
            this.relogiolabel.Location = new System.Drawing.Point(9, 9);
            this.relogiolabel.Name = "relogiolabel";
            this.relogiolabel.Size = new System.Drawing.Size(0, 13);
            this.relogiolabel.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Carregar Imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picimagem
            // 
            this.picimagem.Location = new System.Drawing.Point(270, 12);
            this.picimagem.Name = "picimagem";
            this.picimagem.Size = new System.Drawing.Size(620, 351);
            this.picimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimagem.TabIndex = 6;
            this.picimagem.TabStop = false;
            // 
            // dglabrir
            // 
            this.dglabrir.FileName = "dglabrir";
            this.dglabrir.FileOk += new System.ComponentModel.CancelEventHandler(this.dglabrir_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 375);
            this.Controls.Add(this.picimagem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.relogiolabel);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Soma dos Números Pares de 1 a 55";
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soma;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label relogiolabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picimagem;
        private System.Windows.Forms.OpenFileDialog dglabrir;
    }
}

