using System;

namespace Poker_Tournament_App
{
    public class SelectPlayer
    {   
        public static void Select(Player inPlayer)
        {
            Console.Clear();
            Console.WriteLine(inPlayer);

            Console.ReadLine();
        }
    }
}