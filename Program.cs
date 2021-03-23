using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  class Program
  {
    public static void Main (string[] args) {
      string selection = "";

      if (!TournamentList.Tournaments.Any()){
        GetTournamentData.GetData();
      }
      if (!PlayerList.Players.Any()){
        GetPlayerData.GetData();
      }

      while (!(selection == "4")){
        Console.Clear();
        Console.WriteLine("Select an option:\n ");
        Console.WriteLine("1: Tournaments");
        Console.WriteLine("2: Players");
        Console.WriteLine("3: Overall Stats");
        Console.WriteLine("4: Save & Quit");
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
      }
    }
  }
}
