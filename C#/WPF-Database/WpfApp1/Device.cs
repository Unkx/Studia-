using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RamSize { get; set; }
        public int DiscSize { get; set; }
        public string OS { get; set; }
        public string Broken { get; set; }
    }

}
