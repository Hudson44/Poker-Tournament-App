using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
    class Player
    {
        string name;
        DateTime dateJoined;
        DateTime birthday;
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


    }
}
