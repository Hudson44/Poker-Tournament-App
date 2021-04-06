using System;
using System.Collections.Generic;

namespace Poker_Tournament_App
{
  public class DisplayTable
  {
    public static List<List<string>> tableData = new List<List<string>>();
    public static List<string> row = new List<string>();
    static int tableWidth = 73;
    public static void PrintLine()
    {
      Console.WriteLine(new string('-', tableWidth));
    }

    public static void PrintRow(List<string> columns)
    {
      int width = (tableWidth - columns.Count) / columns.Count;
      string row = "|";

      foreach (string column in columns)
      {
        row += AlignCentre(column, width) + "|";
      }

      Console.WriteLine(row);
    }

    public static string AlignCentre(string text, int width)
    {
      text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

      if (string.IsNullOrEmpty(text))
      {
        return new string(' ', width);
      }
      else
      {
        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
      }
    }

    public static void Clear(){
      tableData.Clear();
      row.Clear();
    }
  }
}