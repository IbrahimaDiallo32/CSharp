using System;

class BlueRayDisk{
  public string title;
  public string director;
  public int releaseDate;
  public double cost;

  public BlueRayDisk(string t, string d, int r, double c){
    title = t;
    director = d;
    releaseDate = r;
    cost = c;
    
  }

  public override string ToString(){
    return "$ " + cost + " " + releaseDate + " " + title + ", " + director;
  }
}