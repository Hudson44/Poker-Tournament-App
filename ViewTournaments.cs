
using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
    class ViewTournament
    {   
        public static void View()
        {
            string selection;
            List<Tournament> Tournaments = GetTournamentData.GetData();

            Console.WriteLine("Select a tournament:\n");

            foreach (Tournament tournament in Tournaments){
            Console.WriteLine(tournament.Name);
            
            }

            selection = Console.ReadLine();

        }
    }
}