using AutoMapper;
using NetexParser.Contracts;
using NetexParser.Models.NeTEx;
using NetexParser.Models.NeTEx.Enumerations;
using NetexParser.Models.NeTEx.Frames;
using NetexParser.Models.NeTEx.Frames.CompositeFrame;
using NetexParser.Models.NeTEx.Frames.General;
using NetexParser.Models.NeTEx.Frames.General.Items;
using NetexParser.Models.NeTEx.Frames.TimeTable;
using NetexParser.Models.NeTEx.Frames.TimeTable.Journeys;
using NetexParser.Models.NeTEx.Frames.TimeTable.Journeys.ServiceJ;
using NetexParser.Models.NeTEx.Structures;
using NetexParser.Services;
using KeyValuePair = NetexParser.Models.NeTEx.Structures.KeyValuePair;
using Version = NetexParser.Models.NeTEx.Frames.CompositeFrame.Version;

namespace NetexParser;

public class Program
{
    public static async Task Main(string[] args)
    {
        Startup.Configure(args).Wait();
        
        IXmlParserService xmlParserService = new XmlParserService();

        XMLDelivery delivery = await xmlParserService.ParseXmlAsync<XMLDelivery>("netex.xml");

        var config = new MapperConfiguration(cfg =>
        {
            

            /*
             * General NeTEx
             */
            cfg.CreateMap<XMLDelivery, PublicationDelivery>();
            cfg.CreateMap<MultilingualString, Models.NeTEx.MultilingualString>();
            

            
            cfg.CreateMap<VersionOfObjectRefStructure, VersionOfObjectRef>();
            cfg.CreateMap<SimpleObjectStructure, SimpleObject>();
            cfg.CreateMap<DataManagedObjectStructure, DataManagedObject>()
                .Include<serviceJourney, ServiceJourney>()
                .Include<deadRun, DeadRun>()
                .Include<valueSet, ValueSet>()
                .Include<availabilityCondition, AvailabilityCondition>()
                .Include<serviceJourneyInterchange, ServiceJourneyInterchange>()
                .Include<DataManagedObjectStructurewithversion, DataManagedObjectStructureWithVersion>()
                .Include<DataManagedObjectStructurewithstatus, DataManagedObjectStructureWithStatus>();
            
            cfg.CreateMap<DataManagedObjectStructurewithversion, DataManagedObjectStructureWithVersion>()
                .Include<version, Version>();

            cfg.CreateMap<DataManagedObjectStructurewithstatus, DataManagedObjectStructureWithStatus>()
                .Include<authority, Authority>()
                .Include<network, Network>()
                .Include<tariffZone, TariffZone>()
                .Include<transportAdministrativeZone, TransportAdministrativeZone>();

            cfg.CreateMap<codespace, Codespace>();
            cfg.CreateMap<KeyListStructureKeyValue, KeyValuePair>();

            cfg.CreateMap<PrivateCodeStructure, PrivateCode>();
            
            
            /*
             * Frames
             */
                // General
                cfg.CreateMap<VersionFrameVersionStructure, Frame>()
                    .Include<generalFrame, GeneralFrame>()
                    .Include<timetableFrame, TimeTableFrame>();
                
                cfg.CreateMap<VersionFrameDefaultsStructure, Models.NeTEx.Frames.CompositeFrame.VersionFrameDefaultsStructure>();
                cfg.CreateMap<version, Version>();
                cfg.CreateMap<versions, Versions>();
            
                //Structures
                
                //Base structure with its subclasses
                cfg.CreateMap<TypeOfFrameRefStructure, Models.NeTEx.Frames.TypeOfFrameRefStructure>()
                    .Include<TypeOfFrameRefStructurecomposite, TypeOfFrameRefStructureComposite>()
                    .Include<TypeOfFrameRefStructuredelta, TypeOfFrameRefStructureDelta>()
                    .Include<TypeOfFrameRefStructurebaseline, TypeOfFrameRefStructureBaseline>()
                    .Include<TypeOfFrameRefStructurecodespace, TypeOfFrameRefStructureCodespace>()
                    .Include<TypeOfFrameRefStructurebisonenums, TypeOfFrameRefStructureBisonEnums>()
                    .Include<TypeOfFrameRefStructuredovalists, TypeOfFrameRefStructureDovaLists>()
                    .Include<TypeOfFrameRefStructureresource, TypeOfFrameRefStructureResource>()
                    .Include<TypeOfFrameRefStructureinfra, TypeOfFrameRefStructureInfra>()
                    .Include<TypeOfFrameRefStructureservice, TypeOfFrameRefStructureService>()
                    .Include<TypeOfFrameRefStructuretimetable, TypeOfFrameRefStructureTimetable>()
                    .Include<TypeOfFrameRefStructurecalendar, TypeOfFrameRefStructureCalendar>()
                    .Include<TypeOfFrameRefStructurevehicle, TypeOfFrameRefStructureVehicle>()
                    .Include<TypeOfFrameRefStructuregeneral, TypeOfFrameRefStructureGeneral>();
                
                //Mapping of the subclasses
                cfg.CreateMap<TypeOfFrameRefStructurecomposite, TypeOfFrameRefStructureComposite>();
                cfg.CreateMap<TypeOfFrameRefStructuredelta, TypeOfFrameRefStructureDelta>();
                cfg.CreateMap<TypeOfFrameRefStructurebaseline, TypeOfFrameRefStructureBaseline>();
                cfg.CreateMap<TypeOfFrameRefStructurecodespace, TypeOfFrameRefStructureCodespace>();
                cfg.CreateMap<TypeOfFrameRefStructurebisonenums, TypeOfFrameRefStructureBisonEnums>();
                cfg.CreateMap<TypeOfFrameRefStructuredovalists, TypeOfFrameRefStructureDovaLists>();
                cfg.CreateMap<TypeOfFrameRefStructureresource, TypeOfFrameRefStructureResource>();
                cfg.CreateMap<TypeOfFrameRefStructureinfra, TypeOfFrameRefStructureInfra>();
                cfg.CreateMap<TypeOfFrameRefStructureservice, TypeOfFrameRefStructureService>();
                cfg.CreateMap<TypeOfFrameRefStructuretimetable, TypeOfFrameRefStructureTimetable>();
                cfg.CreateMap<TypeOfFrameRefStructurecalendar, TypeOfFrameRefStructureCalendar>();
                cfg.CreateMap<TypeOfFrameRefStructurevehicle, TypeOfFrameRefStructureVehicle>();
                cfg.CreateMap<TypeOfFrameRefStructuregeneral, TypeOfFrameRefStructureGeneral>();

                // Composite Frame
                cfg.CreateMap<compositeFrame, CompositeFrame>();
                cfg.CreateMap<compositeFrameFrames, Frames>();
                
                // General Frame
                cfg.CreateMap<generalFrame, GeneralFrame>();
                cfg.CreateMap<generalFrameMembers, GeneralFrameMembers>();
                cfg.CreateMap<authority, Authority>();
                cfg.CreateMap<network, Network>();
                cfg.CreateMap<tariffZone, TariffZone>();
                cfg.CreateMap<transportAdministrativeZone, TransportAdministrativeZone>();
                cfg.CreateMap<valueSet, ValueSet>();
                // Time Table Frame
                cfg.CreateMap<timetableFrame, TimeTableFrame>();
                cfg.CreateMap<timetableFrameOperatorView, OperatorView>();
                cfg.CreateMap<availabilityCondition, AvailabilityCondition>();
                cfg.CreateMap<timetableFrameVehicleJourneys, VehicleJourneys>();
                cfg.CreateMap<serviceJourneyInterchange, ServiceJourneyInterchange>();
                
                //Journeys
                cfg.CreateMap<serviceJourney, ServiceJourney>()
                    .ForMember(x => x.DynamicAdvertisement, opt => opt.MapFrom(src => src.Dynamic));

                cfg.CreateMap<deadRun, DeadRun>();
            /*
             * Enumerations
             */
            cfg.CreateMap<ModificationEnumeration, Modification>();
            cfg.CreateMap<VersionTypeEnumeration, VersionType>();
            cfg.CreateMap<DynamicAdvertisementEnumeration, DynamicAdvertisement>();
            cfg.CreateMap<DeadRunTypeEnumeration, DeadRunType>();
            cfg.CreateMap<StatusEnumeration, Status>();
            cfg.CreateMap<TransportmodeEnum, TransportMode>();
            cfg.CreateMap<GroupOfLinesTypeEnumeration, GroupOfLinesType>();

        });
        
        IMapper mapper = config.CreateMapper();
        
        mapper.ConfigurationProvider.AssertConfigurationIsValid();
        
        PublicationDelivery publicationDelivery = mapper.Map<PublicationDelivery>(delivery);
        
        Console.WriteLine(publicationDelivery.Description.Lang);
        Console.WriteLine(publicationDelivery.Description.Value);
        Console.WriteLine(delivery.dataObjects.First().frames.Items.Length);

    }
}