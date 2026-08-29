using System;
using ParcelFinder.Services;

namespace ParcelFinder;

public class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Enter you pin to find parcel details: ");
    string userPin = Console.ReadLine() ?? "";

    var searchParcel = new FindService();
    searchParcel.ParcelSearchService(userPin);
  }
}