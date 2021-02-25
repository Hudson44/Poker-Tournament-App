using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Poker_Tournament_App
{
    public class GetTournamentData
    {
        public static void GetData()
        {
            Tournament newTournament;
            
            using(StreamReader reader = new StreamReader(@"Poker League Sample Data - Tournaments.csv")){
                //pull header row from csv file
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(',');
                
                while (!reader.EndOfStream){
                    //pull tournament information from csv file
                    string line = reader.ReadLine();

                    //splits line on commas not in double quotes
                    string[] values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    newTournament = new Tournament(values[1], values[2], values[3], Int32.Parse(values[6]), values[0]);
                    
                    //add new tournament to the tournament list
                    TournamentList.Tournaments.Add(newTournament);
                }
            }
        }
    }
}