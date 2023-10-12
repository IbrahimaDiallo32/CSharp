using System; 

class Player : Character{
  public Player(){
    charname = "Player 1";
    starthp=100;
    currenthp=100;
    
  }
  Random myRand = new Random();
  public override int attack(){
    int rand = myRand.Next(0, 31);
    return rand;
  }
  public override void displayYourself(){
    Console.WriteLine("Player 1 has health of "+ currenthp);
  }
}