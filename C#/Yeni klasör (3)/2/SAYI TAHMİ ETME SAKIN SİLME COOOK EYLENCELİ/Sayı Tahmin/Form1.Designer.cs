namespace Sayı_Tahmin
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
            this.tahmin_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tahmin_b = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hak_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tahmin_t
            // 
            this.tahmin_t.Location = new System.Drawing.Point(101, 10);
            this.tahmin_t.Name = "tahmin_t";
            this.tahmin_t.Size = new System.Drawing.Size(100, 20);
            this.tahmin_t.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayınızı Giriniz =";
            // 
            // tahmin_b
            // 
            this.tahmin_b.Location = new System.Drawing.Point(13, 30);
            this.tahmin_b.Name = "tahmin_b";
            this.tahmin_b.Size = new System.Drawing.Size(75, 23);
            this.tahmin_b.TabIndex = 2;
            this.tahmin_b.Text = "Tahmin Et";
            this.tahmin_b.UseVisualStyleBackColor = true;
            this.tahmin_b.Click += new System.EventHandler(this.tahmin_b_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(13, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 190);
            this.button2.TabIndex = 3;
            this.button2.Text = "00000";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hak_label
            // 
            this.hak_label.AutoSize = true;
            this.hak_label.Location = new System.Drawing.Point(101, 39);
            this.hak_label.Name = "hak_label";
            this.hak_label.Size = new System.Drawing.Size(35, 13);
            this.hak_label.TabIndex = 4;
            this.hak_label.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hak_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tahmin_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tahmin_t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tahmin_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tahmin_b;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hak_label;
    }
}

