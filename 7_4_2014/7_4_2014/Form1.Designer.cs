namespace _7_4_2014
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
            this.listidades = new System.Windows.Forms.ListBox();
            this.entdados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.somaids = new System.Windows.Forms.TextBox();
            this.Mdidades = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listidades
            // 
            this.listidades.FormattingEnabled = true;
            this.listidades.Location = new System.Drawing.Point(12, 12);
            this.listidades.Name = "listidades";
            this.listidades.Size = new System.Drawing.Size(120, 212);
            this.listidades.TabIndex = 0;
            this.listidades.SelectedIndexChanged += new System.EventHandler(this.listidades_SelectedIndexChanged);
            // 
            // entdados
            // 
            this.entdados.Location = new System.Drawing.Point(153, 12);
            this.entdados.Name = "entdados";
            this.entdados.Size = new System.Drawing.Size(103, 23);
            this.entdados.TabIndex = 1;
            this.entdados.Text = "Entrada de Dados";
            this.entdados.UseVisualStyleBackColor = true;
            this.entdados.Click += new System.EventHandler(this.entdados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soma das Idades";
            // 
            // somaids
            // 
            this.somaids.Enabled = false;
            this.somaids.Location = new System.Drawing.Point(153, 166);
            this.somaids.Name = "somaids";
            this.somaids.Size = new System.Drawing.Size(100, 20);
            this.somaids.TabIndex = 3;
            // 
            // Mdidades
            // 
            this.Mdidades.Enabled = false;
            this.Mdidades.Location = new System.Drawing.Point(153, 108);
            this.Mdidades.Name = "Mdidades";
            this.Mdidades.Size = new System.Drawing.Size(100, 20);
            this.Mdidades.TabIndex = 4;
            this.Mdidades.TextChanged += new System.EventHandler(this.Mdidades_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Media Idades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mdidades);
            this.Controls.Add(this.somaids);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entdados);
            this.Controls.Add(this.listidades);
            this.Name = "Form1";
            this.Text = "Lista de Idades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listidades;
        private System.Windows.Forms.Button entdados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox somaids;
        private System.Windows.Forms.TextBox Mdidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

