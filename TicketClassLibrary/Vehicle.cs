namespace VehicleApp;

/// <summary>
/// baseklase for køretøjer
/// </summary>
public abstract class Vehicle
{
    //<summary> 
    //Køretøjets nummerplade
    //</summary>
    public string LicensePlate { get; set; }
    
    //<summary>
    //Køretøjets dato
    //</summary>
    public DateTime Date { get; set; }
    
    
    //<summary>
    //Køretøjets pris
    //</summary>
    public abstract double Price();
    
    
    //<summary>
    //Køretøjets type
    //</summary>
    public abstract string VehicleType();
    
}