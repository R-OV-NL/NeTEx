using NetexParser.Models.NeTEx.Enumerations;

namespace NetexParser.Models.NeTEx.Frames;

public partial class Frame {
    public Frame() {
        this.Modification = Modification.New;
    }
    
    public string Id { get; set; }

    public Modification Modification { get; set; }

    public string Version { get; set; }
}