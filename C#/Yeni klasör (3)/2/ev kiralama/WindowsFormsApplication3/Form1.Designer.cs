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
            this.Ev = new System.Windows.Forms.Button();
            this.işYeri = new System.Windows.Forms.Button();
            this.Arsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ev
            // 
            this.Ev.Location = new System.Drawing.Point(12, 12);
            this.Ev.Name = "Ev";
            this.Ev.Size = new System.Drawing.Size(118, 138);
            this.Ev.TabIndex = 0;
            this.Ev.Text = "Ev";
            this.Ev.UseVisualStyleBackColor = true;
            this.Ev.Click += new System.EventHandler(this.Ev_Click);
            // 
            // işYeri
            // 
            this.işYeri.Location = new System.Drawing.Point(197, 12);
            this.işYeri.Name = "işYeri";
            this.işYeri.Size = new System.Drawing.Size(118, 138);
            this.işYeri.TabIndex = 1;
            this.işYeri.Text = "İş Yeri";
            this.işYeri.UseVisualStyleBackColor = true;
            this.işYeri.Click += new System.EventHandler(this.işYeri_Click);
            // 
            // Arsa
            // 
            this.Arsa.Location = new System.Drawing.Point(370, 12);
            this.Arsa.Name = "Arsa";
            this.Arsa.Size = new System.Drawing.Size(118, 138);
            this.Arsa.TabIndex = 2;
            this.Arsa.Text = "Arsa";
            this.Arsa.UseVisualStyleBackColor = true;
            this.Arsa.Click += new System.EventHandler(this.Arsa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 395);
            this.Controls.Add(this.Arsa);
            this.Controls.Add(this.işYeri);
            this.Controls.Add(this.Ev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ev;
        private System.Windows.Forms.Button işYeri;
        private System.Windows.Forms.Button Arsa;
    }
}

