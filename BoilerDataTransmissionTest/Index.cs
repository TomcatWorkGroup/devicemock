using BoilerDataTransmissionTest.Tool;
using System;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.ControlBox = false;
            //////////////////////////////////////////////////////////
            OnLoadData();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OnLoadData();
        }
        private void OnLoadData() {
            ConfigIni con = new ConfigIni("Resources/Configure.ini");
            txtTime.Text = con.GetStringValue("Timing");
            txtUrl.Text = con.GetStringValue("Url");
            txtNumber.Text = con.GetStringValue("NumberRequests");
        }
    }
}
