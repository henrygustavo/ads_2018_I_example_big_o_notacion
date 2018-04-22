using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_o_notation_data_structure
{
    public class LogLine
    {
        int counter;

        public LogLine(int counter)
        {
            this.counter = counter;
        }

        public String getIP()
        {
            return "ip-" + counter;
        }
    }
}
