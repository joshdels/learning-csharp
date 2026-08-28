using ParcelManager.Services;

namespace ParcelManager;

public class Program
{
  public static void Main(string[] args)
  {

    for (int i = 0; i < 5; i++)
    {
      var ParcelService = new ParcelService();
      ParcelService.InputParcels();
    }
  }
}