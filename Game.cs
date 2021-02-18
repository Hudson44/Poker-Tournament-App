/****************************************
 * Authors: Jonathan H., Richard Z., and Anthony S.
 * Date Created: February 12, 2021
 * Data Last Modified: February 18, 2021
 * Project: Poker Tournament App
 * Filename: TournamentApp.cs
 * Instructor: Professor James Munger
 */

using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{

  class Game
  {
    int Id{get; set;}
    string WinningHand{get; set;}
    bool FinalRoundGame{get; set;}

    List<Player> players = new List<Player>();

    public Game()
    {
      Id = 404;
      WinningHand = "";
      FinalRoundGame = false;
    }

    //Initialize without players
    public Game(int inId, string inWinningHand, bool inFinalRoundGame)
    {
      Id = inId;
      WinningHand = inWinningHand;
      FinalRoundGame = inFinalRoundGame;
    }

    //Initialize with player(s)
    public Game(int inId, string inWinningHand, bool inFinalRoundGame, List<Player> inPlayers)
    {
      Id = inId;
      WinningHand = inWinningHand;
      FinalRoundGame = inFinalRoundGame;
      addPlayers(inPlayers);
    }

    public void addPlayers(List<Player> inPlayers)
    {
      players.AddRange(inPlayers);
    }

  }

}