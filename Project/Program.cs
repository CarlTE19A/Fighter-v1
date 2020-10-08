using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int fighter1Hp = 100;
            int fighter2Hp = 100;

            string fighter1 = "";
            string fighter2 = "";

            Random generator = new Random();

            int fightS1;
            int fightS2;

            System.Console.WriteLine("Are you ready to RUMLE!!");
            Console.ReadLine();
            Console.Clear();
            System.Console.Write("In the left corner we have ");
            fighter1 = Console.ReadLine();
            System.Console.Write("AAAANNND In the right corner we have ");
            fighter2 = Console.ReadLine();
            while(fighter1Hp > 0 && fighter2Hp > 0){
                fightS1 = generator.Next(51);
                fightS2 = generator.Next(51);
                fighter1Hp -= fightS2;
                fighter2Hp -= fightS1;
                if(fighter1Hp < 0)
                {
                    fighter1Hp = 0;
                }

                if(fighter2Hp < 0)
                {
                    fighter2Hp = 0;
                }

                if(fightS1 > fightS2)
                {
                    System.Console.WriteLine(fighter1 + " got in a good hit taking " + fighter2 + " to " + fighter2Hp + " health!");
                    System.Console.WriteLine(fighter2 + " at least got in a hit and took " + fighter1 + " to " + fighter1Hp + " health!");
                }
                else if(fightS1 < fightS2)
                {
                    System.Console.WriteLine(fighter2 + " got in a good hit taking " + fighter1 + " to " + fighter1Hp + " health!");
                    System.Console.WriteLine(fighter1 + " at least got in a hit and took " + fighter2 + " to " + fighter2Hp + " health!");
                }
                Console.ReadLine();
                Console.Clear();
            }
            if(fighter1Hp == 0 && fighter2Hp == 0)
            {
                System.Console.WriteLine("Both Fighters are down and its a DRAW!!");
                System.Console.WriteLine("Goodbye people and come for the next fight TOMORROW!");
            }
            else if(fighter1Hp == 0)
            {
                System.Console.WriteLine(fighter1 + " is down and " + fighter2 + " is the WINNER!");
            }
            else if(fighter2Hp == 0)
            {
                System.Console.WriteLine(fighter2 + " is down and " + fighter1 + " is the WINNER!");
            }
            Console.ReadLine();
        }
    }
}
