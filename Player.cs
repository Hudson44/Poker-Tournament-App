using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
    class Player
    {
        public string name {get; set;}
        public string dateJoined {get; set;} 
        public string birthday {get; set;} 
        public string hometown {get; set;}
        public int rankChips {get; set;}

        public Dictionary<string, int> winningHandCount = new Dictionary<string, int>();

        public Player()
        {
            name = "";
            dateJoined = "";
            birthday = "";
            hometown = "";
            rankChips = 0;
        }

        public Player(string inName, string inDateJoined, string inBirthday, string inHometown, int inRankChips)
        {
            name = inName;
            dateJoined = inDateJoined;
            birthday = inBirthday;
            hometown = inHometown;
            rankChips = inRankChips;
        }

        public void updateWinningHandCount(string inHandType)
        {
            if(winningHandCount.ContainsKey(inHandType))
            {
            winningHandCount[inHandType] = winningHandCount[inHandType] + 1;
            }
            else
            {
            winningHandCount.Add(inHandType, 1);
            }
        }

        public override string ToString()
        {
            string printString = ""; 
            printString += "\nName:\t\t" + name;
            printString += "\nDate Joined:\t" + dateJoined;
            printString += "\nBirthday:\t" + birthday;
            printString += "\nHometown:\t" + hometown;
            printString += "\nRank Chips:\t" + rankChips;
            return printString;
        }
    }
}
