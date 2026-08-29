using ParcelManager.Models;


namespace ParcelManager.Services;

public class ParcelService
{
    private readonly List<Parcel> _parcels = new();

    public IReadOnlyList<Parcel> Parcels => _parcels;

    public void InputParcels()
    {
        Console.Write("Enter PIN: ");
        string pin = Console.ReadLine() ?? "";

        Console.Write("Enter LOT Number: ");
        string lotNumber = Console.ReadLine() ?? "";

        Console.Write("Owner: ");
        string owner = Console.ReadLine() ?? "";

        Console.Write("Area (sqm): ");
        string areaInput = Console.ReadLine() ?? "";

        if (!decimal.TryParse(areaInput, out decimal area))
        {
            Console.WriteLine("Invalid area.");
            return;
        }

        Console.Write("Barangay: ");
        string barangay = Console.ReadLine() ?? "";

        try
        {
            CreateParcel(
                pin,
                lotNumber,
                owner,
                area,
                barangay
            );
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private Parcel CreateParcel(
        string pin,
        string lotNumber,
        string owner,
        decimal areaSqm,
        string barangay)
    {
        if (string.IsNullOrWhiteSpace(pin))
            throw new ArgumentException("PIN is required.");

        if (string.IsNullOrWhiteSpace(lotNumber))
            throw new ArgumentException("Lot number is required.");

        if (string.IsNullOrWhiteSpace(owner))
            throw new ArgumentException("Owner is required.");

        if (areaSqm <= 0)
            throw new ArgumentException("Area must be greater than zero.");

        if (string.IsNullOrWhiteSpace(barangay))
            throw new ArgumentException("Barangay is required.");

        var parcel = new Parcel
        {
            Pin = pin.Trim(),
            LotNumber = lotNumber.Trim(),
            Owner = owner.Trim(),
            AreaSqm = areaSqm,
            Barangay = barangay.Trim()
        };

        _parcels.Add(parcel);

        return parcel;
    }
}