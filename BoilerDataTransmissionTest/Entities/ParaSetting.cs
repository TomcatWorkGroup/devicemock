using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerDataTransmissionTest.Entities
{
    [Serializable]
    public class ParaSetting
    {
        private const string File_Name = "para.db";
        public int TimerInterval { get; set; }
        public string RequestUrl { get; set; }

        List<Dictionary<string, BaseDeviceSettingItem>> devices;
        public ParaSetting()
        {
            devices = new List<Dictionary<string, BaseDeviceSettingItem>>();
        }

        public List<Dictionary<string, BaseDeviceSettingItem>> Devices
        {
            get { return devices; }
            set { devices = value; }
        }
        public static ParaSetting Load()
        {
            if (File.Exists(File_Name))
            {
                FileStream fs = new FileStream(File_Name, FileMode.Open);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                var p = bf.Deserialize(fs) as ParaSetting;
                fs.Close();
                return p;
            }
            return new ParaSetting();
        }

        public void Save()
        {
            FileStream fs = new FileStream(File_Name, FileMode.Create);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            bf.Serialize(fs,this) ;
            fs.Close();
        }
    }
}
