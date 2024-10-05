namespace VehicleApp;

/// <summary>
/// Baseklasse for køretøjer.
/// </summary>
public abstract class Vehicle
{
    private string _licensePlate;
    public bool BroBizz { get; set; }

    public double DiscountBB()
    {
        var price = Price();
        if (BroBizz)
        {
            return price * 0.5;
        }
    }

    /// <summary>
    /// Køretøjets nummerplade. Kaster En undtagelse kastes, hvis pladen er længere end 7 tegn.
    /// </summary>
    public string LicensePlate
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
    /// Returnerer køretøjets pris.
    /// </summary>
    public abstract double Price();
    
    /// <summary>
    /// Returnerer køretøjets type.
    /// </summary>
    public abstract string VehicleType();
}