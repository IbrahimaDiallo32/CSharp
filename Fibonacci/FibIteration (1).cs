using System;
class  FibIteration : IFindFib{
  public int calculate_fib(int y){
    int x=1;
    int cons=3;
    int z=1;
    int final=0;
    if(y ==1 || y==2){
      y=1;
      return y;
    }
    while(cons<=y){
      final=x+z;
      z=x;
      x=final;
      cons++;
    }
    return final;
  }
  
  
}