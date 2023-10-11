using System;
using System.Collections.Generic;


public abstract class Line{
  protected int start_x;
  protected int start_y;
  protected int length;
  protected char theCharacter;
  public Line(int x, int y, int l){
    start_x = x;
    start_y =y;
    length=l;
  }
  public char getTheCharacter(){
    return theCharacter;
  }
  public abstract bool onLine(int x, int y);
}