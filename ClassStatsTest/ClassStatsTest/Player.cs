using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    class Player
    {
        

        public float damage;
        public static float health = 10;
        public static float gold = 0;

        //damage = Weapons.damage + Statisics.power;

        public List<Items> Inventory = new List<Items>();
        public List<Quest> Quests = new List<Quest>();
        public void OpenInventory()
        {
            
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Inventory Empty");
            }
            else
            {
                foreach (var items in Inventory)
                {
                    Console.WriteLine($"{items.name} - {items.description} - Damage: {items.damage}\n");

                }
            }
        }
        public void currentQuests()
        {
            //Quests.Add(new Quest("Work", "Please"));
            if (Quests.Count == 0)
            {
                Console.WriteLine("You currently have no active quests\n");
            }
            else
            {
                foreach (var quest in Quests)
                {
                    Console.WriteLine($"{quest.qName}: {quest.qObjective}");

                }
                Console.WriteLine("");
            }
        }
        
       
    }
}
    





