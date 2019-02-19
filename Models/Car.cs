using System;

namespace Dealership
{

  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private double MilesPerGallon;

    public Car(string makeModel, int price, int miles, double milesPerGallon)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      MilesPerGallon = milesPerGallon;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public double GetMilesPerGallon()
    {
      return MilesPerGallon;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price <= maxPrice && Miles <= maxMileage);
    }
  }

}
