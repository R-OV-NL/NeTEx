namespace NetexParser.Models.NeTEx.Frames.CompositeFrame;

public class CompositeFrame : VersionFrameVersionStructure {
    public MultilingualString Description { get; set; }
    
    public TypeOfFrameRefStructureComposite TypeOfFrameRef { get; set; }

    public Codespace[] Codespaces { get; set; }
    
    public VersionFrameDefaultsStructure FrameDefaults { get; set; }
    
    public Versions Versions { get; set; }
    
    public Frames Frames { get; set; }
}