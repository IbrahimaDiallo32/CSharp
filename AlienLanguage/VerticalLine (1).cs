using System;
using System.Collections.Generic;


public class VerticalLine : Line{
  public VerticalLine(int start_x, int start_y, int length) : base(start_x, start_y, length){
    theCharacter = '|';
  }
    public override bool onLine(int x, int y){
      if(start_y == y){
        if(x >= start_x && x<=start_x+length-1){
          return true;
        }
      }
    return false;
    }
}