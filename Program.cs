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

    public static string VerifyDate(string stringDate, string errorMessage){
      DateTime date;

      while (true){
        if (DateTime.TryParseExact(stringDate, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date)){
          return date.ToString("dd/MM/yyyy").Substring(0, date.ToString().Length - 11);
        }
        else{
          Console.Clear();
          Console.WriteLine(errorMessage);
          stringDate = Console.ReadLine();
        }
      }
    }

    public static int VerifyInt(string stringNum, string errorMessage){
      int intiger;

      while (true){
        if (int.TryParse(stringNum, out intiger) && intiger > 0){
          return intiger;
        }
        else{
          Console.Clear();
          Console.WriteLine(errorMessage);
          stringNum = Console.ReadLine();
        }
      }
    }
  }
}
