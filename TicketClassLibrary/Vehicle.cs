namespace VehicleApp;

/// <summary>
/// Baseklasse for køretøjer.
/// </summary>
public abstract class Vehicle
{
    private string? _licensePlate;
        
    public bool BroBizz { get; set; }

    /// <summary>
    /// Returnerer køretøjets pris. Hvis BroBizz er true, anvendes en rabat på 5%.
    /// </summary>
    public double DiscountBB()
    {
        var price = Price();

        if (BroBizz)
        {
            price *= 0.95;  // Anvend 5% rabat
        }

        return price;
    }

    /// <summary>
    /// Køretøjets nummerplade. Kaster en undtagelse, hvis nummerpladen er længere end 7 tegn.
    /// </summary>
    public string? LicensePlate
    {
        get { return _licensePlate; }
        set
        {
            if (value.Length > 7)   
            {
                throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn.");
            }
            _licensePlate = value;
        }
    }

    /// <summary>
    /// Køretøjets dato.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Returnerer køretøjets pris. Skal implementeres af nedarvede klasser.
    /// </summary>
    public abstract double Price();

    /// <summary>
    /// Returnerer køretøjets type. Skal implementeres af nedarvede klasser.
    /// </summary>
    public abstract string VehicleType();
}