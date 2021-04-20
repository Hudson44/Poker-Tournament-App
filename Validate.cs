using System;
using System.Globalization;

namespace Poker_Tournament_App
{
  public class Validate
  {
    public static string ValidateDate(string stringDate, string errorMessage){
      DateTime date;

      while (true){
        if (DateTime.TryParseExact(stringDate, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date)){
          return date.ToString("dd/MM/yyyy");
        }
        else{
          Console.Clear();
          Console.WriteLine(errorMessage);
          stringDate = Console.ReadLine();
        }
      }
    }

    public static int ValidateInt(string stringNum, string errorMessage){
      int intiger;

      while (true){
        if (int.TryParse(stringNum, out intiger) && intiger > 0){
          return intiger;
        }
        else{
          Console.Clear();
          Console.WriteLine(errorMessage);
          stringNum = Console.ReadLine();
        }
      }
    }
  }
}