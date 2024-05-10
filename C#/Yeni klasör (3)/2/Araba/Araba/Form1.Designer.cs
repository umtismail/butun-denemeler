namespace Araba
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
            this.btn_gaz = new System.Windows.Forms.Button();
            this.btn_firen = new System.Windows.Forms.Button();
            this.btn_dörtlü = new System.Windows.Forms.Button();
            this.btn_klimaOn = new System.Windows.Forms.Button();
            this.label_sıcaklık = new System.Windows.Forms.Label();
            this.gb_klima = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.klm = new System.Windows.Forms.TrackBar();
            this.hz = new System.Windows.Forms.GroupBox();
            this.Drt = new System.Windows.Forms.Label();
            this.label_hız = new System.Windows.Forms.Label();
            this.label_vites = new System.Windows.Forms.Label();
            this.solaSinyal = new System.Windows.Forms.Label();
            this.sagSinyal = new System.Windows.Forms.Label();
            this.btn_sol = new System.Windows.Forms.Button();
            this.btn_sağ = new System.Windows.Forms.Button();
            this.btn_kontak = new System.Windows.Forms.Button();
            this.timerIsı = new System.Windows.Forms.Timer(this.components);
            this.timerHızVites = new System.Windows.Forms.Timer(this.components);
            this.timerFren = new System.Windows.Forms.Timer(this.components);
            this.timerGaz = new System.Windows.Forms.Timer(this.components);
            this.rd = new System.Windows.Forms.GroupBox();
            this.label_radio = new System.Windows.Forms.Label();
            this.btn_radio = new System.Windows.Forms.Button();
            this.tb_radio = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Yavaşlama = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Hararet = new System.Windows.Forms.Timer(this.components);
            this.Yüzde = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gb_klima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klm)).BeginInit();
            this.hz.SuspendLayout();
            this.rd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_radio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_gaz
            // 
            this.btn_gaz.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_gaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gaz.Location = new System.Drawing.Point(6, 19);
            this.btn_gaz.Name = "btn_gaz";
            this.btn_gaz.Size = new System.Drawing.Size(80, 38);
            this.btn_gaz.TabIndex = 2;
            this.btn_gaz.Text = "Gaz";
            this.btn_gaz.UseVisualStyleBackColor = false;
            this.btn_gaz.Click += new System.EventHandler(this.btn_gaz_Click);
            this.btn_gaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_gaz_MouseDown);
            this.btn_gaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_gaz_MouseUp);
            // 
            // btn_firen
            // 
            this.btn_firen.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_firen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_firen.Location = new System.Drawing.Point(162, 19);
            this.btn_firen.Name = "btn_firen";
            this.btn_firen.Size = new System.Drawing.Size(94, 38);
            this.btn_firen.TabIndex = 3;
            this.btn_firen.Text = "Fren";
            this.btn_firen.UseVisualStyleBackColor = false;
            this.btn_firen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_firen_MouseDown);
            this.btn_firen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_firen_MouseUp);
            // 
            // btn_dörtlü
            // 
            this.btn_dörtlü.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_dörtlü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dörtlü.Location = new System.Drawing.Point(35, 18);
            this.btn_dörtlü.Name = "btn_dörtlü";
            this.btn_dörtlü.Size = new System.Drawing.Size(129, 35);
            this.btn_dörtlü.TabIndex = 4;
            this.btn_dörtlü.Text = "Dörtlüleri Yak";
            this.btn_dörtlü.UseVisualStyleBackColor = false;
            this.btn_dörtlü.Click += new System.EventHandler(this.btn_dörtlü_Click);
            // 
            // btn_klimaOn
            // 
            this.btn_klimaOn.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_klimaOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_klimaOn.Location = new System.Drawing.Point(6, 19);
            this.btn_klimaOn.Name = "btn_klimaOn";
            this.btn_klimaOn.Size = new System.Drawing.Size(150, 50);
            this.btn_klimaOn.TabIndex = 5;
            this.btn_klimaOn.Text = "Klimayı Aç";
            this.btn_klimaOn.UseVisualStyleBackColor = false;
            this.btn_klimaOn.Click += new System.EventHandler(this.btn_klimaOn_Click);
            // 
            // label_sıcaklık
            // 
            this.label_sıcaklık.AutoSize = true;
            this.label_sıcaklık.Location = new System.Drawing.Point(162, 19);
            this.label_sıcaklık.Name = "label_sıcaklık";
            this.label_sıcaklık.Size = new System.Drawing.Size(70, 13);
            this.label_sıcaklık.TabIndex = 8;
            this.label_sıcaklık.Text = "Sıcaklık =  C°";
            // 
            // gb_klima
            // 
            this.gb_klima.Controls.Add(this.radioButton1);
            this.gb_klima.Controls.Add(this.klm);
            this.gb_klima.Controls.Add(this.btn_klimaOn);
            this.gb_klima.Controls.Add(this.label_sıcaklık);
            this.gb_klima.Location = new System.Drawing.Point(562, 13);
            this.gb_klima.Name = "gb_klima";
            this.gb_klima.Size = new System.Drawing.Size(259, 169);
            this.gb_klima.TabIndex = 9;
            this.gb_klima.TabStop = false;
            this.gb_klima.Text = "groupBox3";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(109, 125);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Klima komparsetörü";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // klm
            // 
            this.klm.Location = new System.Drawing.Point(6, 74);
            this.klm.Maximum = 42;
            this.klm.Minimum = -10;
            this.klm.Name = "klm";
            this.klm.Size = new System.Drawing.Size(247, 45);
            this.klm.TabIndex = 0;
            this.klm.Scroll += new System.EventHandler(this.klm_Scroll);
            // 
            // hz
            // 
            this.hz.Controls.Add(this.Drt);
            this.hz.Controls.Add(this.label_hız);
            this.hz.Controls.Add(this.label_vites);
            this.hz.Controls.Add(this.btn_gaz);
            this.hz.Controls.Add(this.btn_firen);
            this.hz.Location = new System.Drawing.Point(12, 12);
            this.hz.Name = "hz";
            this.hz.Size = new System.Drawing.Size(277, 132);
            this.hz.TabIndex = 10;
            this.hz.TabStop = false;
            this.hz.Text = "groupBox2";
            // 
            // Drt
            // 
            this.Drt.AutoSize = true;
            this.Drt.Location = new System.Drawing.Point(481, 44);
            this.Drt.Name = "Drt";
            this.Drt.Size = new System.Drawing.Size(0, 13);
            this.Drt.TabIndex = 14;
            // 
            // label_hız
            // 
            this.label_hız.AutoSize = true;
            this.label_hız.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_hız.Location = new System.Drawing.Point(6, 100);
            this.label_hız.Name = "label_hız";
            this.label_hız.Size = new System.Drawing.Size(59, 17);
            this.label_hız.TabIndex = 6;
            this.label_hız.Text = "Hız = 0";
            // 
            // label_vites
            // 
            this.label_vites.AutoSize = true;
            this.label_vites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_vites.Location = new System.Drawing.Point(6, 80);
            this.label_vites.Name = "label_vites";
            this.label_vites.Size = new System.Drawing.Size(72, 17);
            this.label_vites.TabIndex = 1;
            this.label_vites.Text = "Vites = 1";
            // 
            // solaSinyal
            // 
            this.solaSinyal.AutoSize = true;
            this.solaSinyal.Location = new System.Drawing.Point(138, 70);
            this.solaSinyal.Name = "solaSinyal";
            this.solaSinyal.Size = new System.Drawing.Size(0, 13);
            this.solaSinyal.TabIndex = 13;
            // 
            // sagSinyal
            // 
            this.sagSinyal.AutoSize = true;
            this.sagSinyal.Location = new System.Drawing.Point(138, 103);
            this.sagSinyal.Name = "sagSinyal";
            this.sagSinyal.Size = new System.Drawing.Size(0, 13);
            this.sagSinyal.TabIndex = 12;
            // 
            // btn_sol
            // 
            this.btn_sol.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_sol.Location = new System.Drawing.Point(54, 70);
            this.btn_sol.Name = "btn_sol";
            this.btn_sol.Size = new System.Drawing.Size(66, 22);
            this.btn_sol.TabIndex = 9;
            this.btn_sol.Text = "Sol";
            this.btn_sol.UseVisualStyleBackColor = false;
            this.btn_sol.Click += new System.EventHandler(this.btn_sol_Click);
            // 
            // btn_sağ
            // 
            this.btn_sağ.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_sağ.Location = new System.Drawing.Point(54, 98);
            this.btn_sağ.Name = "btn_sağ";
            this.btn_sağ.Size = new System.Drawing.Size(66, 23);
            this.btn_sağ.TabIndex = 8;
            this.btn_sağ.Text = "Sağ";
            this.btn_sağ.UseVisualStyleBackColor = false;
            this.btn_sağ.Click += new System.EventHandler(this.btn_sağ_Click);
            // 
            // btn_kontak
            // 
            this.btn_kontak.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_kontak.Location = new System.Drawing.Point(57, 52);
            this.btn_kontak.Name = "btn_kontak";
            this.btn_kontak.Size = new System.Drawing.Size(106, 32);
            this.btn_kontak.TabIndex = 7;
            this.btn_kontak.Text = "Kontak";
            this.btn_kontak.UseVisualStyleBackColor = false;
            this.btn_kontak.Click += new System.EventHandler(this.btn_kontak_Click);
            // 
            // timerIsı
            // 
            this.timerIsı.Tick += new System.EventHandler(this.timer_ısı_Tick);
            // 
            // timerHızVites
            // 
            this.timerHızVites.Tick += new System.EventHandler(this.timer_hız_vites_Tick);
            // 
            // timerFren
            // 
            this.timerFren.Tick += new System.EventHandler(this.timer_fren_Tick);
            // 
            // timerGaz
            // 
            this.timerGaz.Interval = 50;
            this.timerGaz.Tick += new System.EventHandler(this.timer_gaz_Tick);
            // 
            // rd
            // 
            this.rd.Controls.Add(this.label_radio);
            this.rd.Controls.Add(this.btn_radio);
            this.rd.Controls.Add(this.tb_radio);
            this.rd.Location = new System.Drawing.Point(568, 189);
            this.rd.Name = "rd";
            this.rd.Size = new System.Drawing.Size(253, 198);
            this.rd.TabIndex = 11;
            this.rd.TabStop = false;
            this.rd.Text = "groupBox5";
            // 
            // label_radio
            // 
            this.label_radio.AutoSize = true;
            this.label_radio.Location = new System.Drawing.Point(7, 175);
            this.label_radio.Name = "label_radio";
            this.label_radio.Size = new System.Drawing.Size(67, 13);
            this.label_radio.TabIndex = 2;
            this.label_radio.Text = "Radio Kapalı";
            // 
            // btn_radio
            // 
            this.btn_radio.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_radio.Location = new System.Drawing.Point(10, 20);
            this.btn_radio.Name = "btn_radio";
            this.btn_radio.Size = new System.Drawing.Size(231, 97);
            this.btn_radio.TabIndex = 1;
            this.btn_radio.Text = "Radio Kapalı";
            this.btn_radio.UseVisualStyleBackColor = false;
            this.btn_radio.Click += new System.EventHandler(this.btn_radio_Click);
            // 
            // tb_radio
            // 
            this.tb_radio.Location = new System.Drawing.Point(6, 123);
            this.tb_radio.Maximum = 3;
            this.tb_radio.Minimum = 1;
            this.tb_radio.Name = "tb_radio";
            this.tb_radio.Size = new System.Drawing.Size(241, 45);
            this.tb_radio.TabIndex = 0;
            this.tb_radio.Value = 1;
            this.tb_radio.Scroll += new System.EventHandler(this.tb_radio_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kontak);
            this.groupBox1.Location = new System.Drawing.Point(22, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btn_dörtlü);
            this.groupBox4.Controls.Add(this.btn_sağ);
            this.groupBox4.Controls.Add(this.solaSinyal);
            this.groupBox4.Controls.Add(this.btn_sol);
            this.groupBox4.Controls.Add(this.sagSinyal);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(323, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 142);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // Yavaşlama
            // 
            this.Yavaşlama.Interval = 200;
            this.Yavaşlama.Tick += new System.EventHandler(this.Yavaşlama_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(42, 189);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Hararet
            // 
            this.Hararet.Tick += new System.EventHandler(this.Hararet_Tick);
            // 
            // Yüzde
            // 
            this.Yüzde.Tick += new System.EventHandler(this.Renk_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rd);
            this.Controls.Add(this.hz);
            this.Controls.Add(this.gb_klima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_klima.ResumeLayout(false);
            this.gb_klima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klm)).EndInit();
            this.hz.ResumeLayout(false);
            this.hz.PerformLayout();
            this.rd.ResumeLayout(false);
            this.rd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_radio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gaz;
        private System.Windows.Forms.Button btn_firen;
        private System.Windows.Forms.Button btn_dörtlü;
        private System.Windows.Forms.Button btn_klimaOn;
        private System.Windows.Forms.Label label_sıcaklık;
        private System.Windows.Forms.GroupBox gb_klima;
        private System.Windows.Forms.GroupBox hz;
        private System.Windows.Forms.Label label_hız;
        private System.Windows.Forms.Label label_vites;
        private System.Windows.Forms.Timer timerIsı;
        private System.Windows.Forms.TrackBar klm;
        private System.Windows.Forms.Timer timerHızVites;
        private System.Windows.Forms.Timer timerFren;
        private System.Windows.Forms.Timer timerGaz;
        private System.Windows.Forms.Button btn_kontak;
        private System.Windows.Forms.Button btn_sol;
        private System.Windows.Forms.Button btn_sağ;
        private System.Windows.Forms.GroupBox rd;
        private System.Windows.Forms.Button btn_radio;
        private System.Windows.Forms.TrackBar tb_radio;
        private System.Windows.Forms.Label label_radio;
        private System.Windows.Forms.Label sagSinyal;
        private System.Windows.Forms.Label solaSinyal;
        private System.Windows.Forms.Label Drt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer Yavaşlama;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer Hararet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Timer Yüzde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

