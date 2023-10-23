using System;
using System.Collections.Generic;

public class GreetingCard{
  private string innerText;
  private string frontText;
  private int id;
  private int nextId=1001;

  public GreetingCard(string i, string f){
    i = innerText;
    f = frontText;
    id = nextId;
    nextId++;
  }
  public string getInnerText(){
    return innerText;
  }
}