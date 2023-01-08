using NetexParser.Models.NeTEx.Enumerations;
using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.General.Items;

public class Network : DataManagedObjectStructureWithStatus {
    public MultilingualString Name { get; set; }

    public MultilingualString ShortName { get; set; }

    public MultilingualString Description { get; set; }

    public TransportMode TransportMode { get; set; }
    
    public bool TransportModeSpecified { get; set; }

    public GroupOfLinesType GroupOfLinesType { get; set; }

    public VersionOfObjectRef AuthorityRef { get; set; }
}