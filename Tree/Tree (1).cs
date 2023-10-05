using System;
using System.Collections.Generic;
class Tree{
  private int height;
  private char myChar;
  public Tree(int newheight){
    if (newheight < 0){
      newheight = 0;
        }else{
        height = newheight;
        }
        myChar = 'V';
    }
  public void setmyChar(char newmyChar){
    myChar = newmyChar;
    }
  public void grow(double rain){
    if (rain >= 12){
      height += 1;
      Console.WriteLine("We are growing!");
      }
    }
  public void drawMe(){
    for(int i=1; i<=height;i++){
      for(int j=0;j<(height -i)/2;j++){
        Console.Write(" ");
      }
      for(int j=0;j<i;j++){
        Console.Write(myChar);
      }
      Console.WriteLine();
    }
   
    /*int height = 5;
    for (int i = 1; i <= height; i++){
      int temp = (height - i)/ 2;
      string spaces = new string(' ', temp);
        if (i == height){
          Console.Write(myChar);
          }else{
          Console.Write(spaces + myChar);
          }
      }*/
    }
    public double inchesToMM(double inches){
      double millimeters = inches * 25.4;
      return millimeters;
    }
    public double last3YearInInches(List<double> templist){
      if(templist.Count <3){
        return 100;
      }else{
      double avg =(templist[templist.Count-1]+templist[templist.Count-2]+templist[templist.Count-3])/3;
      return avg;
      }
    }
  public void fire(Tree tempobj, List<double> newlist){
    double average= last3YearInInches(newlist);
    if (average <0.5){
      Console.WriteLine("Oh no we had a fire!");
      tempobj.setmyChar('|');
    }else{
      tempobj.setmyChar('V');
    }
  }
  public double inchesRain(List<double> templist){
    Random rand=new Random();
    double myrand= rand.NextDouble()*2;
    //Random.nextDouble()*2
    templist.Add(myrand);
    return myrand;
  }
}