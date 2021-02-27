using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
    //displays information for a selected tournament
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