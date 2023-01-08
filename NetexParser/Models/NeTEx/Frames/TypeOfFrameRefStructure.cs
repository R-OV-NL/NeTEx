namespace NetexParser.Models.NeTEx.Frames;

public partial class TypeOfFrameRefStructure {
    
    public string Version { get; set; }
    
    public string Ref { get; set; }
}

public partial class TypeOfFrameRefStructureComposite : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureBaseline : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureDelta : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureCodespace : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureBisonEnums : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureDovaLists : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureResource : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureInfra : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureService : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureTimetable : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureCalendar : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureVehicle : TypeOfFrameRefStructure {
}

public partial class TypeOfFrameRefStructureGeneral : TypeOfFrameRefStructure {
}