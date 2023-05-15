using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLINQ
{
    public class Name
    {
        public string first { get ; set; }
        public string middle { get; set; }
        public string last { get; set; }

        public override string ToString()
        {
            return "first :" + first.ToString().PadLeft(10) + "; middle : "
                + middle.ToString().PadLeft(10) + "; last : " + last.ToString().PadLeft(10); 
        }
    }
}
