using System;

class Grunt : Character{
  public int gruntID;
  public static int nextGruntID=1;
  private int maxAttack=5;
  public Grunt(){
    gruntID= nextGruntID;
    nextGruntID++;
    string gruntName = "Grunt " + gruntID;
    charname = gruntName;
    currenthp=100;
    starthp=100;
  }
   Random myRand = new Random();
  public override int attack(){
    int x =myRand.Next(0, maxAttack+1);
    Console.WriteLine(charname + " attacks you inflicting " + x + " damage.");
    return x;
  }
}