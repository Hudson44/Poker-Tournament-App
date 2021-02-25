using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Poker_Tournament_App
{
    class GetTournamentData
    {
        public static List<Tournament> GetData()
        {
            //list of tournament instances

            Tournament newTournament;
            
            using(StreamReader reader = new StreamReader(@"Poker League Sample Data - Tournaments.csv")){
                //header row from csv file
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(',');
                
                while (!reader.EndOfStream){
                    //tournament information from csv file
                    string line = reader.ReadLine();
                    string[] values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    newTournament = new Tournament(values[1], values[2], values[3], Int32.Parse(values[6]), values[0]);
                    
                    TournamentList.Tournaments.Add(newTournament);
                }
            }

            return(TournamentList.Tournaments);
        }
    }
}