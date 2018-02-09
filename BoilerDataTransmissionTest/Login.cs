using System;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           // Thread.Sleep(10000);
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog(this);
            this.Close();
        }
    }
}
