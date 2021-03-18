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
    public string TournamentID{get;set;}
    public string WinningHand{get;set;}
    public string FirstPlace{get;set;}
    public string SecondPlace{get;set;}
    public string ThirdPlace{get;set;}
    public string FourthPlace{get;set;}

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

  }

}
