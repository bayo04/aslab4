namespace aslab4
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
            this.txboja = new System.Windows.Forms.TextBox();
            this.btpromijeni = new System.Windows.Forms.Button();
            this.btdodaj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txboja
            // 
            this.txboja.Location = new System.Drawing.Point(12, 12);
            this.txboja.Name = "txboja";
            this.txboja.Size = new System.Drawing.Size(100, 20);
            this.txboja.TabIndex = 0;
            // 
            // btpromijeni
            // 
            this.btpromijeni.Location = new System.Drawing.Point(93, 149);
            this.btpromijeni.Name = "btpromijeni";
            this.btpromijeni.Size = new System.Drawing.Size(75, 23);
            this.btpromijeni.TabIndex = 1;
            this.btpromijeni.Text = "promijeni";
            this.btpromijeni.UseVisualStyleBackColor = true;
            this.btpromijeni.Click += new System.EventHandler(this.btpromijeni_Click);
            // 
            // btdodaj
            // 
            this.btdodaj.Location = new System.Drawing.Point(12, 149);
            this.btdodaj.Name = "btdodaj";
            this.btdodaj.Size = new System.Drawing.Size(75, 23);
            this.btdodaj.TabIndex = 2;
            this.btdodaj.Text = "Dodaj";
            this.btdodaj.UseVisualStyleBackColor = true;
            this.btdodaj.Click += new System.EventHandler(this.btdodaj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 89);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 184);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btdodaj);
            this.Controls.Add(this.btpromijeni);
            this.Controls.Add(this.txboja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txboja;
        private System.Windows.Forms.Button btpromijeni;
        private System.Windows.Forms.Button btdodaj;
        private System.Windows.Forms.TextBox textBox1;
    }
}

