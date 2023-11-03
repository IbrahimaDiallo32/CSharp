using System;
public class FibFormula : IFindFib{
  public int calculate_fib(int z){
    double y= (Math.Sqrt(5));
    double plus = (1+y)/2f;
    double minus= (1-y)/2f;
    //splitting up using parenthesis is easier
    int final= Convert.ToInt32((Math.Pow(plus,z)- Math.Pow(minus,z))/ y);
    return final;
  }
  
}
