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
    public class Tournament
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int MaxPlayers { get; set; }
        public string TournamentDate { get; set; }
        public string TournamentID { get; set; }
        public int MaxRegistrants { get; set; }

        public List<Player> Registrants = new List<Player>();


        public Tournament()
        {
            Name = "";
            TournamentDate = "";
            Location = "";
            MaxPlayers = 0;
            TournamentID = "";
            
        }

        public Tournament(string inName, string inDate, string inLocation, int inMaxPlayers, string inTournamentID)
        {
            Name = inName;
            TournamentDate = inDate;
            Location = inLocation;
            MaxPlayers = inMaxPlayers;
            TournamentID = inTournamentID;
        }

        public override string ToString()
        {
            string printString = "";
            printString += "\nName:\t\t" + Name;
            printString += "\nDate:\t\t" + TournamentDate;
            printString += "\nLocation:\t" + Location;
            printString += "\nMax Players:\t" + MaxPlayers;
            return printString;
        }
        public int RegisterPlayer(Player player)
        {
            Registrants.Add(player);

            return player.RankChips;



        }

    }

}
