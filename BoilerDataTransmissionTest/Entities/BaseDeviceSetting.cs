using System;
using System.Collections.Generic;
using System.Reflection;

namespace BoilerDataTransmissionTest.Entities
{
    [Serializable]
    public class BaseDeviceSettingItem
    {
        public static BaseDeviceSettingItem getInstance(MethodInfo methodInfo)
        {
            var attr = Attribute.GetCustomAttribute(methodInfo, typeof(Attributes.ByteAttribute));
            if (null == attr)
            {
                return null;
            }
            BaseDeviceSettingItem item = new BaseDeviceSettingItem();
            Attributes.ByteAttribute battr = attr as Attributes.ByteAttribute;
            if(battr.Length > 4)
            {
                item.IsStringValue = true;
            }
            else
            {
                item.IsStringValue = false;
            }
            item.Filed = methodInfo.Name.Substring(3).ToLower();
            item.ByteIndex = battr.StartIndex;
            item.ByteLength = battr.Length;
            return item;
        }
        public int Index { get;  set; }
        public string Filed { get; set; }
        public int ByteIndex { get; set; }
        public int ByteLength { get; set; }
        public bool IsStringValue { get; set; }
        public int IntValue { get; set; }
        public string StringValue { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; }

       
    }
    

    public class BaseDeviceSetting
    {
        List<BaseDeviceSettingItem> setting = new List<BaseDeviceSettingItem>();

        public void AddSettingItem(BaseDeviceSettingItem item)
        {
            item.Index = setting.Count;
            setting.Add(item);
        }

        public BaseDeviceSettingItem GetSettingItem(int index)
        {
            return setting[index];
        }

        public int GetSettingItemCount()
        {
            return setting.Count;
        }

        public List<BaseDeviceSettingItem> getSettings()
        {
            return setting;
        }

        public void SetChecked(int index,bool isChecked)
        {
            setting[index].IsChecked = isChecked;
        }
    }
}
