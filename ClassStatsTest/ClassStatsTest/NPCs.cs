using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    class NPCs
    {
        string answer = "";
        CharacterCreation c = new CharacterCreation();
        Player p = new Player();
        public void Greg()
        {
            bool answer = true;
            Console.WriteLine($"Greg: Oh darn, hello {c.name}. It appears that I left my Slippers in Warwren with a friend... Carlotta was her name. Can you get them for me?");
            
            //asks player if they will help greg

            while (answer)
            {
                string help = Console.ReadLine().ToLower();

                if (help == "yes")
                {
                    Console.WriteLine("Greg: Thank you! Tell Carlotta I said hi!");

                    p.Quests.Add(new Quest("Gregs Comfies", "Get and return Gregs slippers"));

                    answer = false;
                }
                else if (help == "no")
                {
                    Console.WriteLine("Greg: Awww you advturers are usually so kind");
                    answer = false;
                }
                else
                {
                    Console.WriteLine("I don't understand");
                }
            }
            
        }

    }



}
