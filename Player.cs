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
    }
}
