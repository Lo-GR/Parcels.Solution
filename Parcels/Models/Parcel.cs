namespace Parcels.Models
{
  public class Parcel
  {
    public int Weight {get; set;}

    public int Height {get; set;}
    public int Width {get; set;}

    public Parcel(int weight, int height, int width)
    {
      Weight = weight;
      Height = height;
      Width = width;
      
    }
  }
}