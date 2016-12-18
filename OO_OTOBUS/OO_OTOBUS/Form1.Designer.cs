namespace OO_OTOBUS
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtboxAdSoyad = new System.Windows.Forms.TextBox();
            this.txtboxCinsiyet = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.txtboxOtobusTuru = new System.Windows.Forms.TextBox();
            this.lblOtobusTuru = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AllowDrop = true;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtboxAdSoyad
            // 
            this.txtboxAdSoyad.Location = new System.Drawing.Point(12, 25);
            this.txtboxAdSoyad.Name = "txtboxAdSoyad";
            this.txtboxAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtboxAdSoyad.TabIndex = 2;
            // 
            // txtboxCinsiyet
            // 
            this.txtboxCinsiyet.Location = new System.Drawing.Point(12, 73);
            this.txtboxCinsiyet.Name = "txtboxCinsiyet";
            this.txtboxCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtboxCinsiyet.TabIndex = 4;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(12, 57);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lblCinsiyet.TabIndex = 3;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // txtboxOtobusTuru
            // 
            this.txtboxOtobusTuru.Location = new System.Drawing.Point(12, 115);
            this.txtboxOtobusTuru.Name = "txtboxOtobusTuru";
            this.txtboxOtobusTuru.Size = new System.Drawing.Size(100, 20);
            this.txtboxOtobusTuru.TabIndex = 6;
            // 
            // lblOtobusTuru
            // 
            this.lblOtobusTuru.AutoSize = true;
            this.lblOtobusTuru.Location = new System.Drawing.Point(12, 99);
            this.lblOtobusTuru.Name = "lblOtobusTuru";
            this.lblOtobusTuru.Size = new System.Drawing.Size(66, 13);
            this.lblOtobusTuru.TabIndex = 5;
            this.lblOtobusTuru.Text = "Otobus Turu";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(131, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 147);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 173);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtboxOtobusTuru);
            this.Controls.Add(this.lblOtobusTuru);
            this.Controls.Add(this.txtboxCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.txtboxAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtboxCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox txtboxOtobusTuru;
        private System.Windows.Forms.Label lblOtobusTuru;
        private System.Windows.Forms.TextBox txtboxAdSoyad;
        private System.Windows.Forms.ListBox listBox1;
    }
}

