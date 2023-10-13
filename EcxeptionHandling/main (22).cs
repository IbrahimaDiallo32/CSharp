using System;

class Program {

  public static int time(string x){
    string [] y = x.Split(":",3);
    if(y.Length != 3){
      throw new InvalidTime("Enter a valid time");
    }
    int a=0;
    bool b;
    bool c;
    bool d;
    b= int.TryParse(y[0], out a);
    c= int.TryParse(y[1], out a);
    d = int.TryParse(y[2], out a);

    
    if(b== false || c== false || d == false){
      throw new InvalidFormat("Enter valid time.");
    }
    
    int hour = Int32.Parse(y[0]);
    int minute = Int32.Parse(y[1]);
    int second = Int32.Parse(y[2]);
    
    
    /*try{
    int hour = Int32.Parse(y[0]);
    int minute = Int32.Parse(y[1]);
    int second = Int32.Parse(y[2]);
    }
    catch(FormatException e){
      Console.WriteLine();
    }*/
    //if(y[0]/1 != y[0]){
      
   // }

    if(hour>23){
      throw new InvalidHour("Hour must be below 24.");
    }else if(hour<0){
      throw new InvalidHour("Enter a valid time");
    }
    
    if(minute>59){
      throw new InvalidTime("Minutes must be less than 60.");
    }else if(minute<0){
      throw new InvalidTime("Enter a valid time");
    }
    
    if(second >59){
      throw new InvalidTime("Seconds must be less than 60.");
    }else if(second <0){
      Console.WriteLine("Enter a valid time");
    }
  
    

    return (hour*60*60) + (minute*60) + second;
  }
  public static void Main (string[] args) {
    Console.WriteLine("Enter time 1 in 24hr format as follows (HH:MM:SS)");
    try{
      string entry1 = Console.ReadLine();
      int time1 = time(entry1);
      Console.WriteLine("Enter time 2 in 24hr format as follows (HH:MM:SS)");
      string entry2 = Console.ReadLine();
      int time2 = time(entry2);
      int answer = time2-time1;
      Console.WriteLine("Difference in seconds: " + answer);
    }
    catch(InvalidHour e){
      Console.WriteLine(e.Message);
    }
    catch(InvalidTime e){
      Console.WriteLine(e.Message);
      }
    catch(InvalidFormat e){
      Console.WriteLine(e.Message);
    }

    
  }
}