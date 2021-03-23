/****************************************
 * Authors: Jonathan H., Richard Z., and Anthony S.
 * Date Created: February 12, 2021
 * Data Last Modified: February 18, 2021
 * Project: Poker Tournament App
 * Filename: TournamentApp.cs
 * Instructor: Professor James Munger
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  public class Tournament
  {
    public string Name{get; set;}
    public string Location{get; set;}
    public int MaxPlayers{get; set;}
    public string TournamentDate{get;set;}
    public string TournamentID{get;set;}
    public string WinningHand{get;set;}
    public string FirstPlace{get;set;}
    public string SecondPlace{get;set;}
    public string ThirdPlace{get;set;}
    public string FourthPlace{get;set;}
    public static List<Player> Registered = new List<Player>();

    public Tournament()
    {
      TournamentID = "";
      Name = "";
      TournamentDate = "";
      Location = "";
      MaxPlayers = 0;
      WinningHand = "";
      FirstPlace = "";
      SecondPlace = "";
      ThirdPlace = "";
      FourthPlace = "";
    }

    public Tournament(string inTournamentID, string inName, string inDate, string inLocation, int inMaxPlayers, string inWinningHand, string inFirstPlace, string inSecondPlace, string inThirdPlace, string inFourthPlace)
    {
      TournamentID = inTournamentID;
      Name = inName;
      TournamentDate = inDate;
      Location = inLocation;
      MaxPlayers = inMaxPlayers;
      WinningHand = inWinningHand;
      FirstPlace = inFirstPlace;
      SecondPlace = inSecondPlace;
      ThirdPlace = inThirdPlace;
      FourthPlace = inFourthPlace;
    }

    public override string ToString()
    {
      string printString = "";
      printString += "\nID:\t\t\t" + TournamentID; 
      printString += "\nName:\t\t\t" + Name;
      printString += "\nDate:\t\t\t" + TournamentDate;
      printString += "\nLocation:\t\t" + Location;
      printString += "\nMax Players:\t\t" + MaxPlayers;
      printString += "\nMax Winning Hand:\t" + WinningHand;
      printString += "\nFirst Place:\t\t" + FirstPlace;
      printString += "\nSecond Place:\t\t" + SecondPlace;
      printString += "\nThird Place:\t\t" + ThirdPlace;
      printString += "\nFourth Place:\t\t" + FourthPlace;
      return printString;
    }

    //displays information for a selected tournament
    public static void SelectTournament(Tournament tournament)
    {
      string selection = "";

      while (selection != "q"){
        Console.Clear();
        Console.WriteLine(tournament);

        Console.WriteLine("\n[q] quit [e] edit tournament \n[r] register player \n[p] view registered players");

        selection = Console.ReadLine();

        if (selection == "e"){
          EditTournament(tournament);
        }

        if (selection == "r"){
          Register();
        }

        if (selection == "p"){
          ViewRegistered();
        }
      }
    }

    public static void EditTournament(Tournament tournament)
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

    public static void Register(){
      string toRegister = "";

      while (toRegister != "q"){
        int index = -1;
        string correct = "";

        Console.Clear();
        Console.WriteLine("Enter the ID of the player to register:");
        Console.WriteLine("\n[q] quit");
        toRegister = Console.ReadLine();

        index = PlayerList.Players.FindIndex(Player =>  Player.LeagueNumber == toRegister);
        Console.WriteLine(index);

        //check if a player with the league number exists
        if (index != -1){
          //check if player has already been added
          if (Registered.Any(Player =>  Player.LeagueNumber == toRegister)){
            Console.Clear();
            Console.WriteLine("Player already registered.");
            Console.ReadLine();
          }
          else{
            //check if the intended ID was entered
            while (correct != "y" && correct != "n"){
              Console.Clear();
              Console.WriteLine("Register new player:\n{0}", PlayerList.Players[index].Name);
              Console.WriteLine("\n[y/n]");
              correct = Console.ReadLine();

              //add player to registered list
              if (correct == "y"){
                Registered.Add(PlayerList.Players[index]);

                Console.Clear();
                Console.WriteLine("Player registered.");
                Console.ReadLine();
              }
            }
          }
        }
        else if (toRegister != "q"){
          Console.Clear();
          Console.WriteLine("Player not found.");
          Console.ReadLine();
        }
      }
    }

    public static void ViewRegistered(){
      Console.Clear();
      Console.WriteLine("Registered players:\n");
      foreach (Player player in Registered){
        Console.WriteLine(player.Name);
      }
      Console.ReadLine();
    }
  }
}
