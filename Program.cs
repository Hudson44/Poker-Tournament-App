using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            string selection = "";
            //load tournament data
            if (!TournamentList.Tournaments.Any())
            {
                GetTournamentData.GetData();
            }
            //load Player data
            if (!PlayerList.Players.Any())
            {
                GetPlayerData.GetData();
            }
            // TournamentList.Tournaments[0].RegisterPlayer(PlayerList.Players[0]);
            // Console.Write(TournamentList.Tournaments[0].Registrants[0]);
            // Console.ReadLine();
            while (!(selection == "4"))
            {
                Console.Clear();
                Console.WriteLine("Select an option:\n ");
                Console.WriteLine("1: Tournaments");
                Console.WriteLine("2: Players");
                Console.WriteLine("3: Overall Stats");
                Console.WriteLine("4: Save & Quit");
                Console.WriteLine("5: Total Ranked Chips");
                selection = Console.ReadLine();
                

                if (selection == "1")
                {
                    ViewTournament.View();
                }
                else if (selection == "2")
                {
                    ViewPlayer.View();
                }
                else if (selection == "3")
                {
                    Console.WriteLine("Overall Stats.");
                }
                else if (selection == "5")
                {
                      Console.WriteLine(PlayerList.GetTotalChips());
                      Console.ReadLine();
                }
            }
        }
    }
}
