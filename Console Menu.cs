using System;

class Mainclass {
    public static void Main (string[] args) {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Tournaments");
        Console.WriteLine("2) Players");
        Console.WriteLine("3) Overall Stats");
        Console.WriteLine("4) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                Tournaments();
                return true;
            case "2":
                Players();
                return true;
            case "3":
                OverallStats();
                return true;
            case "4":
                return false;
            default:
                return true;
        }

    }
}