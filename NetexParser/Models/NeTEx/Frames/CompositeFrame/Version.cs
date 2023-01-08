using NetexParser.Models.NeTEx.Enumerations;
using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.CompositeFrame;

public class Version : DataManagedObjectStructureWithVersion {
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public MultilingualString Description { get; set; }
    
    public VersionType VersionType { get; set; }
    
    public VersionOfObjectRef DerivedFromVersionRef { get; set; }
}