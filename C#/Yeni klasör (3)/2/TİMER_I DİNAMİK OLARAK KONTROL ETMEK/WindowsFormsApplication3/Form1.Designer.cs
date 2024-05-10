namespace WindowsFormsApplication3
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
            this.lbl_Zaman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Saydir = new System.Windows.Forms.Label();
            this.btn_Arttir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Zaman
            // 
            this.lbl_Zaman.AutoSize = true;
            this.lbl_Zaman.Location = new System.Drawing.Point(178, 155);
            this.lbl_Zaman.Name = "lbl_Zaman";
            this.lbl_Zaman.Size = new System.Drawing.Size(13, 13);
            this.lbl_Zaman.TabIndex = 0;
            this.lbl_Zaman.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "zaman";
            // 
            // lbl_Saydir
            // 
            this.lbl_Saydir.AutoSize = true;
            this.lbl_Saydir.Location = new System.Drawing.Point(178, 101);
            this.lbl_Saydir.Name = "lbl_Saydir";
            this.lbl_Saydir.Size = new System.Drawing.Size(13, 13);
            this.lbl_Saydir.TabIndex = 2;
            this.lbl_Saydir.Text = "0";
            // 
            // btn_Arttir
            // 
            this.btn_Arttir.Location = new System.Drawing.Point(33, 101);
            this.btn_Arttir.Name = "btn_Arttir";
            this.btn_Arttir.Size = new System.Drawing.Size(75, 23);
            this.btn_Arttir.TabIndex = 3;
            this.btn_Arttir.Text = "arttır";
            this.btn_Arttir.UseVisualStyleBackColor = true;
            this.btn_Arttir.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Arttir);
            this.Controls.Add(this.lbl_Saydir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Zaman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Zaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Saydir;
        private System.Windows.Forms.Button btn_Arttir;
        private System.Windows.Forms.Timer timer1;
    }
}

