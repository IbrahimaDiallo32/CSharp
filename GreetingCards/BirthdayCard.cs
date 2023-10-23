using System;

public class BirthdayCard : GreetingCard, IPlayable{
  
  string innerText = "Happy Birthday";
  string frontText = "It's your birthday!";

  public BirthdayCard(string i, string f) : base(i, f){
    i = innerText;
    f = frontText;
    
  }
  public void playMusic(){
    Console.WriteLine("Happy birthday to you");
  }
}