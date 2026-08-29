using System;
using System.Linq;
using ParcelFinder.Models;
using ParcelFinder.Data;

namespace ParcelFinder.Services;

public class FindService
{
    public void ParcelSearchService(string pin)
    {
        List<Parcel> parcels = ParcelData.Parcels;

        var results =
            from parcel in parcels
            where parcel.Pin == pin
            select parcel;

        if (results.Any())
        {
            Console.WriteLine("Parcel Found");

            foreach (var parcel in results)
            {
                Console.WriteLine($"PIN: {parcel.Pin}");
                Console.WriteLine($"Owner: {parcel.Owner}");
                Console.WriteLine($"Area: {parcel.Area}");
            }
        }
        else
        {
            Console.WriteLine("No parcel found");
        }
    }
}

