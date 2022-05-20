
namespace Alarm
{
    partial class Alarm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.example = new System.Windows.Forms.GroupBox();
            this.rtbname = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.правитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.example.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.example);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // example
            // 
            this.example.Controls.Add(this.tbtime);
            this.example.Controls.Add(this.rtbname);
            this.example.Controls.Add(this.richTextBox1);
            this.example.Location = new System.Drawing.Point(12, 31);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(776, 135);
            this.example.TabIndex = 1;
            this.example.TabStop = false;
            // 
            // rtbname
            // 
            this.rtbname.Location = new System.Drawing.Point(137, 60);
            this.rtbname.Name = "rtbname";
            this.rtbname.Size = new System.Drawing.Size(620, 60);
            this.rtbname.TabIndex = 2;
            this.rtbname.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(110, 94);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.правитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(33, 24);
            this.toolStripMenuItem1.Text = "+";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // правитьToolStripMenuItem
            // 
            this.правитьToolStripMenuItem.Name = "правитьToolStripMenuItem";
            this.правитьToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.правитьToolStripMenuItem.Text = "Править";
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(137, 27);
            this.tbtime.Name = "tbtime";
            this.tbtime.Size = new System.Drawing.Size(125, 27);
            this.tbtime.TabIndex = 3;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Alarm";
            this.Text = "Будильник";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.example.ResumeLayout(false);
            this.example.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem правитьToolStripMenuItem;
        public System.Windows.Forms.GroupBox example;
        public System.Windows.Forms.RichTextBox rtbname;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox tbtime;
    }
}

