namespace NetexParser.Models.NeTEx.Frames.Infrastructure;

public class InfrastructureFrame : Frame
{
    public TypeOfFrameRefStructureInfra TypeOfFrameRef { get; set; }

    public ActivationPoint[] ActivationPoints { get; set; }
}