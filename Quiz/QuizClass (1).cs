  using System;
using System.Collections.Generic;
using System.Collections;

class QuizClass{

 List<QuestionClass> myList = new List<QuestionClass>();
 // ArrayList myArray = new ArrayList();

  public void add_question(){
    Console.WriteLine("What is the question Text?");
    string qu= Console.ReadLine();
    Console.WriteLine("What is the answer?");
    string a = Console.ReadLine();
    Console.WriteLine("How Difficult (1-3)?");
    int d = Convert.ToInt32(Console.ReadLine());
    QuestionClass objectnumber = new QuestionClass(qu, a, d);
    myList.Add(objectnumber);  
}
  public void remove_question(){
    for (int i=0; i < myList.Count; i++){
      Console.WriteLine(i+1 +": " );
      myList[i].TString();
    }
    Console.WriteLine("Choose the question to remove.");
  int choice = Convert.ToInt32(Console.ReadLine());
    myList.RemoveAt(choice);
  }
  public void modifyQuestion(){
    for (int i=0; i < myList.Count; i++){
      Console.Write(i+1 +": ");
        myList[i].TString();

    }
    Console.WriteLine("Choose the question to modify.");
  int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What is the question Text?");
    string q= Console.ReadLine();
    Console.WriteLine("What is the answer?");
    string a= Console.ReadLine();
    Console.WriteLine("What is the difficulty");
    int d= Convert.ToInt32(Console.ReadLine());
   
      myList[choice-1].setquestion(q);
      myList[choice-1].setanswer(a);
      myList[choice-1].setdifficulty(d);
    
    
  }
  public int giveQuiz(){
    int score=0;
    for(int i=0; i<myList.Count;i++){
      myList[i].TString();
      string answer= Console.ReadLine();
      if(answer == myList[i].getanswer()){
        score++;
        Console.WriteLine("Correct!");
      }else{ 
        Console.WriteLine("Incorrect");
      }
    }
    return score;
  }
  
  
}
