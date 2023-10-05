using System;
using System.Collections.Generic;
using System.Text;

class Program {
  public static void Main (string[] args) {
    int input=0;
    QuizClass qc = new QuizClass();
    do{
   Console.WriteLine("1. Add a question to the quiz\n2. Remove a question from the quiz\n3. Modify a question in the quiz\n4. Take the quiz\n5. Quit");
      input= Convert.ToInt32(Console.ReadLine());
      switch(input){
        case 1:
        qc.add_question();
          break;
        case 2:
        qc.remove_question();
          break;
        case 3:
        qc.modifyQuestion();
          break;
        case 4:
        qc.giveQuiz();
        
        break;
        default:
          
          break;
          
      }
    }while(input != 5);
  }
}