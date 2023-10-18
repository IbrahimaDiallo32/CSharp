using System;
using System.Collections.Generic;

class BlueRayCollection{
  private Node head = null;

  public void addit(string title, string director, int year, double cost){
    Node temp = new Node();  
    temp = head;
      BlueRayDisk obj = new BlueRayDisk(title, director, year, cost);
    if(head == null){
      head = new Node();
      head.data = obj;
    }else{
    
    while(temp.next != null){
      
      temp = temp.next;
    }
      temp.next = new Node();
    temp.next.data = obj;
    //temp.next = null;
    }
  }
  public void showAll(){
    Node temp = head;  
    while (temp !=null){
      Console.WriteLine(temp.data.ToString());
      temp = temp.next;
    }
  
  }
  
}