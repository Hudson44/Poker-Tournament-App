/****************************************
 * Authors: Jonathan H., Richard Z., and Anthony S.
 * Date Created: February 12, 2021
 * Data Last Modified: February 16, 2021
 * Project: Poker Tournament App
 * Filename: TournamentApp.cs
 * Instructor: Professor James Munger
 */

using System;
using System.Collections.Generic;

public class Game
{
  int id;
  string winningHand;
  bool finalRoundGame;

  List<Player> players = new List<Player>();

  public Game()
  {
    setId(404);
    setWinningHand("");
    setFinalRoundGame(false);
  }

  //Initialize without players
  public Game(int inId, string inWinningHand, bool inFinalRoundGame)
  {
    setName(inId);
    setDate(inWinningHand);
    setLocation(inFinalRoundGame);
  }

  //Initialize with player(s)
  public Game(int inId, string inWinningHand, bool inFinalRoundGame, List<Player> inPlayers)
  {
    setName(inId);
    setDate(inWinningHand);
    setLocation(inFinalRoundGame);
    addPlayers(inPlayers);
  }

  public void setId(int inId)
  {
    id = inId;
  }

  public int getId()
  {
    return id;
  }

  public void setWinningHand(string inWinningHand)
  {
    winningHand = inWinningHand;
  }

  public string getWinningHand()
  {
    return winningHand;
  }

  public void setFinalRoundGame(bool inFinalRoundGame)
  {
    finalRoundGame = inFinalRoundGame;
  }

  public string getFinalRoundGame()
  {
    return finalRoundGame;
  }

  public void addPlayers(List<Player> inPlayers)
  {
    players.add(inPlayers);
  }

}