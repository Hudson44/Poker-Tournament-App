using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  //collects tournament information from the user and stores it in a new tournament object
  public class NewTournament
  {
    static List<string> prompts = new List<string>{"Name: ", "Date: ", "Location: ", "Max players: ", "ID: "};
    static List<string> enteredData = new List<string>();
    static Tournament newTournament;

    public static void New()
    {
      Console.Clear();
      Console.WriteLine("Enter tournament data:");
      
      //clear list of entered data
      enteredData.Clear();
      
      //collect user input
      foreach (string prompt in prompts){
        Console.WriteLine("\n" + prompt);
        enteredData.Add(Console.ReadLine());
      }
      
      //create new tournament with user data
      newTournament = new Tournament(enteredData[0], enteredData[1], enteredData[2], Int32.Parse(enteredData[3]), enteredData[4]);
      TournamentList.Tournaments.Add(newTournament);
      
      Console.ReadLine();
    }
  }
}