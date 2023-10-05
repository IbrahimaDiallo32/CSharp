using System;


class Program {
  public static void Main (string[] args) {
    int choice=0;
  StockItem milk = new StockItem("1 gallon of milk", 3.60, 15);
  StockItem bread= new StockItem("1 Loaf of bread", 1.98, 30);
  do{
    Console.WriteLine("1. Sold One Milk\n2. Sold One Bread\n3. Change price of Milk\n4. Change price of Bread\n5. Add Milk to Inventory\n6. Add Bread to Inventory\n7. See Inventory\n8. Quit");
  choice = Convert.ToInt32(Console.ReadLine());
    switch(choice){
      case 1:
      milk.lowerQuantity(1);
      break;
      case 2:
      bread.lowerQuantity(1);
      break;
      case 3:
      Console.WriteLine("What is the new price for milk?");
      float newmilk= float.Parse(Console.ReadLine());
      milk.setprice(newmilk);
      break;
      case 4:
      Console.WriteLine("What is the new price for bread?");
      float newbread= float.Parse(Console.ReadLine());
      bread.setprice(newbread);
      break;
      case 5:
      Console.WriteLine("How much milk did we get?");
      int moremilk= Convert.ToInt32(Console.ReadLine());
      milk.raiseQuantity(moremilk);
      break;
      case 6:
      Console.WriteLine("How much bread did we get?");
      int morebread =Convert.ToInt32(Console.ReadLine());
      bread.raiseQuantity(morebread);
      break;
      case 7:
      Console.Write("Milk");
      Console.Write(milk);
      Console.Write("Bread");
      Console.Write(bread);
      break;
      case 8:
      break;
      default:
      break;
    }
      
    
  }while (choice !=8);
  }
}
