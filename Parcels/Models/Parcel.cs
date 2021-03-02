// using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Weight {get; set;}

    public int Height {get; set;}
    public int Length {get; set;}
    public int Width {get; set;}
    public string Description {get; set;}
    private static List<Parcel> _instances = new List<Parcel> {};
    public Parcel(int weight, int height, int width, int length, string desc)
    {
      Weight = weight;
      Height = height;
      Width = width;
      Length = length;
      Description = desc;
      _instances.Add(this);

    }
  }
}