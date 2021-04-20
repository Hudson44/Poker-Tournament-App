using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Poker_Tournament_App
{
  public class Program
  {
    public static void Main (string[] args) {
      string selection = "";

      //pull csv data
      if (!TournamentList.Tournaments.Any()){
        GetTournamentData.GetData();
      }
      if (!PlayerList.Players.Any()){
        GetPlayerData.GetData();
      }

      while (!(selection == "0")){
        Console.Clear();
        Console.WriteLine("Select an option:\n\n"+
                          "1: Tournaments \n"+
                          "2: Players \n"+
                          "3: Overall Stats \n"+
                          "4: Top Ten Players \n"+
                          "5: Last Five Tournaments \n"+
                          "0: Save & Quit");

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
  }
}
