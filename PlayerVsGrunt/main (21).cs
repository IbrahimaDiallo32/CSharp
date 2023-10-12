using System;

class Program {
  public static void Main (string[] args) {
    Game myGame=new Game();
while((!myGame.win()) && (!myGame.lose())) {
myGame.playRound();
Console.WriteLine();
}
  }
}