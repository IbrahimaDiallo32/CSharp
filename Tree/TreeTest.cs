using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Tree myTree = new Tree(0);
  List<double> mylist12 = new List<double>();

  for (int i=1; i<=20; i++){
    Console.WriteLine("Year: "+i);
    double tempin=myTree.inchesRain(mylist12);
    double tempmm= myTree.inchesToMM(tempin);
    Console.WriteLine("Rain this year: " + tempin+ " inches or "+ tempmm + "mm.");
    myTree.grow(tempmm);
    myTree.drawMe();
    myTree.fire(myTree, mylist12);
  }
  }
}