namespace pc_ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AltTab = new System.Windows.Forms.Timer(this.components);
            this.kapatma = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.usb_kontrol = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.kaytı_defteri = new System.Windows.Forms.Timer(this.components);
            this.prog_silme = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AltTab
            // 
            this.AltTab.Interval = 10;
            this.AltTab.Tick += new System.EventHandler(this.AltTab_Tick);
            // 
            // kapatma
            // 
            this.kapatma.Enabled = true;
            this.kapatma.Interval = 1000;
            this.kapatma.Tick += new System.EventHandler(this.kapatma_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(327, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilgisayarınız 180 Saniye Sonra Kapatılacak";
            // 
            // usb_kontrol
            // 
            this.usb_kontrol.Tick += new System.EventHandler(this.usb_kontrol_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(178, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1014, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "“Hayatta kalabilen en güçlü olan tür değildir, en zeki olandır. Değişime en çok a" +
    "dapte olabilendir.” Charles Robert Darwin";
            // 
            // refresh
            // 
            this.refresh.Enabled = true;
            this.refresh.Interval = 10;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // prog_silme
            // 
            this.prog_silme.Enabled = true;
            this.prog_silme.Tick += new System.EventHandler(this.prog_silme_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 709);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer AltTab;
        private System.Windows.Forms.Timer kapatma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer usb_kontrol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Timer kaytı_defteri;
        private System.Windows.Forms.Timer prog_silme;
    }
}

