namespace NetexParser.Models.NeTEx.Frames.Resource;

public class ResourceFrame : Frame
{
    public TypeOfFrameRefStructureResource TypeOfFrameRef { get; set; }

    public DataSource DataSource { get; set; }
    
    public ResponsibilitySet[] ResponsibilitySets { get; set; }

    public resourceFrameTypesOfValue TypesOfValue { get; set; }

    public resourceFrameOrganisations Organisations { get; set; }

    public operationalContext[] OperationalContexts { get; set; }

    public vehicleType[] VehicleTypes { get; set; }

    public resourceFrameZones Zones { get; set; }
}