using BoilerDataTransmissionTest.Tool;
using System;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class NumberRequests : Form
    {
        public NumberRequests()
        {
            InitializeComponent();
            ConfigIni con = new ConfigIni("Resources/Configure.ini");
            txtNumberRequests.Text = con.GetStringValue("NumberRequests");
        }

        private void NumberRequests_Load(object sender, EventArgs e)
        {

        }
    }
}
