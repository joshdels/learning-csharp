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

        // query syntax
        var results =
            from parcel in parcels
            where parcel.Pin == pin
            select parcel;

        // you can also write this one method syntax
        var results_v2 = parcels
            .Where(parcel => parcel.Pin == pin);
            

        if (results.Any())
        {
            Console.WriteLine("Parcel Found");

            foreach (var parcel in results_v2)
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

