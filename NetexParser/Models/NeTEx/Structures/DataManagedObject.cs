using NetexParser.Models.NeTEx.Enumerations;

namespace NetexParser.Models.NeTEx.Structures;

public abstract class DataManagedObject {
    public DataManagedObject() {
        this.Modification = Modification.New;
        this.Version = "any";
    }
    
    public string Id { get; set; }
    
    public Modification Modification { get; set; }
    
    public string Version { get; set; }
}