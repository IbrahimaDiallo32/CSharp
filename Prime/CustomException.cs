using System;

class CustomException : Exception{
  public CustomException(){
    
  }
  public CustomException(string x): base(x){
    
  }
}