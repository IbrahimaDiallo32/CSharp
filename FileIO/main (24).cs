using System;
using System.IO;

class Program {
  static int linecounter =0;
  static int counter1=0;
  static int counter2=0;
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter the first file: ");
    string first = Console.ReadLine();
    Console.WriteLine ("Please enter the second file: ");
    string second = Console.ReadLine();
    try {
      StreamReader stream = new StreamReader(first);
      StreamReader stream2 = new StreamReader(second);

     
      while(!stream.EndOfStream || !stream2.EndOfStream){
        string line = stream.ReadLine();
        string line2 = stream2.ReadLine();
        if(line != line2){
          Console.WriteLine("Line " + (linecounter+1) );
          Console.WriteLine("< " + line);
          Console.WriteLine("> " + line2);
        }
        linecounter++;
        if(!stream.EndOfStream){
          counter1++;
        }
        if(!stream2.EndOfStream){
          counter2++;
        }
        
      }
      if(counter1 != counter2){
        Console.WriteLine("Files have different number of lines");
      }
    
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
    }

  }
}