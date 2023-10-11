using System;
using System.Collections.Generic;
using System.Collections;

public class FakeCharacter{
  Random rand = new Random();
  private char[,] characters;
  private int size;
  List<Line> myList = new List<Line>();

  public void makePaths(int paths){
    for (int i=0; i<paths; i++){
      int xRand = rand.Next(paths);
      int yRand = rand.Next(paths);
      int rLength = rand.Next(paths);
      int rRand = rand.Next(2);
      if(rRand == 0){
        HorizontalLine newh = new HorizontalLine(xRand, yRand, rLength);
        myList.Add(newh);
      }else{
        VerticalLine vnew = new VerticalLine(xRand, yRand, rLength);
        myList.Add(vnew);
      }
      
    }  
  }
  public void addCircles(int numCircles){
    for (int i =0; i<numCircles; i++){
      int rRow = rand.Next(size);
      int rColumn = rand.Next(size);
      characters[rRow, rColumn ] = 'o';
    }
  }
  public FakeCharacter(int dsize, int numlines){
    size = dsize;
    characters = new char[size,size];
    makePaths(numlines);
    for(int i=0; i<size;i++){
      for(int j=0; j<size; j++){
        for(int k=0; k<myList.Count;k++){
          if(myList[k].onLine(i,j)){
            characters[i,j] = myList[k].getTheCharacter();
          }
        }
      }
    }
    addCircles(4);
  }
  public void printCharacter(){
    for(int i=0; i<size; i++){
      for(int j=0; j<size; j++){
        if (characters[i,j] == '\u0000'){
          Console.Write(" ");
        }else{
          Console.Write(characters[i,j]);
        }
      }
      Console.WriteLine();
    }
  }
}