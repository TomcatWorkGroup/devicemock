namespace BoilerDataTransmissionTest
{
    partial class NumberRequests
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
            this.txtNumberRequests = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发送数据量统计";
            // 
            // txtNumberRequests
            // 
            this.txtNumberRequests.Location = new System.Drawing.Point(107, 28);
            this.txtNumberRequests.Name = "txtNumberRequests";
            this.txtNumberRequests.ReadOnly = true;
            this.txtNumberRequests.Size = new System.Drawing.Size(173, 21);
            this.txtNumberRequests.TabIndex = 1;
            // 
            // NumberRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.txtNumberRequests);
            this.Controls.Add(this.label1);
            this.Name = "NumberRequests";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.NumberRequests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberRequests;
    }
}