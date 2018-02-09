using BoilerDataTransmissionTest.Entities;
using BoilerDataTransmissionTest.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class DataList : Form
    {
        public DataList()
        {
            InitializeComponent();
            IList<DeviceCollectionEntity> list = new DeviceCollectionData().GetDeviceCollectionData();
            this.dataGridView1.DataSource = new BindingList<DeviceCollectionEntity>(list);
        }

        private void DataList_Load(object sender, EventArgs e)
        {
           
        }
    }
}
