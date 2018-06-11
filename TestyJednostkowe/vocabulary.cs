using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public class vocabulary
    {
        public int id { get; set; }
        public string pol { get; set; }
        public string eng { get; set; }
        public DateTime nextRepeat { get; set; }
    }
}
