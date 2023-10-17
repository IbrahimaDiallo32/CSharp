using System;
using System.IO;
using System.Collections.Generic;

class Program {
  
  public static bool checkWord(string x){
    //int lines = File.ReadAllLines("2of12inf.txt").Length;
    StreamReader stream = new StreamReader("2of12inf.txt");
    while(!stream.EndOfStream){
      string line = stream.ReadLine();
      if(line == x){
        return true;
        
      }
    }
    return false;
  }
  public static void saveGame(List<string> x, string temp){
    try{
    Console.WriteLine("Name your session");
      string my = Console.ReadLine();
      string myfile = @my;
    //string user = Console.ReadLine();
    //FileStream fs = File.Create(myfile);
    //StreamReader obj = new StreamReader(user);
    int counter = x.Count;
      using(StreamWriter sw = File.AppendText(myfile)){
        Console.WriteLine("progeeee");
        sw.WriteLine(temp);
        for(int i=0; i<counter; i++){
          sw.WriteLine(x[i]);
        }
      }
      //Console.WriteLine("proge");
      //fs.Close();
      //sw.Close();
    }
    catch(Exception){
      Console.WriteLine("Unable to save state");
    }
  }
  public static WordJumble restoreGame(){
    Console.WriteLine("What Game do you want to restore?");
    string filename = Console.ReadLine();
    List<string> guessedWords = new List<string>();
    StreamReader stream = new StreamReader(filename);
    int counter =0;
    string letters ="";
    try{
    while(!stream.EndOfStream){
      if(counter ==0){
        string line = stream.ReadLine();
        letters = stream.ReadLine();
        //Console.WriteLine(letters);
      }
      else{
        guessedWords.Add(stream.ReadLine());
      }
      counter++;
      letters = stream.ReadLine();
    }
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
    }
    //if doesnt work line 54 or line 45.
    WordJumble newobj = new WordJumble(letters, guessedWords);
    return newobj;
    
    
  }
    
    
    
    /*while(!obj.EndOfStream){
    counter++;
  }
    for(int i=0; i<counter; i++){
      fs.Append(x[i]);
    }
    */
  
  public static void playGame(WordJumble temp){
    
    string guess = "";
    do {
      int counter=0;
      Console.WriteLine("Letters: " + temp.getLetters());
      Console.WriteLine("Found Words: " + temp.getGuessedWordsAsString());
      Console.WriteLine("Current Score: " + temp.getScore());
      Console.WriteLine("Enter a word using those letters or QUIT to stop, SAVE to saveprogress");
      Console.WriteLine("Enter a word to guess: ");
    guess = Console.ReadLine().ToLower();
      if(guess == "save"){
        saveGame(temp.getGuessedWords(), temp.getLetters());
        break;
      }
       int userLength = guess.Length;
      if(!temp.hasLetters(guess)){
      Console.WriteLine("You used letters you don’t have");
    }else{
      counter++;
    }
    if(!checkWord(guess)){
      Console.WriteLine("Not a valid word");
    }else{
      counter++;
    }
    if(temp.alreadyGuessed(guess)){
      Console.WriteLine("Already Guessed");
    }else{
      counter++;
    }
    if(counter ==3){
      int userScore = temp.scoreWord(userLength);
      temp.saveGuess(guess);
      Console.WriteLine("Valid Word. You scored " + userScore);
    }
    }while (guess != "quit");

  }
  
  public static void Main (string[] args) {
    
    WordJumble wjobject = new WordJumble();
    playGame(wjobject);

    try{
    string choice ="";
      Console.WriteLine("Type NEW for a new game, or CONTINUE to restore an old game?");
      choice = Console.ReadLine().ToLower();
    WordJumble secondobj = new WordJumble();
      WordJumble idkobj = new WordJumble();
      if(choice == "new"){
    playGame(secondobj);
      }else if(choice == "continue"){
        WordJumble obj= new WordJumble();
        Console.WriteLine("This worls");
        idkobj = restoreGame();
        Console.WriteLine("THis realty");
        playGame(idkobj);
      }else{
        Console.WriteLine("Invalid choice");
      }
  }
    catch(Exception e){
      Console.WriteLine(e.Message);
    }
  
}
}