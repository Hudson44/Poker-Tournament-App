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
      printString += "\nDate Joined:\t" + DateJoined.ToString("dd/MM/yyyy");
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

        Console.WriteLine(inPlayer);

        Console.WriteLine("\n[q] quit [e] edit player");

        selection = Console.ReadLine();

        if (selection == "e"){
          EditPlayer(inPlayer);
        }
      }
    }

    //edits existing player information
    public static void EditPlayer(Player player)
    {
      string toEdit = "";

      while (toEdit != "q"){
        Console.Clear();

        Console.WriteLine(player);
        Console.WriteLine("\nWhat to edit: \n\n"+
                          "1. Name \n"+
                          "2. Date joined \n"+
                          "3. Birthday \n"+
                          "4. Hometown \n"+
                          "5. Rank chips \n\n"+
                          "[q] quit");

        toEdit = Console.ReadLine();
        
        Console.Clear();

        switch(toEdit){
          case "1":
            Console.WriteLine("\nEnter new name:");
            player.Name = Console.ReadLine();
            break;
          case "2":
            Console.WriteLine("\nEnter new date joined [dd/mm/yyyy]:");
            string errorMessage = "Error: invalid input \n\nEnter new date joined [dd/mm/yyyy]:";

            player.DateJoined = DateTime.Parse(Validate.ValidateDate(Console.ReadLine(), errorMessage));
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
            errorMessage = "Error: invalid input \n\nEnter new rank chips:";
            
            player.RankChips = Validate.ValidateInt(Console.ReadLine(), errorMessage);
            break;
        }
      }
    }
  }
}
