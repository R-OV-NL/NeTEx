using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.TimeTable;

public class ServiceJourneyInterchange : DataManagedObject {

    public bool StaySeated { get; set; }
    
    public bool StaySeatedSpecified { get; set; }

    public bool Guaranteed { get; set; }

    public bool GuaranteedSpecified { get; set; }

    public VersionOfObjectRef FromPointRef { get; set; }

    public VersionOfObjectRef ToPointRef { get; set; }

    public VersionOfObjectRef FromJourneyRef { get; set; }

    public VersionOfObjectRef ToJourneyRef { get; set; }
}