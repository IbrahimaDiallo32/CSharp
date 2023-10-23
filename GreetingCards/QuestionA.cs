using System;
using System.Collections.Generic;

class Program {
  static List<GreetingCard> myList = new List<GreetingCard>();
  public static void Main (string[] args) {
    BirthdayCard bdc = new BirthdayCard("Happy Birthday", "It's your birthday!");
    GreetingCard gc = new ThankYouCard( "Thanks a bunch", "Thank you");
    //I just went ahead and re-initialize to these words becasuse the instructions did not say
    //anything about a default constructor in either parent or child class
    myList.Add(bdc);
    myList.Add(gc);
    Console.WriteLine(gc.getInnerText());
  }
}