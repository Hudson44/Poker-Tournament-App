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
      bool valid = false;
      int converted;
      List<string> prompts = new List<string>{"Name: ", "Date: ", "Location: ", "Max players: "};
      List<string> dataList = new List<string>();
      Tournament newTournament;
      DateTime date;
      Regex dateValidation = new Regex(@"^(?:(?:31(\/)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)\d{2})$|^(?:29(\/)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)\d{2})$");

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
          while (!valid){
            if (/*dateValidation.IsMatch(enteredData) && */DateTime.TryParseExact(enteredData, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date)){
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

        //makes sure player count is a non negative intiger
        if (prompts.IndexOf(prompt) == 3){
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
      
      List<List<string>>tableData = new List<List<string>>();
      List<string>row = new List<string>();

      //add header row
      row.Add("Tournament");
      row.Add("Date");
      tableData.Add(row);
      
      Console.Clear();
      //print header
      Console.WriteLine("Last five tournaments:");
      Program.PrintLine();
      Program.PrintRow(tableData[0]);

      //initialize lists
      row.Clear();
      for(int i = 0; i < 2; i++){
        row.Add("");
      }
      for(int i = 0; i < 5; i++){
        tableData.Add(row);
      }

      //print table body
      Program.PrintLine();
      for (int i = 0; i < 5; i++){
        tableData[i+1][0] = TournamentList.Tournaments[i].Name;
        //adds date with time removed
        tableData[i+1][1] = TournamentList.Tournaments[i].TournamentDate.Date.ToString().Substring(0,TournamentList.Tournaments[i].TournamentDate.Date.ToString().Length - 12);
        Program.PrintRow(tableData[i]);
      }
      Program.PrintLine();

      Console.ReadLine();
    }
  }
}