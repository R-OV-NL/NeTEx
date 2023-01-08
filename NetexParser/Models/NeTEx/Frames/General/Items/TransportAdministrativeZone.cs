using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.General.Items;

public class TransportAdministrativeZone : DataManagedObjectStructureWithStatus
{
    public MultilingualString Name { get; set; }
    
    public MultilingualString ShortName { get; set; }
    
    public MultilingualString Description { get; set; }
}