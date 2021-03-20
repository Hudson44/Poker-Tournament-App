using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App{
  public static class PlayerList {
  public static List<Player> Players = new List<Player>();
   
  public static void ViewPlayers()
  {
    string selection = "";
    int displayed = 0;
    int displayAmount = 10;

    GetPlayerData.GetData();
      
      while (!(selection == "q"))
      {
        Console.Clear();
        Console.WriteLine("Select a player by name:\n");

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

        //Prevent errors when the end of the list is reached
        try
        {
          //Print information for players in display range
          foreach (int i in Enumerable.Range(displayed, displayAmount))
          {
            Console.WriteLine(PlayerList.Players[i].Name);
          }
        }
        catch
        {
          //Maybe notify user of end of list?
        }

        int playerIndex = -1;

        Console.WriteLine("\n[n] Next [b] Back [q] quit\n");

        selection = Console.ReadLine();

        //Select a player with SelectPlayer if its Name is entered

        playerIndex = PlayerList.Players.FindIndex(thisPlayer => thisPlayer.Name == selection);

        if(playerIndex != -1)
        {
          Player.SelectPlayer(PlayerList.Players[playerIndex]);
        }
        else
        {
          if(selection != "n" && selection != "b" && selection !="q")
          {
            Console.WriteLine("Invald Player");
          }
        }
      }
    }
  }
}
