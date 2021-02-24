
using System;

namespace Poker_Tournament_App
{
    class ViewTournament
    {   
        public static void View()
        {
            string selection;

            Console.WriteLine("Select a tournament:\n");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                GetTournamentData.GetData();
            }
        }
    }
}