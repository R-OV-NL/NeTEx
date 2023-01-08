using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.General.Items;

public class ValueSet : DataManagedObject
{
    /// <remarks/>
    public MultilingualString Description { get; set; }

    /// <remarks/>
    public valueSetValues values { get; set; }
}