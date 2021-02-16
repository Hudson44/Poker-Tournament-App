using System;

class MainClass {
    public static void Main (string[] args) {
        string selection;

        Console.WriteLine("Select an option:\n ");
        Console.WriteLine("1: Tournaments");
        Console.WriteLine("2: Players");
        Console.WriteLine("3: Overall Stats");
        selection = Console.ReadLine();
        
        if (selection == "1")
        {
            Console.WriteLine("Tournaments.")
        }
        else if(selection == "2")
        {
            Console.WriteLine("Players.")
        }
        else if(selection == "3")
        {
            Console.WriteLine("Overall Stats.")
        }
    }
}