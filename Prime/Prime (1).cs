using System;
using System.Collections.Generic;
using System.Linq;

public class Prime{
  LinkedList<int> LL = new LinkedList<int>();
  public Prime(int max){
    double sqr = Math.Sqrt(max);
    int sqrt = Convert.ToInt32(sqr);
    bool [] arr = new bool[max];
    int counter =2;
    int arrCount=2;
    Console.WriteLine("This is the sqaure root  "+ sqrt +".");

    //filling all indexes with true values
    for(int i=0; i<max; i++){
      arr[i]= true;
    }
    //setting all non-primes to false
    for (int i=2; i<sqrt;i++){
      for(int j=i+1;j<max;j++){ 
        if(j % i == 0){
          arr[j] = false;
        }
    }
    }
    /*while(counter <= sqrt){
      
      for(int i=counter; i<max; i++){
      if(arrCount % i == 0){
        arr[arrCount] = false;
      }
        arrCount++;
    }
      arrCount=2;
      counter++;
    }*/
    
    //adding all primes to Linked List
    for(int i=2; i<max; i++){
      if(arr[i] == true){
        LL.AddFirst(i);
      }
    }
    //printing all elements in the List
    /*foreach(int temp in LL){
      Console.WriteLine(temp);
    }
    Console.WriteLine("End of list");
  */
  }
  public bool isPrime(int x){
     foreach(int temp in LL){
     if(temp == x){
       return true;
     }
    }
        return false;
        }
  public int getPrime(int x){
    return LL.ElementAt(x);
  }
}
