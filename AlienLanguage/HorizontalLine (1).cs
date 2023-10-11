using System;
using System.Collections.Generic;


public class HorizontalLine : Line{
  public HorizontalLine(int start_x, int start_y, int length) : base (start_x, start_y, length){
  theCharacter = '-';
  }
  public override bool onLine(int x, int y){
      if(start_x == x){
        if(y >= start_y && y<=start_y+length-1){
          return true;
        }
      }
    return false;
    }
  }
