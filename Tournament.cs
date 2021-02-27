/****************************************
 * Authors: Jonathan H., Richard Z., and Anthony S.
 * Date Created: February 12, 2021
 * Data Last Modified: February 18, 2021
 * Project: Poker Tournament App
 * Filename: TournamentApp.cs
 * Instructor: Professor James Munger
 */

using System;

namespace Poker_Tournament_App
{
  public class Tournament
  {
    public string Name{get; set;}
    public string Location{get; set;}
    public int MaxPlayers{get; set;}
    public string TournamentDate{get;set;}

    public Tournament()
    {
      Name = "";
      TournamentDate = "";
      Location = "";
      MaxPlayers = 0;
    }

    public Tournament(string inName, string inDate, string inLocation, int inMaxPlayers)
    {
      Name = inName;
      TournamentDate = inDate;
      Location = inLocation;
      MaxPlayers = inMaxPlayers;
    }

    public override string ToString()
    {
      string printString = ""; 
      printString += "\nName:\t\t" + Name;
      printString += "\nDate:\t\t" + TournamentDate;
      printString += "\nLocation:\t" + Location;
      printString += "\nMax Players:" + MaxPlayers;
      return printString;
    }

  }

}
