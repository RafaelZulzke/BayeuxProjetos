namespace Impar_Par_Visual
{
    partial class FrmVerifica
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.btVerifica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(155, 35);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(151, 22);
            this.txtnum.TabIndex = 1;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblresultado.Location = new System.Drawing.Point(12, 83);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(342, 24);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btCancela);
            this.groupBox1.Controls.Add(this.btVerifica);
            this.groupBox1.Location = new System.Drawing.Point(8, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(261, 20);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCancela
            // 
            this.btCancela.Location = new System.Drawing.Point(138, 20);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(75, 23);
            this.btCancela.TabIndex = 1;
            this.btCancela.Text = "&Cancela";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // btVerifica
            // 
            this.btVerifica.Location = new System.Drawing.Point(19, 20);
            this.btVerifica.Name = "btVerifica";
            this.btVerifica.Size = new System.Drawing.Size(75, 23);
            this.btVerifica.TabIndex = 0;
            this.btVerifica.Text = "&Verifica";
            this.btVerifica.UseVisualStyleBackColor = true;
            this.btVerifica.Click += new System.EventHandler(this.btVerifica_Click);
            // 
            // FrmVerifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmVerifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de Números";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Button btVerifica;

    }
}

