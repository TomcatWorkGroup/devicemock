using BoilerDataTransmissionTest.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class DeviceListForm : Form
    {
        public DeviceListForm()
        {
            InitializeComponent();
            devices = new List<Dictionary<string, BaseDeviceSettingItem>>(5);
        }

        List<Dictionary<string, BaseDeviceSettingItem>> devices;
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddEditDeviceSettingForm frm = new AddEditDeviceSettingForm();
            var result = frm.ShowDialog();
            if(DialogResult.OK == result)
            {
                if (devices.Count == 5)
                {
                    MessageBox.Show("设备数量已经到达5个的上限，不能再次添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var map = frm.Tag as Dictionary<string, BaseDeviceSettingItem>;
                devices.Add(map);
                Add_List_View_Item(map);
            }
        }

        private void Add_List_View_Item(Dictionary<string, BaseDeviceSettingItem> map)
        {
            ListViewItem item = new ListViewItem(GetMapString(map));
            Lv.Items.Add(item);
        }

        private static string GetMapString(Dictionary<string, BaseDeviceSettingItem> map)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var key in map.Keys)
            {
                string str = map[key].IsStringValue ? map[key].StringValue : map[key].IntValue.ToString();
                sb.Append(string.Format("{0}：{1}  ", map[key].Description, str));
            }

            return sb.ToString();
        }

        private void Change_List_View_Item(int listViewItemIndex, Dictionary<string, BaseDeviceSettingItem> map)
        {
            Lv.Items[listViewItemIndex].Text = GetMapString(map);
        }

        private void Lv_DoubleClick(object sender, EventArgs e)
        {
            if (Lv.SelectedItems.Count > 0)
            {
                AddEditDeviceSettingForm frm = new AddEditDeviceSettingForm();
                frm.Tag = devices[Lv.SelectedItems[0].Index];
                if(DialogResult.OK == frm.ShowDialog())
                {
                    var map = frm.Tag as Dictionary<string, BaseDeviceSettingItem>;
                    devices[Lv.SelectedItems[0].Index] = map;
                    Change_List_View_Item(Lv.SelectedItems[0].Index, map);
                }
            }
        }

        private void MenuItem_Clone_Click(object sender, EventArgs e)
        {
            var obj = CloneDevice(devices[Lv.SelectedIndices[0]]);
            devices.Add(obj);
            Add_List_View_Item(obj);
        }

        private void MenuItem_Delete_Click(object sender, EventArgs e)
        {
            devices.RemoveAt(Lv.SelectedIndices[0]);
            Lv.Items.RemoveAt(Lv.SelectedIndices[0]);
        }

        private void cmenu_Opening(object sender, CancelEventArgs e)
        {
            if(Lv.SelectedIndices.Count < 1)
            {
                e.Cancel = true;
            }
        }

        private Dictionary<string, BaseDeviceSettingItem> CloneDevice(Dictionary<string,BaseDeviceSettingItem> map)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.AssemblyFormat = FormatterAssemblyStyle.Full;
            bf.TypeFormat = FormatterTypeStyle.TypesAlways;
            bf.Serialize(ms, map);

            ms.Seek(0, SeekOrigin.Begin);
            var obj = bf.Deserialize(ms) as Dictionary<string, BaseDeviceSettingItem>;
            return obj;
        }
    }
}
