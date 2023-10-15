using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    string line = "";
    int quizGrade;
      int quizCounter=0;
      int quizSum=0;
      int testGrade;
      int testCounter=0;
      int testSum=0;
    try{
      Console.WriteLine("Enter file");
      string file = Console.ReadLine();
      StreamReader stream = new StreamReader(file);
      while(!stream.EndOfStream){
        line = stream.ReadLine();
        if(line.Contains("quiz")){
          string [] y= line.Split(":");
          quizGrade = Convert.ToInt32(y[1]);
          quizCounter++;
          quizSum+=quizGrade;
        }else{
          string [] y = line.Split(":");
          testGrade = Convert.ToInt32(y[1]);
          testCounter++;
          testSum+=testGrade;
        }
      }
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
    }
    float quizAvg = quizSum/quizCounter;
    float testAvg = testSum/testCounter;
    Console.WriteLine("Quiz Avg: " + quizAvg);
    Console.WriteLine("Test Avg: "+testAvg);
  
  }
}