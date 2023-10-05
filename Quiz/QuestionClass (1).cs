using System;
using System.Collections.Generic;
using System.Collections;

class QuestionClass{
  private string question;
  private string answer;
  private int difficulty;
  private static int objnumber=0;
  private static int objectnumber;
  public QuestionClass(string q, string a, int d){
    question =q;
    answer =a;
    difficulty =d;
    objectnumber=objnumber;
    objnumber++;
    getanswer();
  }
  public string getquestion(){
    return question;
  }
  public string getanswer(){
    return answer;
  }
  public int getdifficulty(){
    return difficulty;
  }
  public void setquestion(string x){
    question =x;
  }
  public void setanswer(string y){
    answer =y;
  }
  public void setdifficulty(int z){
    difficulty =z;
  }
  public void TString(){
    Console.WriteLine(question);
  }
}