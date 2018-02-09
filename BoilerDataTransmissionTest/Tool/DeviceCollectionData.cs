using BoilerDataTransmissionTest.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace BoilerDataTransmissionTest.Tool
{
   public class DeviceCollectionData
    {
       // private ILog log;
        public DeviceCollectionData()
        {
           // log = LogManager.GetLogger(this.GetType().Name, typeof(DeviceCollectionData));
        }
        public IList<DeviceCollectionEntity> GetDeviceCollectionData()
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://39.106.168.77:8081/datamanage/device/sell");
                webRequest.Method = "GET";
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                StreamReader sr = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                var jsonText = sr.ReadToEnd();
                IList<DeviceCollectionEntity> list = null;
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<DeviceCollectionEntity>));
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonText)))
                {
                    list = (List<DeviceCollectionEntity>)serializer.ReadObject(ms);
                }
                return list;
            }
            catch (Exception ex)
            {
               // log.Info(ex.ToString());
                return null;
            }
        }
    }
}
