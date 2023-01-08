using NetexParser.Models.NeTEx.Enumerations;

namespace NetexParser.Models.NeTEx.Structures;

public abstract class DataManagedObjectStructureWithVersion : DataManagedObject {
    protected DataManagedObjectStructureWithVersion() {
        this.Modification = Modification.New;
    }
}