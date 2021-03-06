using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
  public class Player
  {
    public string Name {get; set;}
    public string LeagueNumber {get; set;}
    public string DateJoined {get; set;} 
    public string Birthday {get; set;} 
    public string Hometown {get; set;}
    public int RankChips {get; set;}

    public Dictionary<string, int> WinningHandCount = new Dictionary<string, int>();

    public Player()
    {
      Name = "";
      LeagueNumber = "";
      DateJoined = "";
      Birthday = "";
      Hometown = "";
      RankChips = 0;
    }

    public Player(string inName, string inLeagueNumber, string inDateJoined, string inBirthday, string inHometown, int inRankChips)
    {
      Name = inName;
      LeagueNumber = inLeagueNumber;
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
      printString += "\nLeague Number\t" + LeagueNumber;
      printString += "\nDate Joined:\t" + DateJoined;
      printString += "\nBirthday:\t" + Birthday;
      printString += "\nHometown:\t" + Hometown;
      printString += "\nRank Chips:\t" + RankChips;
      printString += "\nWinning Hands:\n" + string.Join(Environment.NewLine, WinningHandCount);
      return printString;
    }

    public static void SelectPlayer(Player inPlayer)
    {
      Console.Clear();
      Console.WriteLine(inPlayer);

      Console.ReadLine();
    }
  }
}
