using System;
using System.Collections.Generic;

public class WordJumble {
  Random myRand=new Random();
  private char[] vowels = new char[] {'a','e','i','o','u'};
  private char[] consonants= new char[] {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
  
  private char[] letterArray=new char[16];

  private List<string> guessedWords = new List<string>();
  private int score=0;

  char[] pickLetters() {
    char[] retLetters=new char[16];
    for(int i=0;i<4;i++) {
      char randVowel=vowels[myRand.Next(5)];
      retLetters[i]=randVowel; 
    }
    for(int i=4;i<16;i++) {
      char randVowel=consonants[myRand.Next(21)];
      retLetters[i]=randVowel; 
    }
    return retLetters;
  }

  public WordJumble() {
    letterArray=pickLetters();
  }

  public WordJumble(string letters,List<string> guesses) {
    string[] charString=letters.Split(" ",16);
    for(int i=0;i<16;i++) {
      letterArray[i]=(charString[i])[0];
    }
    foreach(string word in guesses) {
      scoreWord(word.Length);
      guessedWords.Add(word);
    }
  }

  public override string ToString() {
    return getLetters();
  }

  public string getLetters() {
    string retString="";
    for(int i=0;i<16;i++) {
      retString+=letterArray[i]+" ";
    }
    return retString;
  }

  public bool hasLetters(string word) {
    List<int> usedIndex = new List<int>();
    
    char[] letters=word.ToCharArray();
    foreach(char nextLetter in letters) {
      bool foundLetter=false;
      for(int i=0;i<letterArray.Length;i++) {
        if((letterArray[i]==nextLetter) && (! usedIndex.Contains(i))) {
          usedIndex.Add(i);
          foundLetter=true;
          break;
        }
      }
      if(foundLetter==false) {
        Console.WriteLine("You don't have enough "+nextLetter+"'s to use.");
        return false;
      }
    }
    return true;
  }

  public int scoreWord(int size) {
    int wordScore=0;
    if(size<3) {
      wordScore=0;
    }
    else if(size<=4) {
      wordScore=1;
    }
    else if(size==5) {
      wordScore=2;
    }
    else if(size==6) {
      wordScore=3;
    }
    else if(size==7) {
      wordScore=5;
    }
    else {
      wordScore=11;
    }
    score+=wordScore;
    return wordScore;
  }

  public void saveGuess(string guess) {
    guessedWords.Add(guess);
  }

  public bool alreadyGuessed(string guess) {
    return guessedWords.Contains(guess);
  }

  public string getGuessedWordsAsString() {
    string ret="";
    foreach(string x in guessedWords) {
      ret+=x+" ";
    }
    return ret;
  }

  public List<string> getGuessedWords() {
    return guessedWords; 
  }

  public int getScore() {
    return score;
  }
}