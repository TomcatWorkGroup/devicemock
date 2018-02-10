using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerDataTransmissionTest.Entities
{
    public class MyCheckBoxItem
    {
        public string Title { get; set; }
        public int Index { get; set; }
        public bool IsChecked { get; set; }
        public override string ToString()
        {
            return this.Title;
        }
    }
}
