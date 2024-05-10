namespace WindowsFormsApplication6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.veriTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriTürleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // veriTürleriToolStripMenuItem
            // 
            this.veriTürleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intToolStripMenuItem,
            this.longToolStripMenuItem,
            this.doubleToolStripMenuItem,
            this.floatToolStripMenuItem,
            this.demicalToolStripMenuItem,
            this.boolToolStripMenuItem,
            this.charToolStripMenuItem,
            this.stringToolStripMenuItem});
            this.veriTürleriToolStripMenuItem.Name = "veriTürleriToolStripMenuItem";
            this.veriTürleriToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.veriTürleriToolStripMenuItem.Text = "veri türleri";
            this.veriTürleriToolStripMenuItem.Click += new System.EventHandler(this.veriTürleriToolStripMenuItem_Click);
            // 
            // intToolStripMenuItem
            // 
            this.intToolStripMenuItem.Name = "intToolStripMenuItem";
            this.intToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.intToolStripMenuItem.Text = "int";
            this.intToolStripMenuItem.Click += new System.EventHandler(this.intToolStripMenuItem_Click_1);
            // 
            // longToolStripMenuItem
            // 
            this.longToolStripMenuItem.Name = "longToolStripMenuItem";
            this.longToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.longToolStripMenuItem.Text = "long ";
            this.longToolStripMenuItem.Click += new System.EventHandler(this.longToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doubleToolStripMenuItem.Text = "double ";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.doubleToolStripMenuItem_Click);
            // 
            // floatToolStripMenuItem
            // 
            this.floatToolStripMenuItem.Name = "floatToolStripMenuItem";
            this.floatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.floatToolStripMenuItem.Text = "float ";
            this.floatToolStripMenuItem.Click += new System.EventHandler(this.floatToolStripMenuItem_Click);
            // 
            // demicalToolStripMenuItem
            // 
            this.demicalToolStripMenuItem.Name = "demicalToolStripMenuItem";
            this.demicalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.demicalToolStripMenuItem.Text = "demical";
            this.demicalToolStripMenuItem.Click += new System.EventHandler(this.demicalToolStripMenuItem_Click);
            // 
            // boolToolStripMenuItem
            // 
            this.boolToolStripMenuItem.Name = "boolToolStripMenuItem";
            this.boolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boolToolStripMenuItem.Text = "bool";
            this.boolToolStripMenuItem.Click += new System.EventHandler(this.boolToolStripMenuItem_Click);
            // 
            // charToolStripMenuItem
            // 
            this.charToolStripMenuItem.Name = "charToolStripMenuItem";
            this.charToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.charToolStripMenuItem.Text = "char";
            this.charToolStripMenuItem.Click += new System.EventHandler(this.charToolStripMenuItem_Click);
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stringToolStripMenuItem.Text = "string";
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem veriTürleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
    }
}

