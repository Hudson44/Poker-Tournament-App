using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
  public class Player
  {
    public string Name {get; set;}
    public string LeagueNumber {get; set;}
    public DateTime DateJoined {get; set;}
    public string Birthday {get; set;} //!csv needs to be altered to allow DateTime type!
    public string Hometown {get; set;}
    public int RankChips {get; set;}

    public Dictionary<string, int> WinningHandCount = new Dictionary<string, int>();

    public Player()
    {
      Name = "";
      LeagueNumber = "";
      DateJoined = default;
      Birthday = "";
      Hometown = "";
      RankChips = 0;
    }

    public Player(string inName, string inLeagueNumber, DateTime inDateJoined, string inBirthday, string inHometown, int inRankChips)
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
      string selection = "";

      while (selection != "q"){
        Console.Clear();
        //Console.WriteLine(tournament);
        Console.WriteLine(inPlayer);

        Console.WriteLine("\n[q] quit [e] edit player");

        selection = Console.ReadLine();

        if (selection == "e"){
          EditPlayer(inPlayer);
        }
      }
    }

    public static void EditPlayer(Player player)
    {
      bool valid = false;
      int converted;
      string chips;
      string toEdit = "";

      while (toEdit != "q"){
        Console.Clear();

        Console.WriteLine(player);
        Console.WriteLine("\nWhat to edit:");
        Console.WriteLine("\n1. Name \n2. Date joined \n3. Birthday \n4. Hometown \n5. Rank chips \n\n[q] quit");

        toEdit = Console.ReadLine();
        
        Console.Clear();

        switch(toEdit){
          case "1":
            Console.WriteLine("\nEnter new name:");
            player.Name = Console.ReadLine();
            break;
          case "2":
            Console.WriteLine("\nEnter new date joined:");
            //!add exception handling!
            player.DateJoined = DateTime.Parse(Console.ReadLine());
            break;
          case "3":
            Console.WriteLine("\nEnter new birthday:");
            player.Birthday = Console.ReadLine();
            break;
          case "4":
            Console.WriteLine("\nEnter new hometown:");
            player.Hometown = Console.ReadLine();
            break;
          case "5":
            Console.WriteLine("\nEnter new rank chips:");

            //makes sure rank chip count is a non negative intiger
            while (!valid){
              chips = Console.ReadLine();
              if (int.TryParse(chips, out converted) && converted > 0){
                player.RankChips = Int32.Parse(chips);
                valid = true;
              }
              else{
                Console.Clear();
                Console.WriteLine("\nError: invalid input");
                Console.WriteLine("\nEnter new rank chips:");
              }
            }
            valid = false;
            break;
        }
      }
    }
  }
}
