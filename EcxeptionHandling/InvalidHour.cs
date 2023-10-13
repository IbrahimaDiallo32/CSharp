using System;

class InvalidHour : Exception{
public InvalidHour(){
  
}
public InvalidHour(string x) : base (x){

}
}