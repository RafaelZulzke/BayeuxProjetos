namespace _12_05_2014
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
            this.box2 = new System.Windows.Forms.TextBox();
            this.box1 = new System.Windows.Forms.TextBox();
            this.copiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(61, 97);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 20);
            this.box2.TabIndex = 0;
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(61, 42);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 20);
            this.box1.TabIndex = 1;
            // 
            // copiar
            // 
            this.copiar.Location = new System.Drawing.Point(75, 68);
            this.copiar.Name = "copiar";
            this.copiar.Size = new System.Drawing.Size(75, 23);
            this.copiar.TabIndex = 2;
            this.copiar.Text = "Copiar";
            this.copiar.UseVisualStyleBackColor = true;
            this.copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 162);
            this.Controls.Add(this.copiar);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.box2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Button copiar;
    }
}

