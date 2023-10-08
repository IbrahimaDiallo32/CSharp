using System;
using System.Collections.Generic;

abstract class Item{
  private string title;
  public Item(){
    title= "";
  }
  public string getTitle(){
    return title;
  }
  public void setTitle(string x){
    title = x;
  }
  public override string ToString(){
    return title;
  }
  public abstract void getListing();
 
}