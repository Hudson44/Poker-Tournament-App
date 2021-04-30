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

            using (StreamReader reader = new StreamReader(@"Poker League Sample Data - Players.csv"))
            {
                //Header row from csv file
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(',');

                while (!reader.EndOfStream)
                {
                    //Player information from csv file
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    Dictionary<string, int> numWinninghands = new Dictionary<string, int>();

                    for (int i = 6; i < 15; i++)
                    {
                        if (values[i + 1] == "")
                            numWinninghands.Add(headers[i + 1], 0);
                        else
                            numWinninghands.Add(headers[i + 1], Int32.Parse(values[i + 1]));
                        Console.WriteLine($"{numWinninghands.Keys(numWinninghands[name]) }");
                    }
                   
                                        //Player winning hand from csv file


                                        //int index = Array.IndexOf(values, value);



                                        newPlayer = new Player((values[0] + "," + values[1]).Replace("\"", ""), values[3], values[4], values[5]);
                    PlayerList.Players.Add(newPlayer);
                }
            }
        }
    }
}