using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
    class Player
    {
        public string name {get; set;}
        public DateTime dateJoined {get; set;} //new DateTime(year, month, day)
        public DateTime birthday {get; set;} //new DateTime(year, month, day)
        public string hometown {get; set;}
        public int rankChips {get; set;} //new DateTime(year, month, day)

        Dictionary<string, int> winningHandCount = new Dictionary<string, int>();

        public Player()
        {
            name = "";
            dateJoined = new DateTime(1900, 01, 01);
            birthday = new DateTime(1900, 01, 01);
            hometown = "";
            rankChips = 0;
        }

        public Player(string inName, DateTime inDateJoined, DateTime inBirthday, string inHometown, int inRankChips)
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
    }
}
