namespace BoilerDataTransmissionTest
{
    partial class DeviceListForm
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
            this.Lv = new System.Windows.Forms.ListView();
            this.C_DeviceInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.C_SendCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Clone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.Btn_Para_Setting = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.cmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lv
            // 
            this.Lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.C_DeviceInfo,
            this.C_SendCount});
            this.Lv.ContextMenuStrip = this.cmenu;
            this.Lv.FullRowSelect = true;
            this.Lv.GridLines = true;
            this.Lv.Location = new System.Drawing.Point(12, 50);
            this.Lv.MultiSelect = false;
            this.Lv.Name = "Lv";
            this.Lv.Size = new System.Drawing.Size(1038, 401);
            this.Lv.TabIndex = 0;
            this.Lv.UseCompatibleStateImageBehavior = false;
            this.Lv.View = System.Windows.Forms.View.Details;
            this.Lv.DoubleClick += new System.EventHandler(this.Lv_DoubleClick);
            // 
            // C_DeviceInfo
            // 
            this.C_DeviceInfo.Text = "设备信息";
            this.C_DeviceInfo.Width = 500;
            // 
            // C_SendCount
            // 
            this.C_SendCount.Text = "发送数量";
            // 
            // cmenu
            // 
            this.cmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Clone,
            this.toolStripSeparator1,
            this.MenuItem_Delete});
            this.cmenu.Name = "cmenu";
            this.cmenu.Size = new System.Drawing.Size(125, 54);
            this.cmenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmenu_Opening);
            // 
            // MenuItem_Clone
            // 
            this.MenuItem_Clone.Name = "MenuItem_Clone";
            this.MenuItem_Clone.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Clone.Text = "复制设备";
            this.MenuItem_Clone.Click += new System.EventHandler(this.MenuItem_Clone_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // MenuItem_Delete
            // 
            this.MenuItem_Delete.Name = "MenuItem_Delete";
            this.MenuItem_Delete.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Delete.Text = "删除设备";
            this.MenuItem_Delete.Click += new System.EventHandler(this.MenuItem_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Add.Location = new System.Drawing.Point(975, 12);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "添加设备";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // Btn_Para_Setting
            // 
            this.Btn_Para_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Para_Setting.Location = new System.Drawing.Point(848, 12);
            this.Btn_Para_Setting.Name = "Btn_Para_Setting";
            this.Btn_Para_Setting.Size = new System.Drawing.Size(75, 23);
            this.Btn_Para_Setting.TabIndex = 2;
            this.Btn_Para_Setting.Text = "参数设置";
            this.Btn_Para_Setting.UseVisualStyleBackColor = true;
            this.Btn_Para_Setting.Click += new System.EventHandler(this.Btn_Para_Setting_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(12, 12);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "开始发送";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // DeviceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 463);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_Para_Setting);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lv);
            this.Name = "DeviceListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备模拟测试程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceListForm_FormClosing);
            this.Load += new System.EventHandler(this.DeviceListForm_Load);
            this.cmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lv;
        private System.Windows.Forms.ColumnHeader C_DeviceInfo;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.ContextMenuStrip cmenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Clone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Delete;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Button Btn_Para_Setting;
        private System.Windows.Forms.ColumnHeader C_SendCount;
        private System.Windows.Forms.Button Btn_Start;
    }
}