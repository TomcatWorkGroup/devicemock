using BoilerDataTransmissionTest.Tool;
using System;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class UrlConfig : Form
    {
        public UrlConfig()
        {
            InitializeComponent();
            ConfigIni con = new ConfigIni("Resources/Configure.ini");
            txtUrlConfig.Text = con.GetStringValue("Url");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigSet cs = new ConfigSet("Resources/Configure.ini", true);
                //http://wl.bkse.cn/Device/DeviceDataInput
                cs.SetConfigValue("Url", txtUrlConfig.Text.ToString());
                cs.WriteConfigToFile(ConfigFile.newFile);
                MessageBox.Show("修改配置文件成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UrlConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
