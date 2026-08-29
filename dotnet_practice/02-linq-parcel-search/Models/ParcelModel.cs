namespace ParcelFinder.Models;

public class Parcel
{
  public string Pin {get; set; } = string.Empty;
  public string Owner {get; set; } = string.Empty;
  public decimal Area {get; set; }
}