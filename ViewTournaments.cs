
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
    public class ViewTournament
    {   
        public static void View()
        {
            string selection = "";
            int displayed = 0;
            int displayAmount = 10;

            GetTournamentData.GetData();
            
            while (!(selection == "q")){
                Console.Clear();
                Console.WriteLine("Select a tournament by ID:\n");

                //allow using "next" if not at the end of the list of tournaments
                if (displayed < TournamentList.Tournaments.Count - displayAmount){
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
                        Console.WriteLine(TournamentList.Tournaments[i].TournamentID + " " + TournamentList.Tournaments[i].Name);
                    }
                }
                catch{
                    
                }

                Console.WriteLine("\n[n] Next [b] Back [q] quit [new] new tournament\n");

                selection = Console.ReadLine();

                //run NewTournament if "new" is entered
                if (selection == "new"){
                    NewTournament.New();
                }

                //select a tournament with SelectTournament if its ID is entered
                foreach (Tournament tournament in TournamentList.Tournaments){
                    if (selection == tournament.TournamentID){
                        SelectTournament.Select(tournament);
                    }
                }
            }
        }
    }
}