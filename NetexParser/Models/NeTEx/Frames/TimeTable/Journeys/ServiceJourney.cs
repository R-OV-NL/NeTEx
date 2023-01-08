using NetexParser.Models.NeTEx.Enumerations;
using NetexParser.Models.NeTEx.Structures;
using KeyValuePair = NetexParser.Models.NeTEx.Structures.KeyValuePair;

namespace NetexParser.Models.NeTEx.Frames.TimeTable.Journeys.ServiceJ;

public class ServiceJourney : DataManagedObject
{
    public ServiceJourney() {
        this.DepartureDayOffset = "0";
        this.Print = true;
        this.DynamicAdvertisement = DynamicAdvertisement.Always;
    }
    
    public KeyValuePair[] KeyList { get; set; }
    
    public VersionOfObjectRef[] ValidityConditions { get; set; }

    public PrivateCode PrivateCode { get; set; }
    
    public bool Monitored { get; set; }
    
    public bool MonitoredSpecified { get; set; }
    
    public DateTime DepartureTime { get; set; }
    
    public string DepartureDayOffset { get; set; }
    
    public VersionOfObjectRef[] DayTypes { get; set; }
    
    public VersionOfObjectRef ServiceJourneyPatternRef { get; set; }
    
    public VersionOfObjectRef TimeDemandTypeRef { get; set; }
    
    public VersionOfObjectRef VehicleTypeRef { get; set; }

    public VersionOfObjectRef OperatorRef { get; set; }

    public bool Print { get; set; }
    
    public DynamicAdvertisement DynamicAdvertisement { get; set; }
}