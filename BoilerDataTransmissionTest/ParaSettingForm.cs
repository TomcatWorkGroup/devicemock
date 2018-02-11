using BoilerDataTransmissionTest.Entities;
using System;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class ParaSettingForm : Form
    {
        public ParaSettingForm()
        {
            InitializeComponent();
        }
        ParaSetting setting;
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            setting.TimerInterval = int.Parse(Txt_Interval.Text);
            setting.RequestUrl = Txt_Url.Text;
            this.DialogResult = DialogResult.OK;
            this.Tag = setting;
            this.Close();
        }

        private void ParaSettingForm_Load(object sender, EventArgs e)
        {
            setting = this.Tag as ParaSetting;
            Txt_Interval.Text = setting.TimerInterval.ToString();
        }
    }
}
