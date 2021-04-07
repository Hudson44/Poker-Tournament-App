using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

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
          NewTournament();
        }

        //select a tournament with SelectTournament if the number by it is entered
        foreach (Tournament tournament in DisplayList){
          if (selection == (DisplayList.IndexOf(tournament) + 1 ).ToString()){
            Tournament.SelectTournament(tournament);
          }
        }
      }
    }

    public static void NewTournament()
    {
      string enteredData;
      string errorMessage;
      List<string> prompts = new List<string>{"Name: ", "Date: ", "Location: ", "Max players: "};
      List<string> dataList = new List<string>();
      Tournament newTournament;
      
      
      //clear list of entered data
      dataList.Clear();

      //make the new tournament ID one higher than the last tournaments ID
      int ID = Int32.Parse(Tournaments[Tournaments.Count - 1].TournamentID) + 1;
      dataList.Add(ID.ToString());
      
      //collect user input
      foreach (string prompt in prompts){
        Console.Clear();
        Console.WriteLine("Enter tournament data:");
        Console.WriteLine("\n" + prompt);
        enteredData = Console.ReadLine();

        //verifies date
        if (prompts.IndexOf(prompt) == 1){
          errorMessage = "Enter tournament data: \n\nError: invalid input \n\n" + prompt;
          enteredData = Program.VerifyDate(enteredData, errorMessage);
        }

        //makes sure player count is a non negative intiger
        if (prompts.IndexOf(prompt) == 3){
          errorMessage = "Enter tournament data: \n\nError: invalid input \n\n" + prompt;
          
          enteredData = Program.VerifyInt(enteredData, errorMessage).ToString();
        }

        dataList.Add(enteredData);
      }
      
      //create new tournament with user data
      newTournament = new Tournament(dataList[0], dataList[1], DateTime.ParseExact(dataList[2], "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture), dataList[3], Int32.Parse(dataList[4]), "", "", "", "", "");
      TournamentList.Tournaments.Add(newTournament);

      Console.Clear();
      Console.WriteLine("New tournament created:");
      Console.WriteLine(newTournament);
      
      Console.ReadLine();
    }

    public static void LastTournaments(){
      //sort tournaments by descending date
      TournamentList.Tournaments.Sort((x, y) => y.TournamentDate.CompareTo(x.TournamentDate));

      //add header row
      DisplayTable.row.Add("Tournament");
      DisplayTable.row.Add("Date");
      DisplayTable.tableData.Add(DisplayTable.row);
      
      Console.Clear();
      //print header
      Console.WriteLine("Last five tournaments:");
      DisplayTable.PrintLine();
      DisplayTable.PrintRow(DisplayTable.tableData[0]);

      //initialize lists
      DisplayTable.row.Clear();
      for(int i = 0; i < 2; i++){
        DisplayTable.row.Add("");
      }
      for(int i = 0; i < 5; i++){
        DisplayTable.tableData.Add(DisplayTable.row);
      }

      //print table body
      DisplayTable.PrintLine();
      for (int i = 0; i < 5; i++){
        DisplayTable.tableData[i+1][0] = TournamentList.Tournaments[i].Name;
        //adds date with time removed
        DisplayTable.tableData[i+1][1] = TournamentList.Tournaments[i].TournamentDate.Date.ToString().Substring(0,TournamentList.Tournaments[i].TournamentDate.Date.ToString().Length - 12);
        DisplayTable.PrintRow(DisplayTable.tableData[i]);
      }
      DisplayTable.PrintLine();
      DisplayTable.Clear();

      Console.ReadLine();
    }
  }
}