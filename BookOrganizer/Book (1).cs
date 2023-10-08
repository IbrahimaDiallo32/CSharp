using System;
using System.Collections.Generic;
class Book : Item{
  private int isbn_number;
  private string author;
  public Book(){
    
  }
  public Book (int i, string a, string it){
    isbn_number = i;
    author =a;
    it = ToString();
  }
  public int getisbn(){
    return isbn_number;
  }
  public string getAuthor(){
    return author;
  }
  public void setisbn(int i){
    isbn_number= i;
  }
  public void setAuthor(string a){
    author =a;
  }
  public override void getListing(){
    Console.WriteLine("Book Name - " + ToString() + "\nAuthor - " + author + "\nISBN # - " + isbn_number);
  }
    
}