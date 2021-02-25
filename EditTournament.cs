using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker_Tournament_App
{
    public class EditTournament
    {   
        public static void Edit()
        {
            string selectedID = "";
            string toEdit = "";

            while (selectedID != "q"){
                Console.Clear();
                Console.WriteLine("Enter Id of tournament to edit:");
                selectedID = Console.ReadLine();

                foreach (Tournament tournament in TournamentList.Tournaments){
                    if (selectedID == tournament.TournamentID){
                        
                        while (toEdit != "q"){
                            Console.Clear();
                            Console.WriteLine("What to edit:");
                            Console.WriteLine("\n1. Name \n2. Date \n3. Location \n4. Max players");
                            toEdit = Console.ReadLine();

                            if (toEdit == "1"){
                                Console.WriteLine("\nEnter new name:");
                                tournament.Name = Console.ReadLine();
                            }
                            else if (toEdit == "2"){
                                Console.WriteLine("\nEnter new date:");
                                tournament.TournamentDate = Console.ReadLine();
                            }
                            else if (toEdit == "3"){
                                Console.WriteLine("\nEnter new location:");
                                tournament.Location = Console.ReadLine();
                            }
                            else if (toEdit == "4"){
                                Console.WriteLine("\nEnter new max player amount:");
                                tournament.MaxPlayers = Int32.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("\n[q] quit");
                        }
                    }
                }             

                Console.WriteLine("\n[q] quit");    
            }
        }
    }
}