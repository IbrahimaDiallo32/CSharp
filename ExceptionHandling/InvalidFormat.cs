using System;

class InvalidFormat : Exception{
  public InvalidFormat(){
    
  }
  public InvalidFormat(string x) : base(x){
    
  }
}
