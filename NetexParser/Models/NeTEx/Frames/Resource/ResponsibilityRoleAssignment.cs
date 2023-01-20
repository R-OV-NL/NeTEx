using NetexParser.Models.NeTEx.Structures;

namespace NetexParser.Models.NeTEx.Frames.Resource;

public class ResponsibilityRoleAssignment : DataManagedObject
{
    public string StakeholderRoleType { get; set; }
    
    public VersionOfObjectRef TypeOfResponsibilityRoleRef { get; set; }
    
    public VersionOfObjectRefStructureWithClass ResponsibleOrganisationRef { get; set; }
    
    public VersionOfObjectRefStructureWithClass ResponsibleAreaRef { get; set; }
}