using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
    public class Player
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string DateJoined {get; set;} 
        public string Birthday {get; set;} 
        public string Hometown {get; set;}
        public int RankChips {get; set;}

        public Dictionary<string, int> WinningHandCount = new Dictionary<string, int>();

        public Player()
        {
            Id = -1;
            Name = "";
            DateJoined = "";
            Birthday = "";
            Hometown = "";
            RankChips = 0;
        }

        public Player(int inId, string inName, string inDateJoined, string inBirthday, string inHometown, int inRankChips)
        {
            Id = inId;
            Name = inName;
            DateJoined = inDateJoined;
            Birthday = inBirthday;
            Hometown = inHometown;
            RankChips = inRankChips;
        }

        public void updateWinningHandCount(string inHandType)
        {
            if(WinningHandCount.ContainsKey(inHandType))
            {
                WinningHandCount[inHandType] = WinningHandCount[inHandType] + 1;
            }
            else
            {
                WinningHandCount.Add(inHandType, 1);
            }
        }

        public override string ToString()
        {
            string printString = ""; 
            printString += "\nName:\t\t" + Name;
            printString += "\t#" + Id;
            printString += "\nDate Joined:\t" + DateJoined;
            printString += "\nBirthday:\t" + Birthday;
            printString += "\nHometown:\t" + Hometown;
            printString += "\nRank Chips:\t" + RankChips;
            printString += "\nWinning Hands:\n" + string.Join(Environment.NewLine, WinningHandCount);
            return printString;
        }

        public static void Select(Player inPlayer)
        {
            Console.Clear();
            Console.WriteLine(inPlayer);

            Console.ReadLine();
        }
    }
}
