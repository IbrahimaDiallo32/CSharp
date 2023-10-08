using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    List<Item> myList = new List<Item>();
    for (int i=0; i<5; i++){
      Console.WriteLine("Please enter B for Book or P for Periodical");
      char choice = Convert.ToChar(Console.ReadLine());
      if(choice == 'B' || choice == 'b'){
        Console.WriteLine("Please enter the name of the Book");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter the author of the Book");
        string author = Console.ReadLine();
        Console.WriteLine("Please enter the ISBN of the Book");
        int isbn = Convert.ToInt32(Console.ReadLine());
        Item bookobj = new Book(isbn, author, name);
        bookobj.setTitle(name);
        myList.Add(bookobj);
      }else if(choice == 'P' || choice == 'p'){
        Console.WriteLine("Please enter the name of Periodical");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter the issue number");
        int issnum = Convert.ToInt32(Console.ReadLine());    
        Item periodobj = new Periodical(name, issnum);
        periodobj.setTitle(name);
        myList.Add(periodobj);
      }else{
        Console.WriteLine("Please enter valid character.");
      }
    }
    Console.WriteLine("Your Items:");
     for (int i=0; i<myList.Count; i++){
        myList[i].getListing();
       Console.WriteLine("\n");
       
    }
  }
}