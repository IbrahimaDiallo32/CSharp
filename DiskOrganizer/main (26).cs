using System;
using System.Collections.Generic;

class Program {
  //static LinkedList <BlueRayDisk> list = new LinkedList<BlueRayDisk>();

  public static void Main (string[] args) {
    string temp = "hello";
    Console.WriteLine(temp[0]);
    BlueRayCollection myBrc = new BlueRayCollection();
    int choice =0;
    do{
      Console.WriteLine("0. Quit\n1. Add BlueRay to collection\n2. See collection");
      choice = Convert.ToInt32(Console.ReadLine());
      switch(choice){
        case 1: 
          string title;
          string director;
          int year;
          double cost;
          Console.WriteLine("What is the title?");
          title = Console.ReadLine();
          Console.WriteLine("What is the director?");
          director = Console.ReadLine();
          Console.WriteLine("What is the year of release?");
          year = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("What is the cost?");
          cost = Double.Parse(Console.ReadLine());
          BlueRayDisk myBrd = new BlueRayDisk(title, director, year, cost);
          myBrc.addit(title, director, year, cost);
          break;
        case 2:
          myBrc.showAll();
          break;
          
      }
      
    }while(choice !=0);
    
  }
}