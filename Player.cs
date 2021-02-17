using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
    class Player
    {
        string name;
        DateTime dateJoined; //new DateTime(year, month, day)
        DateTime birthday; //new DateTime(year, month, day)
        string hometown;
        int rankChips;

        Dictionary<string, int> winningHandCount = new Dictionary<string, int>();

        public Player()
        {
            setName("");
            setDateJoined(new DateTime(1900, 01, 01));
            setBirthday(new DateTime(1900, 01, 01));
            setHometown("");
            setRankChips(0);
        }

        public Player(string inName, DateTime inDateJoined, DateTime inBirthday, string inHometown, int inRankChips)
        {
            setName(inName);
            setDateJoined(inDateJoined);
            setBirthday(inBirthday);
            setHometown(inHometown);
            setRankChips(inRankChips);
        }

        public void setName(string inName)
        {
            name = inName;
        }

        public string getName()
        {
            return name;
        }

        public void setDateJoined(DateTime inDateJoined)
        {
            dateJoined = inDateJoined;
        }

        public DateTime getDateJoined()
        {
            return dateJoined;
        }

        public void setBirthday(DateTime inBirthday)
        {
            birthday = inBirthday;
        }

        public DateTime getBirthday()
        {
            return birthday;
        }

        public void setHometown(string inHometown)
        {
            hometown = inHometown;
        }

        public string getHometown()
        {
            return hometown;
        }

        public void setRankChips(int inRankChips)
        {
            rankChips = inRankChips;
        }

        public int getRankChips()
        {
            return rankChips;
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
