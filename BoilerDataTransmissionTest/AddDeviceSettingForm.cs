using BoilerDataTransmissionTest.Entities;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace BoilerDataTransmissionTest
{
    public partial class AddDeviceSettingForm : Form
    {
        const string Test_Btn_Text_Start = "开始随机测试";
        const string Test_Btn_Text_Stop = "停止随机测试";
        public AddDeviceSettingForm()
        {
            InitializeComponent();
            setting = new BaseDeviceSetting();
            settingMap = new Dictionary<string, BaseDeviceSettingItem>();
            map = new FiledNameMap();
            Type type = typeof(NJZJDeviceRunEntity);
            var members = type.GetMethods();
            foreach (var m in members)
            {
                var item = BaseDeviceSettingItem.getInstance(m);
                if (null != item)
                {
                    item.Description = map.getName(item.Filed);
                    setting.AddSettingItem(item);
                }
            }
        }
        MyCheckBoxItem[] filters;
        BaseDeviceSetting setting;
        Dictionary<string, BaseDeviceSettingItem> settingMap;
        FiledNameMap map;
        private void Btn_Add_Device_Click(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(Btn_Add_Device.Tag);
            var item = setting.GetSettingItem(index);
            //if(settingMap.ContainsKey(item.Filed))
            //{
            //    item = settingMap[item.Filed];
            //}

            if (item.IsStringValue)
            {
                item.StringValue = txt_value_string.Text;
            }
            else
            {
                item.IntValue = int.Parse(txt_value_int.Text);
                item.MaxValue = int.Parse(txt_max.Text);
                item.MinValue = int.Parse(txt_min.Text);
            }
            if (!settingMap.ContainsKey(item.Filed))
            {
                settingMap.Add(item.Filed, item);
            }
        }

        private void AddDeviceSettingForm_Load(object sender, EventArgs e)
        {
            InitTextBox();
            InitFilters();
            InitCkbox();
        }

        private void InitFilters()
        {
            filters = new MyCheckBoxItem[setting.GetSettingItemCount()];
            for (int i = 0; i < filters.Length; i++)
            {
                var s = setting.GetSettingItem(i);
                filters[i] = new MyCheckBoxItem() { Title = s.Description, Index = s.Index, IsChecked = s.IsChecked };
            }
        }
        private void ChangeFilters(string filterName)
        {
            var items = setting.getSettings().Where(item =>
            {
                if (!string.IsNullOrEmpty(filterName) && item.Description.IndexOf(filterName) == -1)
                    return false;
                return true;
            }).ToArray();
            filters = new MyCheckBoxItem[items.Length];
            for (int i = 0; i < filters.Length; i++)
            {
                var s = items[i];
                filters[i] = new MyCheckBoxItem() { Title = s.Description, Index = s.Index, IsChecked = s.IsChecked };
            }
        }

        private void ChangeView()
        {
            int viewCode = rbtn_all.Checked ? 2 : rbtn_checked.Checked ? 1 : 0;
            MyCheckBoxItem[] items;
            if (0 == viewCode)
            {
                items = filters.Where(item => !item.IsChecked).ToArray();
            }
            else if (1 == viewCode)
            {
                items = filters.Where(item => item.IsChecked).ToArray();
            }
            else
            {
                items = filters;
            }
            filters = items;
            //for (int i = 0; i < filters.Length; i++)
            //{
            //    var s = items[i];
            //    filters[i] = new MyCheckBoxItem() { Title = s.Description, Index = i, IsChecked = s.IsChecked };
            //}
        }

        private void InitCkbox()
        {
            ckbox.Items.Clear();
            //if(null == filters)
            //{
            //    var sx = setting.getSettings();
            //    foreach (var item in sx)
            //    {
            //        ckbox.Items.Add(new MyCheckBoxItem() { Title = item.Description, Index = 0 }, item.IsChecked);
            //    }
            //}
            //else

            foreach (var item in filters)
            {
                ckbox.Items.Add(item, item.IsChecked);
            }
        }

        private void ckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitTextBox();

            var item = ckbox.Items[ckbox.SelectedIndex] as MyCheckBoxItem;
            groupBox1.Text = item.Title;
            var baseItem = setting.GetSettingItem(item.Index);
            if (baseItem.IsStringValue)
            {
                if (item.IsChecked)
                {
                    txt_value_string.Enabled = true;
                    Btn_Add_Device.Tag = item.Index;
                }
                txt_value_string.Text = baseItem.StringValue;
            }
            else
            {
                if (item.IsChecked)
                {
                    txt_max.Enabled = true;
                    txt_min.Enabled = true;
                    txt_value_int.Enabled = true;
                    Btn_Add_Device.Tag = item.Index;
                }
                txt_value_int.Text = baseItem.IntValue.ToString();
                txt_max.Text = baseItem.MaxValue.ToString();
                txt_min.Text = baseItem.MinValue.ToString();
            }
        }

        private void InitTextBox()
        {
            txt_max.Enabled = false;
            txt_min.Enabled = false;
            txt_value_int.Enabled = false;
            txt_value_string.Enabled = false;

            txt_max.Text = string.Empty;
            txt_min.Text = string.Empty;
            txt_value_int.Text = string.Empty;
            txt_value_string.Text = string.Empty;
        }

        private void ckbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = ckbox.SelectedItem as MyCheckBoxItem;
            if (null == item)
                return;
            if (e.NewValue == CheckState.Checked)
            {
                item.IsChecked = true;
                setting.SetChecked(item.Index, true);
            }
            else
            {
                item.IsChecked = false;
                setting.SetChecked(item.Index, false);
            }
        }

        private void txt_search_name_TextChanged(object sender, EventArgs e)
       {
            SetCheckBox();
        }

        private void SetCheckBox()
        {
            string part = txt_search_name.Text;
            ChangeFilters(part);
            ChangeView();
            InitCkbox();
        }

        private void rbtn_Click(object sender, EventArgs e)
        {
            SetCheckBox();
        }

        private NJZJDeviceRunEntity GetRandomDevice()
        {
            NJZJDeviceRunEntity device = new NJZJDeviceRunEntity();
            Random random = new Random();
            var fileds = device.GetType().GetFields();
            foreach (var f in fileds)
            {
                if (settingMap.ContainsKey(f.Name))
                {
                    if (f.FieldType.Equals(typeof(string)))
                    {
                        f.SetValue(device, settingMap[f.Name].StringValue);
                        Console.Write(
                            string.Format("{0}->{1} \t", f.Name, settingMap[f.Name].StringValue)
                            );
                    }
                    else
                    {
                        var setting = settingMap[f.Name];
                        int newValue = 0;
                        if (setting.MaxValue > setting.MinValue)
                        {
                            int v = random.Next(setting.MinValue, setting.MaxValue + 1);
                            if (setting.IntValue > 1)
                            {
                                newValue = setting.IntValue + v;
                                setting.IntValue = newValue;
                            }
                            else
                            {
                                newValue = v;
                            }
                        }
                        f.SetValue(device, newValue);
                        Console.Write(
                            string.Format("{0}->{1} \t", f.Name,newValue)
                            );
                    }
                }
            }
            Console.WriteLine(
                            string.Format("运行时间：{0}天{1}小时 \t", device.getRunDays(), device.getRunHours())
                            );
            return device;
        }

        private void GetRandomDevice2()
        {
            Random random = new Random();
            byte[] bytes = new byte[1024];
            foreach (var key in settingMap.Keys)
            {
                var setting = settingMap[key];

                if (setting.IsStringValue)
                {
                    var bs = Encoding.ASCII.GetBytes(setting.StringValue);
                    for(int i = setting.ByteIndex, j = 0; j < setting.ByteLength; i++,j++)
                    {
                        bytes[i] = bs[j];
                    }
                    Console.Write(
                        string.Format("{0}->{1} \t", map.getName(key), setting.StringValue)
                        );
                }
                else
                {
                    int newValue = 0;
                    if (setting.MaxValue > setting.MinValue)
                    {
                        int v = random.Next(setting.MinValue, setting.MaxValue + 1);
                        if (setting.IntValue > 1)
                        {
                            newValue = setting.IntValue + v;
                            setting.IntValue = newValue;
                        }
                        else
                        {
                            newValue = v;
                        }
                    }
                    else
                    {
                        newValue = setting.IntValue;
                    }
                    if(setting.ByteLength > 1)
                    {
                        bytes[setting.ByteIndex] = (byte)(0xff & newValue);
                        bytes[setting.ByteIndex + 1] = (byte)((0xff00 & newValue)>>8);
                    }
                    else
                    {
                        bytes[setting.ByteIndex] = (byte)newValue;
                    }
                    Console.Write(
                        string.Format("{0}->{1} \t", map.getName(key), newValue)
                        );
                }
            }

            Console.WriteLine();
        }
        private void InitBytes(NJZJDeviceRunEntity device)
        {
            byte[] bs = new byte[800];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = (!timer1.Enabled);
            if (timer1.Enabled)
            {
                button1.Text = Test_Btn_Text_Stop;
                return;
            }
            button1.Text = Test_Btn_Text_Start;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetRandomDevice2();
        }
    }
}
