using System;
using System.Collections.Generic;
class Periodical : Item{
  private int issueNum;
  public Periodical(){
    issueNum=0;
  }
  public Periodical(string it, int i){
    it= getTitle();
    issueNum = i;
  }
  public override void getListing(){
    Console.WriteLine("Periodical Title- "+ ToString() + "\nIssue #- "+ issueNum);
  }
    
}