using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  public class Program
  {
    static int tableWidth = 73;
    public static void Main (string[] args) {
      string selection = "";

      if (!TournamentList.Tournaments.Any()){
        GetTournamentData.GetData();
      }
      if (!PlayerList.Players.Any()){
        GetPlayerData.GetData();
      }

      while (!(selection == "5")){
        Console.Clear();
        Console.WriteLine("Select an option:\n ");
        Console.WriteLine("1: Tournaments");
        Console.WriteLine("2: Players");
        Console.WriteLine("3: Overall Stats");
        Console.WriteLine("4: Top Ten Players");
        Console.WriteLine("5: Save & Quit");
        selection = Console.ReadLine();
      
        if (selection == "1")
        {
          TournamentList.ViewTournaments();
        }
        else if(selection == "2")
        {
          PlayerList.ViewPlayers();
        }
        else if(selection == "3")
        {
          Console.WriteLine("Overall Stats.");
        }
        else if(selection == "4")
        {
          PlayerList.TopTen();
        }
      }
    }

    public static void PrintLine()
    {
        Console.WriteLine(new string('-', tableWidth));
    }

    public static void PrintRow(List<string>columns)
    {
        int width = (tableWidth - columns.Count) / columns.Count;
        string row = "|";

        foreach (string column in columns)
        {
            row += AlignCentre(column, width) + "|";
        }

        Console.WriteLine(row);
    }

    public static string AlignCentre(string text, int width)
    {
        text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

        if (string.IsNullOrEmpty(text))
        {
            return new string(' ', width);
        }
        else
        {
            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }
  }
}
