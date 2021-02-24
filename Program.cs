using System;

namespace Poker_Tournament_App
{
    class Program
    {
        public static void Main (string[] args) {
        string selection;

        Console.WriteLine("Select an option:\n ");
        Console.WriteLine("1: Tournaments");
        Console.WriteLine("2: Players");
        Console.WriteLine("3: Overall Stats");
        Console.WriteLine("4: Save & Quit");
        selection = Console.ReadLine();
        
        if (selection == "1")
        {
            GetTournamentData.GetData();
        }
        else if(selection == "2")
        {
            Console.WriteLine("Players.");
        }
        else if(selection == "3")
        {
            Console.WriteLine("Overall Stats.");
        }
        else if(selection == "4")
        {
            Console.WriteLine("Byeeeeeeeeeeeeeee");
        }
    }
    }
}
