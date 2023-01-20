using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.Resource;

public class DataSource : DataManagedObject
{
    
    public MultilingualString Name { get; set; }
    
    public MultilingualString ShortName { get; set; }

    public MultilingualString Description { get; set; }
    
    public string Email { get; set; }
}
