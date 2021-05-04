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
                    int rankedChips = 0;
                    for (int i = 6; i < 15; i++)
                    {

                        header = headers[i];
                        valueString = values[i + 1];
                        if (valueString == "")
                        {
                            valueInt = 0;

                        }
                        else
                        {
                            valueInt = Int32.Parse((valueString));

                        }
                        numWinningHands.Add(header, valueInt);
                        Console.WriteLine($"");
                    }

                    //Player winning hand from csv file


                    //int index = Array.IndexOf(values, value);

                    //Calcualte Rankedchips here
                    String name = (values[0] + "," + values[1]).Replace("\"", "");

                    foreach (Tournament tournament in TournamentList.Tournaments)
                    {
                        if (name == tournament.FirstPlace)
                            rankedChips += 4;
                            else if (name == tournament.SecondPlace)
                            rankedChips += 3;
                            else if (name == tournament.ThirdPlace)
                            rankedChips += 2;
                            else if (name == tournament.FourthPlace)
                            rankedChips += 1;
                        
                    }
                    
                    newPlayer = new Player(name, values[3], values[4], values[5], numWinningHands, rankedChips);
                    PlayerList.Players.Add(newPlayer);
                }
            }
        }
    }
}