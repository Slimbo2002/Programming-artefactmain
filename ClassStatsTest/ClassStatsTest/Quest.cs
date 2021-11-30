using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    class Quest
    {
        public string qName { get; set; }
        public string qObjective { get; set; }

        public Quest(string name, string objective)
        {
            qName = name;
            qObjective = objective;
        }

    }
}
