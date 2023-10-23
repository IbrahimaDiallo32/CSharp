using System;

class Program {
  static int random;
  
  public static int findFactor(int target, Prime temp){
    try{
    for(int i=0; i<target; i++){
      int number = temp.getPrime(i);
      if(target % number == 0){
        return number;
      }
    }
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
    }
    return -1;
  }
  public static void Main (string[] args) {
    const int cons= 10000;
    Random myRand = new Random();
    Prime obj;
    int rand = 0;
    do{
      rand = myRand.Next(cons);
      random=rand;
      obj = new Prime(rand);

      //Print if it is a prime
      //Console.WriteLine(obj.isPrime(rand));

      //If it is not a prime then set again to true
      
    }while(rand<2 || obj.isPrime(rand));
    Console.WriteLine(random);
    
  Console.WriteLine("What primes make up " + random);
  
    while(rand>=2){
      if(findFactor(rand, obj)!= -1){
         Console.Write(findFactor(rand, obj) + "x");
      }
      rand = rand/findFactor(rand, obj);
    }
  }
}