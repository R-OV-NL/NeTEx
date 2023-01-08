using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.TimeTable;

public partial class AvailabilityCondition : DataManagedObject {
    
    public MultilingualString Name { get; set; }
    
    public DateTime FromDate { get; set; }
    
    public DateTime ToDate { get; set; }
    
    public string ValidDayBits { get; set; }
    
}