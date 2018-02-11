using BoilerDataTransmissionTest.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class DeviceListForm : Form
    {
        private const string Test_Btn_Text_Start = "开始随机测试";
        private const string Test_Btn_Text_Stop = "停止随机测试";
        private const int Device_Count = 5;
        public DeviceListForm()
        {
            InitializeComponent();
            //devices = new List<Dictionary<string, BaseDeviceSettingItem>>(Device_Count);
            devicesCount = new int[Device_Count];
            queue = new Queue<byte[]>(Device_Count);
        }
        int[] devicesCount;
        ParaSetting setting;
        //List<Dictionary<string, BaseDeviceSettingItem>> devices;
        Queue<byte[]> queue;
        int deviceIndex = 0;
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddEditDeviceSettingForm frm = new AddEditDeviceSettingForm();
            var result = frm.ShowDialog();
            if(DialogResult.OK == result)
            {
                if (setting.Devices.Count == 5)
                {
                    MessageBox.Show("设备数量已经到达5个的上限，不能再次添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var map = frm.Tag as Dictionary<string, BaseDeviceSettingItem>;
                setting.Devices.Add(map);
                Add_List_View_Item(map);
            }
        }

        private void Add_List_View_Item(Dictionary<string, BaseDeviceSettingItem> map)
        {
            ListViewItem item = new ListViewItem(new string[] { GetMapString(map), "0" });
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
            Lv.Items[listViewItemIndex].SubItems[1].Text = devicesCount[listViewItemIndex].ToString();
        }

        private void Lv_DoubleClick(object sender, EventArgs e)
        {
            if (Lv.SelectedItems.Count > 0)
            {
                AddEditDeviceSettingForm frm = new AddEditDeviceSettingForm();
                frm.Tag = setting.Devices[Lv.SelectedItems[0].Index];
                if(DialogResult.OK == frm.ShowDialog())
                {
                    var map = frm.Tag as Dictionary<string, BaseDeviceSettingItem>;
                    setting.Devices[Lv.SelectedItems[0].Index] = map;
                    Change_List_View_Item(Lv.SelectedItems[0].Index, map);
                }
            }
        }

        private void MenuItem_Clone_Click(object sender, EventArgs e)
        {
            var obj = CloneDevice(setting.Devices[Lv.SelectedIndices[0]]);
            setting.Devices.Add(obj);
            Add_List_View_Item(obj);
        }

        private void MenuItem_Delete_Click(object sender, EventArgs e)
        {
            setting.Devices.RemoveAt(Lv.SelectedIndices[0]);
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

        private void Btn_Para_Setting_Click(object sender, EventArgs e)
        {
            ParaSettingForm frm = new ParaSettingForm();
            frm.Tag = setting;
            if(DialogResult.OK == frm.ShowDialog())
            {
                setting = frm.Tag as ParaSetting;
            }
        }

        private void DeviceListForm_Load(object sender, EventArgs e)
        {
            setting = ParaSetting.Load();
            InitWorker();
        }

        private void DeviceListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("确定要退出吗？", "问题", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == result)
            {
                e.Cancel = true;
                return;
            }
            setting.Save();
        }

        private void Set_MyTimer()
        {
            MyTimer.Interval = setting.TimerInterval*1000;
        }
        Random random = new Random();
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if(deviceIndex >= setting.Devices.Count)
            {
                deviceIndex = 0;
            }
            byte[] bytes = new byte[1024];
            var map = CloneDevice(setting.Devices[deviceIndex]);
            foreach (var key in map.Keys)
            {
                var deviceFiled = map[key];
                
                if (deviceFiled.IsStringValue)
                {
                    var bs = Encoding.ASCII.GetBytes(deviceFiled.StringValue);
                    for (int i = deviceFiled.ByteIndex, j = 0; j < deviceFiled.ByteLength; i++, j++)
                    {
                        bytes[i] = bs[j];
                    }
                    Console.Write(
                        string.Format("{0}->{1} \t", deviceFiled.Description, deviceFiled.StringValue)
                        );
                }
                else
                {
                    int newValue = 0;
                    if (deviceFiled.MaxValue > deviceFiled.MinValue)
                    {
                        int v = random.Next(deviceFiled.MinValue, deviceFiled.MaxValue + 1);
                        if (deviceFiled.IntValue > 1)
                        {
                            newValue = deviceFiled.IntValue + v;
                            deviceFiled.IntValue = newValue;
                        }
                        else
                        {
                            newValue = v;
                        }
                    }
                    else
                    {
                        newValue = deviceFiled.IntValue;
                    }
                    if (deviceFiled.ByteLength > 1)
                    {
                        bytes[deviceFiled.ByteIndex] = (byte)(0xff & newValue);
                        bytes[deviceFiled.ByteIndex + 1] = (byte)((0xff00 & newValue) >> 8);
                    }
                    else
                    {
                        bytes[deviceFiled.ByteIndex] = (byte)newValue;
                    }
                    Console.Write(
                        string.Format("{0}->{1} \t", deviceFiled.Description, newValue)
                        );
                }
            }
            devicesCount[deviceIndex]++;
            Change_List_View_Item(deviceIndex, map);
            deviceIndex++;
            lock (queue)
            {
                queue.Enqueue(bytes);
            }
            Console.WriteLine();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if(setting.Devices.Count < 1)
            {
                MessageBox.Show("尚未用于可用设备进行模拟，请先添加设备再次尝试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (null == setting || setting.TimerInterval < 1)
            {
                MessageBox.Show("参数配置错误，请重新配置！", "错误", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Set_MyTimer();
            MyTimer.Enabled = (!MyTimer.Enabled);
            if (MyTimer.Enabled)
            {
                Btn_Start.Text = Test_Btn_Text_Stop;
                return;
            }
            Btn_Start.Text = Test_Btn_Text_Start;
        }

        private void InitWorker()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((obj) =>
            {
                while (true)
                {
                    lock (queue)
                    {
                        if (queue.Count > 0)
                        {
                            var requestData = queue.Dequeue();
                            SendWebRequest(requestData);
                        }
                    }
                    Thread.Sleep(500);
                }
            }), null);
        }

        private void SendWebRequest(byte[] data)
        {
            try
            {
                WebRequest request = WebRequest.Create(setting.RequestUrl);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                request.Timeout = 20000;
                request.ContentLength = data.Length;
                var stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Flush();
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
