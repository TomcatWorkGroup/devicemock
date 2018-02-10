using System;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //this.Owner.Hide();
            //Index index = new Index
            //{
            //    MdiParent = this,
            //    MaximizeBox = false,
            //    MinimizeBox = false,
            //    ControlBox = false,
            //    Dock = DockStyle.Fill
            //};
            //index.Show();
        }

      

        private void 上报地址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrlConfig urlConfig = new UrlConfig
            {
                MdiParent = this,
                MaximizeBox = false,
                Dock = DockStyle.Fill
            };
            urlConfig.Show();
        }

        private void 发送数据量统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberRequests numberRequests = new NumberRequests
            {
                MdiParent = this,
                MaximizeBox = false,
                Dock = DockStyle.Fill
            };
            numberRequests.Show();
        }

        private void 锅炉数据采集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataList dataList = new DataList
            {
                MdiParent = this,
                MaximizeBox = false,
                Dock = DockStyle.Fill
            };
            dataList.Show();
        }

        private void 数据上报时间频度ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Timing timing = new Timing
            {
                MdiParent = this,
                MaximizeBox = false,
                Dock = DockStyle.Fill
            };
            timing.Show();
        }

        private void 锅炉数据生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGeneration dataGeneration = new DataGeneration
            {
                MdiParent = this,
                MaximizeBox = false,
                Dock = DockStyle.Fill
            };
            dataGeneration.Show();
        }
    }
}
