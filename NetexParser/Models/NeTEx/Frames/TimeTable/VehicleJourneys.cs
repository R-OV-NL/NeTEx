using NetexParser.Models.NeTEx.Frames.TimeTable.Journeys;
using NetexParser.Models.NeTEx.Frames.TimeTable.Journeys.ServiceJ;

namespace NetexParser.Models.NeTEx.Frames.TimeTable;

public class VehicleJourneys
{
    public ServiceJourney[] ServiceJourney { get; set; }
    
    public DeadRun[] DeadRun { get; set; }
}