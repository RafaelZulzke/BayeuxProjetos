﻿namespace _8_NÚMEROS_MEDIA_MAIOR_MENOR
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
            this.Verificadados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num8vezes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Verificadados
            // 
            this.Verificadados.Location = new System.Drawing.Point(149, 98);
            this.Verificadados.Name = "Verificadados";
            this.Verificadados.Size = new System.Drawing.Size(142, 23);
            this.Verificadados.TabIndex = 0;
            this.Verificadados.Text = "Verificação de Dados";
            this.Verificadados.UseVisualStyleBackColor = true;
            this.Verificadados.Click += new System.EventHandler(this.Verificadados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entre com 8 N°";
            // 
            // num8vezes
            // 
            this.num8vezes.Location = new System.Drawing.Point(107, 12);
            this.num8vezes.Name = "num8vezes";
            this.num8vezes.Size = new System.Drawing.Size(100, 20);
            this.num8vezes.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 133);
            this.Controls.Add(this.num8vezes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verificadados);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Verificadados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num8vezes;
    }
}