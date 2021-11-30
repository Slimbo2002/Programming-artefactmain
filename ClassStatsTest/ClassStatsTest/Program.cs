
using System;

namespace ClassStatsTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Rooms r = new Rooms();
            Player player = new Player();
            Statisics playerStats = new Statisics();
            CharacterCreation p = new CharacterCreation();

            Console.WriteLine("Almdalf: Greetings adventurer, I am Aldalf of Almdall, son of Almfall and father to Alm... you get it.");
            Console.WriteLine("");

            p.PlayerCreation(); //runs the player creation method

            Console.WriteLine("");

            playerStats.GetStats(); //Displays player stats
            Console.WriteLine("");

            Console.WriteLine($"Almdalf: Ok {p.name}, The adventure.... begins!\n");
            bool game = true;

            //runs the game
            while (game)
            {
                Console.WriteLine("");
                Console.WriteLine("Move\nInventory\nQuests\n"); //displays options
                Console.WriteLine("");

                string answer = Console.ReadLine().ToLower();
                if (answer == "move")
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You are here: {Rooms.currentLocation}");
                    
                    bool movement = true;

                    while (movement)//makes player go to different reions of the world
                    {
                        Console.WriteLine("Where would you like to go?\nAlmdall\nWarwren\nElvenRun\nWhitewall\nExit");
                        string move = Console.ReadLine().ToLower();

                        if (move == "almdall")
                        {
                            Console.WriteLine("");
                            r.Almdall();
                        }
                        else if (move == "warwren")
                        {
                            Console.WriteLine("");
                            r.Warwren();
                        }
                        else if (move == "elvenrun")
                        {
                            Console.WriteLine("");
                            r.Elvenrun();
                        }
                        else if (move == "whitewall")
                        {
                            Console.WriteLine("");
                            r.Whitewall();
                        }
                        else if (move == "exit")
                        {
                            movement = false;
                        }
                        else
                        {
                            Console.WriteLine("Where is that? Please pick a REAL location");
                        }
                    }
                }
                else if (answer == "inventory") //opens inventory
                {
                    Console.WriteLine("");
                    player.OpenInventory();
                }
                else if (answer == "quests") //open quest log
                {
                    Console.WriteLine("");
                    player.currentQuests();

                }
            }

            

        }
    }
}
