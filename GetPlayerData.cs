using System;
using System.Collections.Generic;
using System.IO;

namespace Poker_Tournament_App
{
    public class GetPlayerData
    {
        public static void GetData()
        {   //list of player instances
            List<Player> Players = new List<Player>();

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
                    newPlayer = new Player((values[0] + "," + values[1]).Replace("\"", ""), values[3], values[4], values[5], 0, values[2]);
                    
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