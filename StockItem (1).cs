using System;
class StockItem{
  private string description;
  private int id;
  private static int nextidnumber=0;
  private double price;
  private int quantity;
  
    public StockItem(){
    description= "";
    id= nextidnumber;
    nextidnumber++;
    price=0;
    quantity=0;
  }
    public StockItem(string d, double p, int q){
    description=d;
    price=p;
    quantity=q;
    id=nextidnumber;
    nextidnumber++;
  }
public override string ToString(){
    return ": Item number: " +id +" is "+description + " has price " +price + " we currently have " + quantity + " in stock\n";
  }
  public string getdescription(){
    return description;
  }
  public int getid(){
    return id;
  }
    public double getprice(){
    return price;
  }
    public int getquantity(){
    return quantity;
  }
    public void setprice(double prce){
    if (prce>0){
      price=prce;
    }else{
      Console.Write("Error message. Price is lower than 0.");
    }
  }
    public void lowerQuantity(int substract){
    if(quantity-substract>0){
    quantity-=substract;
  }else{
      Console.Write("Error message.");
  }
}
    public void raiseQuantity(int raiser){
      quantity += raiser;
    }
  }
