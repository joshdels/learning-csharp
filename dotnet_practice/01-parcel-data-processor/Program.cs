using ParcelManager.Services;
using AnalyzeParcels.Services;

namespace ParcelManager;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Parcel Analyzer\n");

        var parcelService = new ParcelService();

        bool runProgram = true;

        while (runProgram)
        {
            parcelService.InputParcels();

            Console.WriteLine(
                "\nAdd More?\n" +
                "Press 1 to continue\n" +
                "Press 2 to stop and analyze"
            );

            string? userResponse = Console.ReadLine();

            if (userResponse == "2")
            {
                runProgram = false;
            }
        }

        var analyzeParcel = new AnalyzeService();

        analyzeParcel.parcelsSummary(parcelService.Parcels);
    }
}