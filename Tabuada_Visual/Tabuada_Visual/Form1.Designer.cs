namespace Tabuada_Visual
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
            this.calctab = new System.Windows.Forms.Button();
            this.nlabel = new System.Windows.Forms.Label();
            this.tablist = new System.Windows.Forms.ListBox();
            this.ntext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calctab
            // 
            this.calctab.Location = new System.Drawing.Point(195, 56);
            this.calctab.Name = "calctab";
            this.calctab.Size = new System.Drawing.Size(75, 23);
            this.calctab.TabIndex = 0;
            this.calctab.Text = "Tabuada";
            this.calctab.UseVisualStyleBackColor = true;
            this.calctab.Click += new System.EventHandler(this.calctab_Click);
            // 
            // nlabel
            // 
            this.nlabel.AutoSize = true;
            this.nlabel.Location = new System.Drawing.Point(12, 61);
            this.nlabel.Name = "nlabel";
            this.nlabel.Size = new System.Drawing.Size(44, 13);
            this.nlabel.TabIndex = 1;
            this.nlabel.Text = "Número";
            // 
            // tablist
            // 
            this.tablist.FormattingEnabled = true;
            this.tablist.Location = new System.Drawing.Point(62, 84);
            this.tablist.Name = "tablist";
            this.tablist.Size = new System.Drawing.Size(100, 134);
            this.tablist.TabIndex = 2;
            // 
            // ntext
            // 
            this.ntext.Location = new System.Drawing.Point(62, 58);
            this.ntext.Name = "ntext";
            this.ntext.Size = new System.Drawing.Size(100, 20);
            this.ntext.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ntext);
            this.Controls.Add(this.tablist);
            this.Controls.Add(this.nlabel);
            this.Controls.Add(this.calctab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calctab;
        private System.Windows.Forms.Label nlabel;
        private System.Windows.Forms.ListBox tablist;
        private System.Windows.Forms.TextBox ntext;
        private System.Windows.Forms.Button button1;
    }
}

