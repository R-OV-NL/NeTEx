using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.General.Items;

public class ValueSet : DataManagedObject
{
    public MultilingualString Description { get; set; }
    
    public ValueSetValues Values { get; set; }
}