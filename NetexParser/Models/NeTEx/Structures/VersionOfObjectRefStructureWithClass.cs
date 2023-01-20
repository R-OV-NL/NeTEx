namespace NetexParser.Models.NeTEx.Structures;

public class VersionOfObjectRefStructureWithClass : VersionOfObjectRef
{
    public VersionOfObjectRefStructureWithClass() {
        this.Version = "any";
    }
    
    public string NameOfRefClass { get; set; }
}