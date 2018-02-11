namespace BoilerDataTransmissionTest
{
    partial class AddEditDeviceSettingForm
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
            this.Btn_Add_Device = new System.Windows.Forms.Button();
            this.ckbox = new System.Windows.Forms.CheckedListBox();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_checked = new System.Windows.Forms.RadioButton();
            this.rbtn_unchecked = new System.Windows.Forms.RadioButton();
            this.rbtn_all = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_value_int = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_value_string = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Add_Device
            // 
            this.Btn_Add_Device.Location = new System.Drawing.Point(194, 221);
            this.Btn_Add_Device.Name = "Btn_Add_Device";
            this.Btn_Add_Device.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add_Device.TabIndex = 0;
            this.Btn_Add_Device.Text = "设定";
            this.Btn_Add_Device.UseVisualStyleBackColor = true;
            this.Btn_Add_Device.Click += new System.EventHandler(this.Btn_Add_Device_Click);
            // 
            // ckbox
            // 
            this.ckbox.FormattingEnabled = true;
            this.ckbox.Location = new System.Drawing.Point(12, 85);
            this.ckbox.Name = "ckbox";
            this.ckbox.Size = new System.Drawing.Size(331, 276);
            this.ckbox.TabIndex = 1;
            this.ckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckbox_ItemCheck);
            this.ckbox.SelectedIndexChanged += new System.EventHandler(this.ckbox_SelectedIndexChanged);
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(84, 12);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(259, 21);
            this.txt_search_name.TabIndex = 2;
            this.txt_search_name.TextChanged += new System.EventHandler(this.txt_search_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "搜索名字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "显示选项：";
            // 
            // rbtn_checked
            // 
            this.rbtn_checked.AutoSize = true;
            this.rbtn_checked.Location = new System.Drawing.Point(84, 51);
            this.rbtn_checked.Name = "rbtn_checked";
            this.rbtn_checked.Size = new System.Drawing.Size(59, 16);
            this.rbtn_checked.TabIndex = 4;
            this.rbtn_checked.Text = "选中项";
            this.rbtn_checked.UseVisualStyleBackColor = true;
            this.rbtn_checked.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtn_unchecked
            // 
            this.rbtn_unchecked.AutoSize = true;
            this.rbtn_unchecked.Location = new System.Drawing.Point(182, 51);
            this.rbtn_unchecked.Name = "rbtn_unchecked";
            this.rbtn_unchecked.Size = new System.Drawing.Size(59, 16);
            this.rbtn_unchecked.TabIndex = 4;
            this.rbtn_unchecked.Text = "未选项";
            this.rbtn_unchecked.UseVisualStyleBackColor = true;
            this.rbtn_unchecked.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtn_all
            // 
            this.rbtn_all.AutoSize = true;
            this.rbtn_all.Checked = true;
            this.rbtn_all.Location = new System.Drawing.Point(284, 51);
            this.rbtn_all.Name = "rbtn_all";
            this.rbtn_all.Size = new System.Drawing.Size(59, 16);
            this.rbtn_all.TabIndex = 4;
            this.rbtn_all.TabStop = true;
            this.rbtn_all.Text = "全部项";
            this.rbtn_all.UseVisualStyleBackColor = true;
            this.rbtn_all.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_min);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_max);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_value_int);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_value_string);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_Add_Device);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "开始随机测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(77, 139);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(192, 21);
            this.txt_min.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "最大减幅数";
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(77, 102);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(192, 21);
            this.txt_max.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "最大增幅数";
            // 
            // txt_value_int
            // 
            this.txt_value_int.Location = new System.Drawing.Point(77, 64);
            this.txt_value_int.Name = "txt_value_int";
            this.txt_value_int.Size = new System.Drawing.Size(192, 21);
            this.txt_value_int.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数值属性值";
            // 
            // txt_value_string
            // 
            this.txt_value_string.Location = new System.Drawing.Point(77, 27);
            this.txt_value_string.Name = "txt_value_string";
            this.txt_value_string.Size = new System.Drawing.Size(192, 21);
            this.txt_value_string.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "文本属性值";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(554, 337);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "保存设置";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // AddEditDeviceSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 372);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtn_all);
            this.Controls.Add(this.rbtn_unchecked);
            this.Controls.Add(this.rbtn_checked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search_name);
            this.Controls.Add(this.ckbox);
            this.Name = "AddEditDeviceSettingForm";
            this.Text = "AddDeviceSettingForm";
            this.Load += new System.EventHandler(this.AddDeviceSettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add_Device;
        private System.Windows.Forms.CheckedListBox ckbox;
        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_checked;
        private System.Windows.Forms.RadioButton rbtn_unchecked;
        private System.Windows.Forms.RadioButton rbtn_all;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_value_int;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_value_string;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Save;
    }
}