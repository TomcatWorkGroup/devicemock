using BoilerDataTransmissionTest.Tool;
using System;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class Timing : Form
    {
        public Timing()
        {
            InitializeComponent();
            ConfigIni con = new ConfigIni("Resources/Configure.ini");
            txtTiming.Text = con.GetStringValue("Timing");
            
        }

        private void Timing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigSet cs = new ConfigSet("Resources/Configure.ini", true);            
                cs.SetConfigValue("Timing", txtTiming.Text.ToString());
                cs.WriteConfigToFile(ConfigFile.newFile);
                MessageBox.Show("修改配置文件成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
