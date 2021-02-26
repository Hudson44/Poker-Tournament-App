using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
    public class SelectTournament
    {   
        public static void Select(Tournament tournament)
        {
            Console.Clear();
            Console.WriteLine(tournament);

            Console.ReadLine();
        }
    }
}