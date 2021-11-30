using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    class Items
    {
        public string name { get; set; }
        public string description { get; set; }
        public float damage { get; set; }

        public Items(string Name, string desc, float Damage)
        {
            name = Name;
            description = desc;
            damage = Damage;
        }
    }

}
