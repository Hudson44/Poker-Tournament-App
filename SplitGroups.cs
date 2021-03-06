using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App{
  public class SplitGroups {
    static int groupSize = 4;


    public static void Split()
    {
      for (int i = 0; i < PlayerList.Players.Count; i += groupSize)
      {
        GroupList.Groups.Add(PlayerList.Players.GetRange(i, Math.Min(groupSize, PlayerList.Players.Count - i))); 
      }

      foreach (List<Player> group in GroupList.Groups){
        foreach (Player player in group){
          Console.WriteLine(player.Name);
        }
        Console.WriteLine("-------------");
      }
      

      Console.ReadLine();
    } 
  }
}