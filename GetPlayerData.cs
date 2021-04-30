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
                    Dictionary<string, int> numWinningHands = new Dictionary<string, int>();
                    string header;
                    string valueString;
                    int valueInt;
                    for (int i = 6; i < 15; i++)
                    {
                        
                        header = headers[i];
                        valueString = values[i+1];
                        if (valueString == ""){
                            valueInt = 0;
                        
                        }else{
                            valueInt = Int32.Parse((valueString));
                        
                        }
                        numWinningHands.Add(header, valueInt);
                        Console.WriteLine($"");
                    }

                    //Player winning hand from csv file


                    //int index = Array.IndexOf(values, value);



                    newPlayer = new Player((values[0] + "," + values[1]).Replace("\"", ""), values[3], values[4], values[5], numWinningHands);
                    PlayerList.Players.Add(newPlayer);
                }
            }
        }
    }
}