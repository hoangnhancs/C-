using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.static_class
{
    public class passTimeToMainEvenArgs : EventArgs
    {
        public passTimeToMainEvenArgs(int _time, bool rs = false, string _mode = "stopMusic")
        {
            time = _time;
            resetTime = rs;
            mode = _mode;
        }

        public int time { get; set; }
        public bool resetTime { get; set; }
        public string mode { get; set; }
    }
}
