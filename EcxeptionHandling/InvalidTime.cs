using System;

class InvalidTime : Exception{
  public InvalidTime() {
    
  } 
  public InvalidTime(string x) : base(x){

    }
}