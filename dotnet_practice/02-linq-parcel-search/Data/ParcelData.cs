using System.Collections.Generic;
using ParcelFinder.Models;

namespace ParcelFinder.Data
{
  public static class ParcelData
  {
    public static readonly List<Parcel> Parcels = new()
    {
      new Parcel {Pin = "12323", Owner = "Joshua", Area = 200},
      new Parcel {Pin = "321-321", Owner= "Giselle", Area= 500},
      new Parcel {Pin = "1002", Owner="John", Area=300}
    };
  }
}

