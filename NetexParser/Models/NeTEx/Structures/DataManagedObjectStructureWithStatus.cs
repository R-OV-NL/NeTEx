using NetexParser.Models.NeTEx.Enumerations;

namespace NetexParser.Models.NeTEx.Structures;

public abstract class DataManagedObjectStructureWithStatus : DataManagedObject {
    public DataManagedObjectStructureWithStatus() {
        this.Modification = Modification.New;
        this.Version = "any";
        this.Status = Status.Active;
    }

    public Status Status { get; set; }
}