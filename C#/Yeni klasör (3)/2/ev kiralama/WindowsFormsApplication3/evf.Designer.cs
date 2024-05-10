namespace WindowsFormsApplication3
{
    partial class evf
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
            this.tpNo = new System.Windows.Forms.TextBox();
            this.Fiyat = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Alan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Osayısı = new System.Windows.Forms.TextBox();
            this.Kat = new System.Windows.Forms.TextBox();
            this.Cephe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tpNo
            // 
            this.tpNo.Location = new System.Drawing.Point(69, 23);
            this.tpNo.Name = "tpNo";
            this.tpNo.Size = new System.Drawing.Size(100, 20);
            this.tpNo.TabIndex = 0;
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(69, 87);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(100, 20);
            this.Fiyat.TabIndex = 1;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(69, 151);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(100, 20);
            this.Adres.TabIndex = 2;
            // 
            // Alan
            // 
            this.Alan.Location = new System.Drawing.Point(69, 209);
            this.Alan.Name = "Alan";
            this.Alan.Size = new System.Drawing.Size(100, 20);
            this.Alan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TapuNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alan";
            // 
            // Osayısı
            // 
            this.Osayısı.Location = new System.Drawing.Point(69, 268);
            this.Osayısı.Name = "Osayısı";
            this.Osayısı.Size = new System.Drawing.Size(100, 20);
            this.Osayısı.TabIndex = 8;
            // 
            // Kat
            // 
            this.Kat.Location = new System.Drawing.Point(69, 321);
            this.Kat.Name = "Kat";
            this.Kat.Size = new System.Drawing.Size(100, 20);
            this.Kat.TabIndex = 9;
            // 
            // Cephe
            // 
            this.Cephe.Location = new System.Drawing.Point(69, 367);
            this.Cephe.Name = "Cephe";
            this.Cephe.Size = new System.Drawing.Size(100, 20);
            this.Cephe.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OdaSayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cephe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "TAPU NO / FİYAT / ADRES / ALAN / ODA SAYISI / KAT / CEPHE";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(246, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 238);
            this.listBox1.TabIndex = 18;
            // 
            // evf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 423);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cephe);
            this.Controls.Add(this.Kat);
            this.Controls.Add(this.Osayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alan);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.tpNo);
            this.Name = "evf";
            this.Text = "evf";
            this.Load += new System.EventHandler(this.evf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tpNo;
        private System.Windows.Forms.TextBox Fiyat;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Alan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Osayısı;
        private System.Windows.Forms.TextBox Kat;
        private System.Windows.Forms.TextBox Cephe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
    }
}