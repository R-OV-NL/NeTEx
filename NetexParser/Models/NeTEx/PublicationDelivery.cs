using NetexParser.Models.NeTEx.Frames.CompositeFrame;

namespace NetexParser.Models.NeTEx;

public partial class PublicationDelivery {
    public PublicationDelivery() {
        Version = "ntx:1.1";
    }
    
    public DateTime PublicationTimestamp { get; set; }

    public string ParticipantRef { get; set; }

    public MultilingualString Description { get; set; }

    public CompositeFrame[] DataObjects { get; set; }

    public string Version { get; set; }
}