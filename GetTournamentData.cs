using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Poker_Tournament_App
{
  //pulls tournament information from the tournament csv and adds it to the list in TournamentList
  public class GetTournamentData
  {
    public static void GetData()
    {
      Tournament newTournament;
      List<string> Values = new List<string>();
      
      using(StreamReader reader = new StreamReader(@"Poker League Sample Data - Tournaments.csv")){
        //pull header row from csv file
        string headerLine = reader.ReadLine();
        string[] headers = headerLine.Split(',');
        
        while (!reader.EndOfStream){
          //pull tournament information from csv file
          string line = reader.ReadLine();

          //splits line on commas not in double quotes
          string[] values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

          //strip quotes from data
          for (int i = 0; i < values.Length; i++){
            values[i] = values[i].Replace("\"", "");
          }

          //create a new tournament with the data
          newTournament = new Tournament(values[0], values[1], DateTime.Parse(values[2],CultureInfo.InvariantCulture), values[3], Int32.Parse(values[6]), values[7], values[8], values[9], values[10], values[11]);
          
          //add new tournament to the tournament list
          TournamentList.Tournaments.Add(newTournament);
        }
      }
    }
  }
}