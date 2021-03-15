using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
  public static class PlayerList
  {
    public static List<Player> Players = new List<Player>();

    public static void View()
    {
        string selection = "";
        int displayed = 0;
        int displayAmount = 10;

        GetPlayerData.GetData();
        
        while (!(selection == "q"))
        {
            Console.Clear();
            Console.WriteLine("Select a player by Id:\n");

            //Allow using "next" if not at the end of the list of players
            if (displayed < Players.Count - displayAmount)
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
                    Console.WriteLine(Players[i].Id + "\t" + Players[i].Name);
                }
            }
            catch
            {
                //Maybe notify user of end of list?
            }

            int playerIndex = -1;

            Console.WriteLine("\n[n] Next [b] Back [q] quit\n");

            selection = Console.ReadLine();

            //Select a player with SelectPlayer if its Id is entered

            playerIndex = Players.FindIndex(thisPlayer => thisPlayer.Id.ToString() == selection);

            if(playerIndex != -1)
            {
                Player.Select(Players[playerIndex]);
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