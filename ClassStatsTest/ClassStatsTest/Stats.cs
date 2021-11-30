using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    class Statisics
    {


        //Base stats
        public static float speed;
        public static float power;
        public static float stealth;



        public void GetStats()
        {
            Console.WriteLine($"Health: {Player.health}\nSpeed: {speed} \nPower: {power} \nStealth: {stealth}");
        }
        
        public void Maurauder()
        {
            speed = 4;
            power = 7;
            stealth = 3;
        }
        public void Assassin()
        {
            speed = 6;
            power = 4;
            stealth = 6;
        }
        public void Thief()
        {
            speed = 5;
            power = 3;
            stealth = 9;

        }
        
        
  
    }

}
