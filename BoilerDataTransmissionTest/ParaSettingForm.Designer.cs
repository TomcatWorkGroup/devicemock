namespace BoilerDataTransmissionTest
{
    partial class ParaSettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Interval = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "心跳间隔时间（秒）";
            // 
            // Txt_Interval
            // 
            this.Txt_Interval.Location = new System.Drawing.Point(132, 10);
            this.Txt_Interval.Name = "Txt_Interval";
            this.Txt_Interval.Size = new System.Drawing.Size(311, 21);
            this.Txt_Interval.TabIndex = 1;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(368, 226);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "网络请求URL";
            // 
            // Txt_Url
            // 
            this.Txt_Url.Location = new System.Drawing.Point(132, 46);
            this.Txt_Url.Name = "Txt_Url";
            this.Txt_Url.Size = new System.Drawing.Size(311, 21);
            this.Txt_Url.TabIndex = 1;
            // 
            // ParaSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 261);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_Url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Interval);
            this.Controls.Add(this.label1);
            this.Name = "ParaSettingForm";
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.ParaSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Interval;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Url;
    }
}