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
  class Tournament
  {
    public string Name{get; set;}
    public string Location{get; set;}
    public int MaxPlayers{get; set;}

    DateTime _tournamentDate;

    public DateTime TournamentDate
    {
        get
        {
            return this._tournamentDate;
        }
        set
        {
            this._tournamentDate = value.Date;
        }
    }

    public Tournament()
    {
      Name = "";
      TournamentDate = new DateTime(1900, 01, 01);
      Location = "";
      MaxPlayers = 0;
    }

    public Tournament(string inName, DateTime inDate, string inLocation, int inMaxPlayers)
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
      printString += "\nDate:\t\t" + TournamentDate.ToString("d");
      printString += "\nLocation:\t" + Location;
      printString += "\nMax Players:" + MaxPlayers;
      return printString;
    }

  }

}
