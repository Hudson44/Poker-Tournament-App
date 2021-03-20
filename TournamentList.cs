using System;
using System.IO;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
  //contains the list of tournaments
  public static class TournamentList
  {
    public static List<Tournament> Tournaments = new List<Tournament>();

    public static void ViewTournaments()
    {
      string selection = "";
      int displayed = 0;
      int displayAmount = 10;
      double pages;
      int page;
      
      List<Tournament> DisplayList = new List<Tournament>();

      while (!(selection == "q")){
        DisplayList.Clear();
        Console.Clear();

        Console.WriteLine("Select a tournament:\n");

        //allow using "next" if not at the end of the list of tournaments
        if (displayed < Decimal.Divide(TournamentList.Tournaments.Count, displayAmount) - 1){
          if (selection == "n"){
            displayed += 1;
          }
        }

        //allow using "back" if not at the beginning of the list of tournaments
        if (displayed > 0){
          if (selection == "b"){
            displayed -= 1;
          }
        }

        //gets total pages and current page
        pages = Math.Ceiling(Convert.ToDouble(TournamentList.Tournaments.Count)/displayAmount);
        page = displayed + 1;

        //gets the tournaments for the displyed group and puts them in DisplayList
        foreach (Tournament tournament in TournamentList.Tournaments.GetRange(displayed*displayAmount, Math.Min(displayAmount, TournamentList.Tournaments.Count - displayed*displayAmount))){
          DisplayList.Add(tournament);
        }

        //displays the name of each tournament in DisplayList in a numbered list
        foreach (Tournament tournament in DisplayList){
          Console.WriteLine("{0}. {1}", (DisplayList.IndexOf(tournament) + 1).ToString(), tournament.Name);
        }

        //displays page information
        Console.WriteLine("\nPage {0}/{1}", page.ToString(), pages.ToString());

        //display user prompts
        Console.WriteLine("\n[n] Next [b] Back [q] quit \n[new] new tournament\n");

        selection = Console.ReadLine();

        //run NewTournament if "new" is entered
        if (selection == "new"){
          NewTournament.New();
        }

        //select a tournament with SelectTournament if the number by it is entered
        foreach (Tournament tournament in DisplayList){
          if (selection == (DisplayList.IndexOf(tournament) + 1 ).ToString()){
            SelectTournament.Select(tournament);
          }
        }
      }
    }
  }
}