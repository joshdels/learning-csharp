namespace ParcelManager.Models;

public class Parcel
{
  public string Pin {get; set; } = string.Empty;
  public string LotNumber {get; set; } = string.Empty;
  public string Owner {get; set; } = string.Empty;
  public decimal AreaSqm {get; set; }
  public string Barangay {get; set; } = string.Empty;
}