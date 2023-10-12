using System;

class Boss : Character{
  private int maxAttack=10;
  public Boss(){
    charname = "The Boss";
    currenthp=200;
    starthp=200;
  }
  Random myRand = new Random();
  public override int attack(){
    int x =myRand.Next(0, maxAttack+1);
    Console.WriteLine("The Boss mega attacks you inflicting " + x + " damage.");
    return x;
  }
}