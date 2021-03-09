using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  //collects tournament information from the user and stores it in a new tournament object
  public class NewTournament
  {
    static string enteredData;
    static bool valid = false;
    static int converted;
    static List<string> prompts = new List<string>{"Name: ", "Date: ", "Location: ", "Max players: ", "ID: "};
    static List<string> dataList = new List<string>();
    static Tournament newTournament;

    public static void New()
    {
      //clear list of entered data
      dataList.Clear();
      
      //collect user input
      foreach (string prompt in prompts){
        Console.Clear();
        Console.WriteLine("Enter tournament data:");
        Console.WriteLine("\n" + prompt);
        enteredData = Console.ReadLine();

        //makes sure player counts and IDs are non negative intigers
        if (prompts.IndexOf(prompt) == 3 || prompts.IndexOf(prompt) == 4){
          while (!valid){
            if (int.TryParse(enteredData, out converted) && converted > 0){
              valid = true;
            }
            else{
              Console.Clear();
              Console.WriteLine("Enter tournament data:");
              Console.WriteLine("\nError: invalid input");
              Console.WriteLine("\n" + prompt);
              enteredData = Console.ReadLine();
            }
          }
          valid = false;
        }

        dataList.Add(enteredData);
      }
      
      //create new tournament with user data
      newTournament = new Tournament(dataList[0], dataList[1], dataList[2], Int32.Parse(dataList[3]), dataList[4]);
      TournamentList.Tournaments.Add(newTournament);

      Console.Clear();
      Console.WriteLine("New tournament created:");
      Console.WriteLine(newTournament);
      
      Console.ReadLine();
    }
  }
}