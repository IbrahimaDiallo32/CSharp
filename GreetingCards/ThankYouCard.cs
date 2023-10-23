using System;

public class ThankYouCard : GreetingCard{
  string innerText = "Thanks a bunch";
  string frontText = "Thank you";

  
  public ThankYouCard(string i, string f) : base(i, f){
    i = innerText;
    f = frontText;
    
  }
}