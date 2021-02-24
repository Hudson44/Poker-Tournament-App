
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
                Console.WriteLine("[n] Next [b] Back");

                if (displayed < Tournaments.Count){
                    if (selection == "n"){
                        displayed += displayAmount;
                    }
                }

                if (displayed >= displayAmount){
                    if (selection == "b"){
                        displayed -= displayAmount;
                    }
                }

                try{
                    foreach (int i in Enumerable.Range(displayed, displayAmount)){
                        Console.WriteLine(Tournaments[i].TournamentID + " " + Tournaments[i].Name);
                    }
                }
                catch{
                    
                }

                //print tournament information
                /*foreach (Tournament tournament in Tournaments){
                Console.WriteLine(tournament.TournamentID + " " + tournament.Name);
                
                }*/Console.WriteLine(displayed);

                selection = Console.ReadLine();
            }
            

        }
    }
}