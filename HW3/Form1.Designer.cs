namespace HW3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load50StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load100StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(626, 538);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(626, 39);
            this.menuStrip1.TabIndex = 0;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileStripMenuItem,
            this.Load50StripMenuItem,
            this.Load100StripMenuItem,
            this.toolStripSeparator2,
            this.saveFileStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // loadFromFileStripMenuItem
            // 
            this.loadFromFileStripMenuItem.CheckOnClick = true;
            this.loadFromFileStripMenuItem.Name = "loadFromFileStripMenuItem";
            this.loadFromFileStripMenuItem.Size = new System.Drawing.Size(364, 30);
            this.loadFromFileStripMenuItem.Text = "Load from file...";
            this.loadFromFileStripMenuItem.Click += new System.EventHandler(this.loadFromFileStripMenuItem_Click);
            // 
            // Load50StripMenuItem
            // 
            this.Load50StripMenuItem.CheckOnClick = true;
            this.Load50StripMenuItem.Name = "Load50StripMenuItem";
            this.Load50StripMenuItem.Size = new System.Drawing.Size(364, 30);
            this.Load50StripMenuItem.Text = "Load Fibonacci numbers(first 50)";
            this.Load50StripMenuItem.Click += new System.EventHandler(this.Load50StripMenuItem_Click);
            // 
            // Load100StripMenuItem
            // 
            this.Load100StripMenuItem.CheckOnClick = true;
            this.Load100StripMenuItem.Name = "Load100StripMenuItem";
            this.Load100StripMenuItem.Size = new System.Drawing.Size(364, 30);
            this.Load100StripMenuItem.Text = "Loaf Fibonacci numbers (first 100)";
            this.Load100StripMenuItem.Click += new System.EventHandler(this.Load100StripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(361, 6);
            // 
            // saveFileStripMenuItem
            // 
            this.saveFileStripMenuItem.CheckOnClick = true;
            this.saveFileStripMenuItem.Name = "saveFileStripMenuItem";
            this.saveFileStripMenuItem.Size = new System.Drawing.Size(364, 30);
            this.saveFileStripMenuItem.Text = "Save to file...";
            this.saveFileStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(626, 577);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load50StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load100StripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveFileStripMenuItem;
    }
}

