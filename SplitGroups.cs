using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App{
  public class SplitGroups {
    static int groupSize = 4;
    public static List<List<Player>> groups = new List<List<Player>>(); 

    public static void Split()/*List<List<float[]>> Split(List<float[]> locations, int nSize=30)*/
    {
      for (int i = 0; i < PlayerList.Players.Count; i += groupSize)
      {
        groups.Add(PlayerList.Players.GetRange(i, Math.Min(groupSize, PlayerList.Players.Count - i))); 
      }

      foreach (List<Player> group in groups){
        foreach (Player player in group){
          Console.WriteLine(player.Name);
        }
        Console.WriteLine("-------------");
      }
      

      Console.ReadLine();
    } 
  }
}