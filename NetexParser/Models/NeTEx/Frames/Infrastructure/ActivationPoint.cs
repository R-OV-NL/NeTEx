using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.Infrastructure;

public class ActivationPoint : DataManagedObject
{

    public Location Location { get; set; }

    public PrivateCode PrivateCode { get; set; }

    public VersionOfObjectRef TypeOfActivationRef { get; set; }
}