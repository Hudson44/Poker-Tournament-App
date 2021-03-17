using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  //the user can select a tournament, choose a field, and edit it
  public class EditTournament
  {  
    public static void Edit(Tournament tournament)
    {
      bool valid = false;
      int converted;
      string playerCount;
      string toEdit = "";

      while (toEdit != "q"){
        Console.Clear();

        Console.WriteLine(tournament);
        Console.WriteLine("\nWhat to edit:");
        Console.WriteLine("\n1. Name \n2. Date \n3. Location \n4. Max players \n5. Winning hand \n6. First place \n7. Second place \n8. Third place \n9. Fourth place \n\n[q] quit");

        toEdit = Console.ReadLine();
        
        Console.Clear();

        switch(toEdit){
          case "1":
            Console.WriteLine("\nEnter new name:");
            tournament.Name = Console.ReadLine();
            break;
          case "2":
            Console.WriteLine("\nEnter new date:");
            tournament.TournamentDate = Console.ReadLine();
            break;
          case "3":
            Console.WriteLine("\nEnter new location:");
            tournament.Location = Console.ReadLine();
            break;
          case "4":
            Console.WriteLine("\nEnter new max player amount:");

            //makes sure player count is a non negative intiger
            while (!valid){
              playerCount = Console.ReadLine();
              if (int.TryParse(playerCount, out converted) && converted > 0){
                tournament.MaxPlayers = Int32.Parse(playerCount);
                valid = true;
              }
              else{
                Console.Clear();
                Console.WriteLine("\nError: invalid input");
                Console.WriteLine("\nEnter new max player amount:");
              }
            }
            valid = false;
            break;
          case "5":
            Console.WriteLine("\nEnter new winnig hand:");
            tournament.WinningHand = Console.ReadLine();
            break;
          case "6":
            Console.WriteLine("\nEnter new first place winner:");
            tournament.FirstPlace = Console.ReadLine();
            break;
          case "7":
            Console.WriteLine("\nEnter new second place winner:");
            tournament.SecondPlace = Console.ReadLine();
            break;
          case "8":
            Console.WriteLine("\nEnter new third place winner:");
            tournament.ThirdPlace = Console.ReadLine();
            break;
          case "9":
            Console.WriteLine("\nEnter new fourth place winner:");
            tournament.FourthPlace = Console.ReadLine();
            break;
        }
      }
    }
  }
}