using System;
using System.Collections.Generic;
using System.IO;

namespace Poker_Tournament_App
{
    class GetPlayerData
    {
        public static void GetData()
        {   //list of player instances
            List<Player> Players = new List<Player>();

            Player newPlayer;

            using(StreamReader reader = new StreamReader(@"Poker League Sample Data - Players.csv")){
                //header row from csv file
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(',');

                while (!reader.EndOfStream){
                    //player information from csv file
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    newPlayer = new Player(values[1] + " " + values[0], values[3], values[4], values[5], 0);
                    
                    //player winning hand from csv file
                    foreach (string value in values){
                        if (value == "1"){
                            int index = Array.IndexOf(values, value);
                            newPlayer.updateWinningHandCount(headers[index-1]);
                        }
                    }

                    Players.Add(newPlayer);
                }
            }

            //printing player information
            foreach (Player player in Players){
                Console.WriteLine(player);
                foreach (KeyValuePair<string, int> hand in player.winningHandCount){
                    Console.WriteLine("Hand: {0}, Times: {1}", hand.Key, hand.Value);
                }
            }
        }
    }
}