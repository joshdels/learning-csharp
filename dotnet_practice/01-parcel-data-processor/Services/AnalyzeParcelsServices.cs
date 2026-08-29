using ParcelManager.Models;

namespace AnalyzeParcels.Services;

public class AnalyzeService
{
  public void parcelsSummary(IReadOnlyList<Parcel> parcels )
  {
    Console.WriteLine("\nReport Analysis\n");
    Console.WriteLine( $"Total parcels: {parcels.Count}");

    if (parcels.Count == 0)
    {
      Console.WriteLine("No parcels to analyze");
      return;
    }
    
    decimal totalArea = 0;
    Parcel? largestParcel = null;
    Parcel? smallestParcel = null;

    foreach (Parcel parcel in parcels)
    {
      totalArea += parcel.AreaSqm;
      
      if (largestParcel == null || parcel.AreaSqm > largestParcel.AreaSqm)
      {
        largestParcel = parcel;
      }

      if (smallestParcel == null || parcel.AreaSqm < smallestParcel.AreaSqm)
      {
        smallestParcel = parcel;
      }
    }

    decimal averageArea = totalArea / parcels.Count;

    Console.WriteLine($"Total area: {totalArea} sqm");
    Console.WriteLine($"Average parcel area: {averageArea} sqm");
    Console.WriteLine($"Largest Parcel {largestParcel!.Pin} with area of {largestParcel.AreaSqm:N2}" );
    Console.WriteLine($"Smallest Parcel {smallestParcel!.Pin} with are of {smallestParcel.AreaSqm:N2}");
  }
}