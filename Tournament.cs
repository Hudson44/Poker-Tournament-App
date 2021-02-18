/****************************************
 * Authors: Jonathan H., Richard Z., and Anthony S.
 * Date Created: February 12, 2021
 * Data Last Modified: February 16, 2021
 * Project: Poker Tournament App
 * Filename: TournamentApp.cs
 * Instructor: Professor James Munger
 */

using System;

namespace Poker_Tournament_App
{
  class Tournament
  {
    string name;
    DateTime date;
    string location;
    int maxPlayers;

    public Tournament()
    {
      setName("");
      setDate(new DateTime(1900, 01, 01));
      setLocation("");
      setMaxPlayers(0);
    }

    public Tournament(string inName, DateTime inDate, string inLocation, int inMaxPlayers)
    {
      setName(inName);
      setDate(inDate);
      setLocation(inLocation);
      setMaxPlayers(inMaxPlayers);
    }

    public void setName(string inName)
    {
      name = inName;
    }

    public string getName()
    {
      return name;
    }

    public void setDate(DateTime inDate)
    {
      date = inDate.Date;
    }

    public DateTime getDate()
    {
      return date;
    }

    public void setLocation(string inLocation)
    {
      location = inLocation;
    }

    public string getLocation()
    {
      return location;
    }

    public void setMaxPlayers(int inMaxPlayers)
    {
      maxPlayers = inMaxPlayers;
    }

    public int getMaxPlayers()
    {
      return maxPlayers;
    }

  }

}
