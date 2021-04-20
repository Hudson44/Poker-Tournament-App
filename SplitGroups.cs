using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App{
  //splits players into groups of a specified size
  public class SplitGroups {
    public static void Split()
    {
      int groupSize = 4;
      
      for (int i = 0; i < PlayerList.Players.Count; i += groupSize)
      {
        GroupList.Groups.Add(PlayerList.Players.GetRange(i, Math.Min(groupSize, PlayerList.Players.Count - i))); 
      }
    } 
  }
}