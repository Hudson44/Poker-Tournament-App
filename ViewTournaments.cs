
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
    class ViewTournament
    {   
        public static void View()
        {
            string selection = "";
            int displayed = 0;
            int displayAmount = 10;

            List<Tournament> Tournaments = GetTournamentData.GetData();
            while (!(selection == "q")){
                Console.Clear();
                Console.WriteLine("Select a tournament by ID:\n");

                //allow using "next" if not at the end of the list of tournaments
                if (displayed < Tournaments.Count - displayAmount){
                    if (selection == "n"){
                        displayed += displayAmount;
                    }
                }

                //allow using "back" if not at the beginning of the list of tournaments
                if (displayed >= displayAmount){
                    if (selection == "b"){
                        displayed -= displayAmount;
                    }
                }

                //prevent errors when the end of the list is reached
                try{
                    //print information for tournaments in display range
                    foreach (int i in Enumerable.Range(displayed, displayAmount)){
                        Console.WriteLine(Tournaments[i].TournamentID + " " + Tournaments[i].Name);
                    }
                }
                catch{
                    
                }

                Console.WriteLine("\n[n] Next [b] Back [q] quit\n");

                selection = Console.ReadLine();

                foreach (Tournament tournament in Tournaments){
                    if (selection == tournament.TournamentID){
                        SelectTournament.Select(tournament);
                    }
                }
            }
            

        }
    }
}