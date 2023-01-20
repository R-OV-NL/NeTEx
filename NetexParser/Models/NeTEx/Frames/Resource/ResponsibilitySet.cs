using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.Resource;

public class ResponsibilitySet : DataManagedObject
{
    public MultilingualString Name { get; set; }
    
    public ResponsibilityRoleAssignment[] Roles { get; set; }
}