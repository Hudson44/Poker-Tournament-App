using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Globalization;

namespace Poker_Tournament_App{
  public static class PlayerList {
  public static List<Player> Players = new List<Player>();
   
  public static void ViewPlayers()
  {
    
    string selection = "";
    int displayed = 0;
    int displayAmount = 10;
    double pages;
    int page;

    //sorts players by ascending league number
    PlayerList.Players.Sort((x, y) => x.LeagueNumber.CompareTo(y.LeagueNumber));
    
      
      while (!(selection == "q"))
      {
        Console.Clear();
        Console.WriteLine("Select a player by league number:\n");

        //Allow using "next" if not at the end of the list of players
        if (displayed < PlayerList.Players.Count - displayAmount)
          {
          if (selection == "n")
          {
            displayed += displayAmount;
          }
        }

        //allow using "back" if not at the beginning of the list of players
        if (displayed >= displayAmount)
        {
          if (selection == "b")
          {
            displayed -= displayAmount;
          }
        }

        //gets total pages and current page
        pages = Math.Ceiling(Convert.ToDouble(PlayerList.Players.Count)/displayAmount);
        page = displayed/displayAmount + 1;

        //Prevent errors when the end of the list is reached
        try
        {
          //Print information for players in display range
          foreach (int i in Enumerable.Range(displayed, displayAmount))
          {
            Console.WriteLine(PlayerList.Players[i].LeagueNumber + " " + PlayerList.Players[i].Name);
          }
        }
        catch
        {
          //Maybe notify user of end of list?
        }

        int playerIndex = -1;

        //displays page information
        Console.WriteLine("\nPage {0}/{1}", page.ToString(), pages.ToString());

        Console.WriteLine("\n[n] Next [b] Back [q] quit\n[new] new player");

        selection = Console.ReadLine();

        if (selection == "new"){
          NewPlayer();
        }

        //Select a player with SelectPlayer if their league number is entered

        playerIndex = PlayerList.Players.FindIndex(thisPlayer => thisPlayer.LeagueNumber == selection);

        if(playerIndex != -1)
        {
          Player.SelectPlayer(PlayerList.Players[playerIndex]);
        }
        else
        {
          if(selection != "n" && selection != "b" && selection !="q" && selection != "new")
          {
            Console.WriteLine("Invalid Player");
          }
        }
      }
    }

    public static void NewPlayer()
    {
      string enteredData;
      List<string> prompts = new List<string>{"Name: ", "League number: ", "Date joined: ", "Birthday: ", "Hometown: ", "Rank chips: "};
      List<string> dataList = new List<string>();
      Player newPlayer;
      string errorMessage;

      //clear list of entered data
      dataList.Clear();
      
      //collect user input
      foreach (string prompt in prompts){
        Console.Clear();
        Console.WriteLine("Enter player data:");
        Console.WriteLine("\n" + prompt);
        enteredData = Console.ReadLine();

        //makes sure player counts and IDs are non negative intigers
        if (prompts.IndexOf(prompt) == 1 || prompts.IndexOf(prompt) == 5){
          errorMessage = "Enter player data: \n\nError: invalid input \n\n" + prompt;
          
          enteredData = Program.VerifyInt(enteredData, errorMessage).ToString();
        }

        dataList.Add(enteredData);
      }
      
      //create new tournament with user data
      newPlayer = new Player(dataList[0], dataList[1], DateTime.Parse(dataList[2],CultureInfo.InvariantCulture), dataList[3], dataList[4], Int32.Parse(dataList[5]));
      PlayerList.Players.Add(newPlayer);

      Console.Clear();
      Console.WriteLine("New player created:");
      Console.WriteLine(newPlayer);
      
      Console.ReadLine();
    }

    public static void TopTen(){
      //sort players by descending rank chips
      PlayerList.Players.Sort((x, y) => y.RankChips.CompareTo(x.RankChips));
      
      List<List<string>>tableData = new List<List<string>>();
      List<string>row = new List<string>();

      //add header row
      row.Add("Player");
      row.Add("Rank Chips");
      tableData.Add(row);
      
      Console.Clear();
      //print header
      Console.WriteLine("Top ten players:");
      DisplayTable.PrintLine();
      DisplayTable.PrintRow(tableData[0]);

      //initialize lists
      row.Clear();
      for(int i = 0; i < 2; i++){
        row.Add("");
      }
      for(int i = 0; i < 10; i++){
        tableData.Add(row);
      }

      //print table body
      DisplayTable.PrintLine();
      for (int i = 0; i < 10; i++){
        tableData[i+1][0] = PlayerList.Players[i].Name;
        tableData[i+1][1] = PlayerList.Players[i].RankChips.ToString();
        DisplayTable.PrintRow(tableData[i]);
      }
      DisplayTable.PrintLine();

      Console.ReadLine();
    }
  }
}