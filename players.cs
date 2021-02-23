using System;
using System.IO;
using System.Collections.Generic;
namespace players{
  public class Player {
    public string Name {get;set;}
    public string LeagueNumber {get;set;}
    public string DateJoined {get;set;}
    public string Birthday {get;set;}
    public string Hometown {get;set;}
    public string State {get;set;}
    public string HighCard {get;set;}
    public string Pair {get;set;}
    public string TwoPair {get;set;}
    public string ThreeOfAKind {get;set;}
    public string Straight {get;set;}
    public string Flush {get;set;}
    public string FullHouse {get;set;}
    public string FourOfAKind {get;set;}
    public string StraightFlush {get;set;}
    public string RoyalFlush {get;set;}
    public Player(string name, string leaguenumber, string datejoined, string birthday, string hometown, string state, string highcard, string pair, string twopair, string threeofakind, string straight, string flush, string fullhouse, string fourofakind, string straightflush, string royalflush){
      Name = name;
      LeagueNumber = leaguenumber;
      DateJoined = datejoined;
      Birthday = birthday;
      Hometown = hometown;
      State = state;
      HighCard = highcard;
      Pair = pair;
      TwoPair = twopair;
      ThreeOfAKind = threeofakind;
      Straight = straight;
      Flush = flush;
      FullHouse = fullhouse;
      FourOfAKind = fourofakind;
      StraightFlush = straightflush;
      RoyalFlush = royalflush;
    }
    public override string ToString(){
      string output = "";
      output += ($"Name : {Name}\n");
      output += ($"LeagueNumber : {LeagueNumber}\n");
      output += ($"DateJoined : {DateJoined}\n");
      output += ($"Birthday : {Birthday}\n");
      output += ($"Hometown : {Hometown}\n");
      output += ($"State : {State}\n");
      output += ($"HighCard : {HighCard}\n");
      output += ($"Pair : {Pair}\n");
      output += ($"TwoPair : {TwoPair}\n");
      output += ($"ThreeOfAKind : {ThreeOfAKind}\n");
      output += ($"Straight : {Straight}\n");
      output += ($"Flush : {Flush}\n");
      output += ($"FullHouse : {FullHouse}\n");
      output += ($"FourOfAKind : {FourOfAKind}\n");
      output += ($"StraightFlush : {StraightFlush}\n");
      output += ($"RoyalFlush : {RoyalFlush}\n");
      return output;   
    }
  }
}