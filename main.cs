using System;
using System.IO;
using System.Collections.Generic;
namespace players{
  class MainClass {
    static void Main(string[] args){
      Player newPlayer;
      using(StreamReader reader = new StreamReader(@"Poker League Sample Data - Players.csv")){
        while (!reader.EndOfStream){
          
          string line = reader.ReadLine();
          string[] values = line.Split(',');
          newPlayer = new Player(values[0],values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11],values[12], values[13], values[14], values[15]);
          
          PlayerList.Players.Add(newPlayer);
          }
        }
        foreach (Player player in PlayerList.Players){
          Console.WriteLine(player);
        }
      }
    }
  }
