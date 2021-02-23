using System;
using System.Collections.Generic;
using System.IO;

namespace Poker_Tournament_App
{
    class GetTournamentData
    {
        public static void GetData()
        {
            List<Tournament> Tournaments = new List<Tournament>();

            Tournament newTournament;
            using(StreamReader reader = new StreamReader(@"Tournaments.csv")){
                while (!reader.EndOfStream){
            
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    newTournament = new Tournament(values[1], values[2], values[3], Int32.Parse(values[7]));
                    
                    Tournaments.Add(newTournament);
                }
            }

            //printing out the list
            foreach (Tournament tournament in Tournaments){
            Console.WriteLine(tournament);
            }
        }
    }
}