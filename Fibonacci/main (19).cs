using System;

class Program {
  public static void Main (string[] args) {
  FibFormula objfor = new FibFormula();
  FibIteration obj = new FibIteration();
   Console.WriteLine("Enter the number you want to find the Fibonacci Series for:");
    int user = Convert.ToInt32(Console.ReadLine());
    int x = objfor.calculate_fib(user);
    int y = obj.calculate_fib(user);
    Console.WriteLine("Fib of 10 by iteration is: " + y + "\nFib of 10 by formula is: "+ x);
  
    
  }
}