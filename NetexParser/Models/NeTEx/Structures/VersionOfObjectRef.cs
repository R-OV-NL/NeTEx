namespace NetexParser.Models.NeTEx.Structures;

public partial class VersionOfObjectRef {
    public VersionOfObjectRef() {
        this.Version = "any";
    }
    
    public string Version { get; set; }

    public string Ref { get; set; }
}