using NetexParser.Models.NeTEx.Enumerations;
using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.TimeTable.Journeys;

public class DeadRun : DataManagedObject
{
    public DeadRun() {
        this.DepartureDayOffset = "0";
    }
    
    public VersionOfObjectRef[] ValidityConditions { get; set; }

    public PrivateCode PrivateCode { get; set; }

    public bool Monitored { get; set; }

    public bool MonitoredSpecified { get; set; }

    public DateTime DepartureTime { get; set; }
    public string DepartureDayOffset { get; set; }

    public VersionOfObjectRef[] DayTypes { get; set; }

    public VersionOfObjectRef DeadRunJourneyPatternRef { get; set; }

    public VersionOfObjectRef TimeDemandTypeRef { get; set; }

    public VersionOfObjectRef VehicleTypeRef { get; set; }

    public DeadRunType DeadRunType { get; set; }

    public bool DeadRunTypeSpecified { get; set; }
}