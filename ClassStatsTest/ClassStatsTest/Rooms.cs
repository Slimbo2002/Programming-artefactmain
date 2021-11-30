using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    class Rooms
    {
        static int almdallVisits = 0;
        static int warwrenVisits = 0;
        static int elvenrunVisits = 0;
        static int whitewallVists = 0;
        public static string currentLocation = "Hodgepodge";

        NPCs npc = new NPCs();

        public void Almdall()
        {
            bool Almdall = true;
            currentLocation = "Almdall";
            almdallVisits++;
            if (almdallVisits > 1)
            {
                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Almdalf: Welcome to my home, Almdall!\nThe beauty of this kingdom is immeasurable... from a completely unbiased point of view of course!\nIn this Kingdom you will find:\nNoels Antiques(Shop)\nGreg");
                Console.WriteLine("");
            }
            while (Almdall)
            {
                
                Console.WriteLine("What would you like to do?\nShop\nGreg\nExit");
                string answer = Console.ReadLine().ToLower();
                Console.WriteLine("");

                if (answer == "shop")
                {

                }
                else if (answer == "greg")
                {
                    npc.Greg();
                }
                else if (answer == "exit")
                {
                    Almdall = false;
                }
            }
            
        }
        public void Warwren()
        {

        }
        public void Elvenrun()
        {

        }
        public void Whitewall()
        {

        }

    }

}
