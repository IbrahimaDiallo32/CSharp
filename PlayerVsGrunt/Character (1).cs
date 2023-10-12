using System;
using System.Collections.Generic;

abstract class Character{
  protected int currenthp;
  protected int starthp;
  protected bool alive;
  protected string charname;
  public Character(){
    alive = true;
  }
  public string getname(){
    return charname;
  }
  public void setname(string x){
    x = charname;
    
  }
  public void sethitpoints(int x, int y){
    x= starthp;
    y= currenthp;
  }
  public int health(){
    int percenthealth = currenthp;
    return percenthealth;
  }
  public void takeHit(int damage){
    Console.WriteLine(getname() + " has been hit with " + damage + " damage.");
    currenthp-=damage;
    if(currenthp<1){
      currenthp=0;
      Console.WriteLine(getname() + " has died");
      alive = false;
    }else{
      Console.WriteLine(getname() + " has health of " + currenthp + " now.");
    }
  }
  public bool isAlive(){
    if(alive == true){
      return true;
    }
    return false;
  }
  public virtual void displayYourself(){
    Console.Write(getname() + " Health: (" +currenthp + ") ");
    int counter=0;
    for(int i=0; i<9 ; i++){
      if(i<health()/10){
        Console.Write("=");
        counter++;
      }else{
        Console.Write("_");
      }
    }
    Console.WriteLine();
  }
  public abstract int attack();
}