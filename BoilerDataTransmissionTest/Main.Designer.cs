namespace BoilerDataTransmissionTest
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.上报地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据上报时间频度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锅炉数据采集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锅炉数据生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上报地址ToolStripMenuItem,
            this.数据上报时间频度ToolStripMenuItem,
            this.ToolStripMenuItem,
            this.锅炉数据采集ToolStripMenuItem,
            this.锅炉数据生成ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 上报地址ToolStripMenuItem
            // 
            this.上报地址ToolStripMenuItem.Name = "上报地址ToolStripMenuItem";
            this.上报地址ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.上报地址ToolStripMenuItem.Text = "数据上报地址";
            this.上报地址ToolStripMenuItem.Click += new System.EventHandler(this.上报地址ToolStripMenuItem_Click);
            // 
            // 数据上报时间频度ToolStripMenuItem
            // 
            this.数据上报时间频度ToolStripMenuItem.Name = "数据上报时间频度ToolStripMenuItem";
            this.数据上报时间频度ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.数据上报时间频度ToolStripMenuItem.Text = "数据上报时间频度";
            this.数据上报时间频度ToolStripMenuItem.Click += new System.EventHandler(this.数据上报时间频度ToolStripMenuItem_Click_1);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.ToolStripMenuItem.Text = "发送数据量统计";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.发送数据量统计ToolStripMenuItem_Click);
            // 
            // 锅炉数据采集ToolStripMenuItem
            // 
            this.锅炉数据采集ToolStripMenuItem.Name = "锅炉数据采集ToolStripMenuItem";
            this.锅炉数据采集ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.锅炉数据采集ToolStripMenuItem.Text = "锅炉数据采集";
            this.锅炉数据采集ToolStripMenuItem.Click += new System.EventHandler(this.锅炉数据采集ToolStripMenuItem_Click);
            // 
            // 锅炉数据生成ToolStripMenuItem
            // 
            this.锅炉数据生成ToolStripMenuItem.Name = "锅炉数据生成ToolStripMenuItem";
            this.锅炉数据生成ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.锅炉数据生成ToolStripMenuItem.Text = "锅炉数据生成";
            this.锅炉数据生成ToolStripMenuItem.Click += new System.EventHandler(this.锅炉数据生成ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 427);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "锅炉数据上报系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 上报地址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据上报时间频度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锅炉数据采集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锅炉数据生成ToolStripMenuItem;
    }
}