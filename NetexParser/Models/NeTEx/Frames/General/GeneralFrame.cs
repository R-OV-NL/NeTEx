namespace NetexParser.Models.NeTEx.Frames.General;

public class GeneralFrame : Frame
{
    public MultilingualString Description { get; set; }
    
    public TypeOfFrameRefStructureGeneral TypeOfFrameRef { get; set; }
    
    public GeneralFrameMembers Members { get; set; }
}