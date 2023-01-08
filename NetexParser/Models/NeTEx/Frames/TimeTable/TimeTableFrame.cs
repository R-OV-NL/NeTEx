namespace NetexParser.Models.NeTEx.Frames.TimeTable;

public class TimeTableFrame : Frame
{
    public TimeTableFrame() {
        this.Monitored = true;
    }
    
    public TypeOfFrameRefStructureTimetable TypeOfFrameRef { get; set; }
    
    public bool Monitored { get; set; }
    
    public AvailabilityCondition[] ContentValidityConditions { get; set; }
    
    public OperatorView OperatorView { get; set; }
    
    public VehicleJourneys VehicleJourneys { get; set; }
    
    public ServiceJourneyInterchange[] JourneyInterchanges { get; set; }
}