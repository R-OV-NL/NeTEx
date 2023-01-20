namespace NetexParser.Models.NeTEx.Structures;

public class VersionFrameDefaultsStructure {
    public VersionFrameDefaultsStructure() {
        this.DefaultLocationSystem = "EPSG:28992";
        this.DefaultSystemOfUnits = "SiMetres";
        this.DefaultCurrency = "EUR";
    }
    
    public SimpleObjectRefStructure DefaultCodespaceRef { get; set; }
    
    public VersionOfObjectRef DefaultDataSourceRef { get; set; }

    public VersionOfObjectRef DefaultResponsibilitySetRef { get; set; }

    public LocaleStructure DefaultLocale { get; set; }
    
    public string DefaultLocationSystem { get; set; }
    
    public string DefaultSystemOfUnits { get; set; }
    
    public string DefaultCurrency { get; set; }
}