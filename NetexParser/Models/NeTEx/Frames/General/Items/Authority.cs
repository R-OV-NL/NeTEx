using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.General.Items;

public class Authority : DataManagedObjectStructureWithStatus {
    /// <remarks/>
    public MultilingualString Name { get; set; }

    /// <remarks/>
    public MultilingualString ShortName { get; set; }

    /// <remarks/>
    public MultilingualString Description { get; set; }
}