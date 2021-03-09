using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
    //displays information for a selected tournament
    public class SelectTournament
    {   
        public static void Select(Tournament tournament)
        {
            string selection = "";

            while (selection != "q"){
                Console.Clear();
                Console.WriteLine(tournament);

                Console.WriteLine("\n[q] quit [edit] edit tournament [r] register players");

                selection = Console.ReadLine();

                if (selection == "edit"){
                    EditTournament.Edit(tournament);
                }
                //TODO Finish registerplayer
                if (selection == "r"){
                    EditTournament.Edit(tournament);
                }
            }
        }
    }
}