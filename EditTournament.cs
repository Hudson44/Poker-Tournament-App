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
      string toEdit = "";

      while (toEdit != "q"){
        Console.Clear();

        Console.WriteLine(tournament);
        Console.WriteLine("\nWhat to edit:");
        Console.WriteLine("\n1. Name \n2. Date \n3. Location \n4. Max players \n\n[q] quit");

        toEdit = Console.ReadLine();

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
            tournament.MaxPlayers = Int32.Parse(Console.ReadLine());
            break;
        }
      }
    }
  }
}