using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  public class Program
  {
    public static void Main (string[] args) {
      string selection = "";

      if (!TournamentList.Tournaments.Any()){
        GetTournamentData.GetData();
      }
      if (!PlayerList.Players.Any()){
        GetPlayerData.GetData();
      }

      while (!(selection == "6")){
        Console.Clear();
        Console.WriteLine("Select an option:\n ");
        Console.WriteLine("1: Tournaments");
        Console.WriteLine("2: Players");
        Console.WriteLine("3: Overall Stats");
        Console.WriteLine("4: Top Ten Players");
        Console.WriteLine("5: Last Five Tournaments");
        Console.WriteLine("6: Save & Quit");
        selection = Console.ReadLine();
      
        switch(selection){
          case "1":
            TournamentList.ViewTournaments();
            break;
          case "2":
            PlayerList.ViewPlayers();
            break;
          case "3":
            Console.WriteLine("Overall Stats.");
            break;
          case "4":
            PlayerList.TopTen();
            break;
          case "5":
            TournamentList.LastTournaments();
            break;
        }
      }
    }

    public static void VerifyDate(){
      //!move date verification here!
      
    }
  }
}
