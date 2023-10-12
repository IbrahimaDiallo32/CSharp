using System;
using System.Collections.Generic;

class Game{
  private List<Character> badGuy = new List<Character>();
  Character p1 = new Player();
  Random myRand = new Random();
  int numGrunts;
  public Game(){
    int rand = myRand.Next(1,3);
    numGrunts=rand;
    Console.WriteLine("You'll be facing " + rand + " grunts.");
    for(int i=0; i<rand; i++){
      Character grunt = new Grunt();
      badGuy.Add(grunt);
    }
    Character boss = new Boss();
    badGuy.Add(boss);
    Character p1 = new Player();
  }
  public bool lose(){
    if(!p1.isAlive()){
      return true;
    }
    return false;
  }
  //I originally had a counter if they were dead it would add one then
  //I compared that to (numGrunts+1) and it didnt work it, never ended the game but it did when it was just (numGrunt) very strange.
  public bool win(){
    for(int i=0; i<(numGrunts+1);i++){
      if(badGuy[i].isAlive()==true){ 
      return false;
    }
    }
    return true;
  }
  public int chooseWhoToAttack(){
    Console.WriteLine("Who would you like to attack");
    for(int i=0; i<(numGrunts+1); i++){
      if(badGuy[i].health() >0){
        Console.WriteLine(i + ". " + badGuy[i].getname() );
      }
    }
    int choice = Convert.ToInt32(Console.ReadLine());
    return choice;
  }
  public void playRound(){
    p1.displayYourself();
    for(int i=0; i<(numGrunts+1); i++){
      if(badGuy[i].isAlive()){
      badGuy[i].displayYourself();
      int x =badGuy[i].attack();
      p1.takeHit(x);
    }
    }
      if(p1.isAlive()){
        int z= chooseWhoToAttack();
        int y= p1.attack();
        badGuy[z].takeHit(y);
      
    }
  }
}