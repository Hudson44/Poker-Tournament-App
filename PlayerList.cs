using System;
using System.IO;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
    public static class PlayerList
    {
        public static List<Player> Players = new List<Player>();
        public static int GetTotalChips()
        {
          int total = 0;
            foreach (Player player in Players)
            {
            total += player.RankChips;
            }
            return total;
        }

    }
}