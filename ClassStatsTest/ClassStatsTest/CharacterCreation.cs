using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    enum Class
    {
        Marauder = 1,
        Assassin = 2,
        Thief = 3,
    }
    enum Faction
    {
        Almdall = 1,
        Warwren = 2,
        Elvenrun = 3,
        Whitewall = 4,

    }
    class CharacterCreation
    {
        Statisics playerStats = new Statisics();
        Player p = new Player();

        bool mainLoop = true;
        public string name;
        string Home;
        string Role;
        
        
        public void PlayerCreation()
        {
            
            while (mainLoop)
            {
                GetName();                
                GetClass();
                GetFaction();
                Confirm();
                
            }
            void GetName()
            {
                bool nameLoop = true;
                while (nameLoop)
                {
                    Console.WriteLine("Almdalf: Now, who are you adventurer?");
                    name = Console.ReadLine();

                    Console.WriteLine($"Almdalf: Hello {name}! This is your name right?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Almdalf: Perfect, Onward!");
                        nameLoop = false;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Almdalf: Oh dear, forgot your name have you? Pity");
                    }
                    else
                    {
                        Console.WriteLine("Almdalf: Oh silly adventurer, thats not a name. Give it another go");

                    }
                }




            }

            void GetClass()
            {
                bool classLoop = true;
                while (classLoop)
                {
                    Console.WriteLine("Almdalf: Time to pick your class, this will impact gameplay so make the right choice. \n1. Maurader \n2. Assassin \n3. Thief \nPlease enter number 1-3");
                    string input = Console.ReadLine();


                    int answer = Int32.Parse(input);

                    if (answer > 0 && answer < 4)
                    {
                        Class role = (Class)answer;

                        if (answer == 1)
                        {
                            Console.WriteLine($"Almdalf: You have selected Maurauder, Maurader Stats\nSpeed: 4\nPower: 7\nStealth:3");
                            Console.WriteLine("Almdalf: Is this the class you want?");
                            string confirm = Console.ReadLine().ToLower();

                            if (confirm == "yes")
                            {
                                playerStats.Maurauder();
                                classLoop = false;
                            }
                            else if (confirm == "no")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Almdalf: Just say Yes or No, don't overcomplicate it");
                            }
                        }
                        else if (answer == 2)
                        {
                            Console.WriteLine("Almdalf: You have selected Assassin, Assassin Stats\nSpeed: 6\nPower: 4\nStealth: 6");

                            Console.WriteLine("Almdalf: Is this the class you want?");
                            string confirm = Console.ReadLine().ToLower();

                            if (confirm == "yes")
                            {
                                playerStats.Assassin();
                                classLoop = false;
                            }
                            else if (confirm == "no")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Almdalf: Just say Yes or No, don't overcomplicate it");
                            }

                        }
                        else if (answer == 3)
                        {
                            Console.WriteLine("Almdalf: You have selected Thief, Thief Stats\nSpeed: 5\nPower: 3\nStealth: 9");
                            Console.WriteLine("Almdalf: Is this the class you want?");
                            string confirm = Console.ReadLine().ToLower();

                            if (confirm == "yes")
                            {
                                playerStats.Thief();
                                classLoop = false;
                            }
                            else if (confirm == "no")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Almdalf: Just say Yes or No, don't overcomplicate it");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Almdalf: Please stick to the guide. Its not that hard.");
                    }
                }
            }

            void GetFaction()
            {
                bool factionLoop = true;
                while (factionLoop)
                {
                    Console.WriteLine("Aldalf: Your Faction, Is your people! Also, it kinda decides your weapon\n pick wisely!");
                    Console.WriteLine("");
                    Console.WriteLine("1. Almdall \n2. Warwren \n3. Elvenrun\n4. WhiteWall \nPlease enter number 1-4");
                    string input = Console.ReadLine();

                    int answer = Int32.Parse(input);

                    if (answer > 0 && answer < 5)
                    {
                        Faction Home = (Faction)answer;
                        

                        if (answer == 1)
                        {

                            Console.WriteLine($"Almdalf: You have selected Almdall, You will recieve a Staff!");
                            Console.WriteLine("");
                            Console.WriteLine("Almdalf: Is this the Faction you want?");
                            
                            string confirm = Console.ReadLine().ToLower();

                            if (confirm == "yes")
                            {
                                
                                p.Inventory.Add(new Items("Starter Staff", "Basically a better stick", 3));
                                factionLoop = false;
                            }
                            else if (confirm == "no")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Almdalf: Just say Yes or No, don't overcomplicate it");
                            }
                        }
                        else if (answer == 2)
                        {
                            Console.WriteLine($"Almdalf: You have selected Warwren, You will recieve a Dagger!");
                            Console.WriteLine("Almdalf: Is this the Faction you want?");
                            string confirm = Console.ReadLine().ToLower();

                            if (confirm == "yes")
                            {
                                p.Inventory.Add(new Items("Starter Dagger", "For a weapon it looks cute. But like a tiger will kill you!", 4));
                                factionLoop = false;
                            }
                            else if (confirm == "no")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Almdalf: Just say Yes or No, don't overcomplicate it");
                            }
                        }
                        else if (answer == 3)
                        {
                            Console.WriteLine($"Almdalf: You have selected Elverun, You will recieve a Sword!");
                            Console.WriteLine("Almdalf: Is this the Faction you want?");
                            string confirm = Console.ReadLine().ToLower();

                            if (confirm == "yes")
                            {
                                p.Inventory.Add(new Items("Starter Sword", "Pretty standard. Long and pointy", 6));
                                factionLoop = false;
                            }
                            else if (confirm == "no")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Almdalf: Just say Yes or No, don't overcomplicate it");
                            }
                        }
                        else if (answer == 4)
                        {
                            Console.WriteLine($"Almdalf: You have selected Whitewall, You will recieve a Spear!");
                            Console.WriteLine("Almdalf: Is this the Faction you want?");
                            string confirm = Console.ReadLine().ToLower();

                            if (confirm == "yes")
                            {
                                p.Inventory.Add(new Items("Starter Spear", "If a staff and dagger had a baby", 5));
                                factionLoop = false;
                            }
                            else if (confirm == "no")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Almdalf: Just say Yes or No, don't overcomplicate it");
                            }
                        }
                    }
                }

              
            }

            void Confirm()
            {
                
                bool confirmLoop = true;
                while (confirmLoop)
                {
                    Console.WriteLine("Almdalf: Ok brave adventurer, nows the time!");
                    Console.WriteLine($"Almdalf: You are {name} of {Home} and you are a {Role}, is that right?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes")
                    {
                        confirmLoop = false;
                        mainLoop = false;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Almdalf: Ok try again, Pay attention this time!\n");
                        
                        confirmLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Almdalf: Yes or No, Thanks");
                    }
                }             
            }
        }

        
    }
}
