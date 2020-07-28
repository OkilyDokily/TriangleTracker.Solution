using System;
namespace TriangleTracker{
  public class Triangle{
    public int SideOne{get;}
    public int SideTwo{get;}
    public int SideThree{get;}

    public Triangle(int sideOne, int sideTwo, int sideThree){
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }

     public string TriangleTyper(){
       if(SideOne == SideTwo && SideOne == SideThree){
         return "equilateral";
       }
       return "";
     } 
  }

 
}