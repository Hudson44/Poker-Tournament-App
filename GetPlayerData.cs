using System;
using System.Collections.Generic;
using System.IO;

namespace Poker_Tournament_App
{
  public class GetPlayerData
  {
    public static void GetData()
    { 
      Player newPlayer;

      using(StreamReader reader = new StreamReader(@"Poker League Sample Data - Players.csv"))
      {
        //Header row from csv file
        string headerLine = reader.ReadLine();
        string[] headers = headerLine.Split(',');

        while (!reader.EndOfStream)
        {
          //Player information from csv file
          string line = reader.ReadLine();
          string[] values = line.Split(',');
          newPlayer = new Player((values[0] + "," + values[1]).Replace("\"", ""), values[2], values[3], values[4], values[5], 0);
          
          //Player winning hand from csv file
          foreach (string value in values)
          {
            if (value == "1"){
              int index = Array.IndexOf(values, value);
              newPlayer.updateWinningHandCount(headers[index-1]);
            }
          }

          PlayerList.Players.Add(newPlayer);
        }
      }
    }
  }
}