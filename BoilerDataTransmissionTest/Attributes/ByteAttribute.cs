using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerDataTransmissionTest.Attributes
{
    public class ByteAttribute : Attribute
    {
        /// <summary>
        /// 开始字节
        /// </summary>
        public int StartIndex { get; set; }
        /// <summary>
        /// 字节长度
        /// </summary>
        public int Length { get; set; }
    }
}
