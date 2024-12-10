using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

//public class ArrivalAirport
//{
//    [JsonProperty("@LocationCode")]
//    public string LocationCode { get; set; }
//}

//public class BookingClassAvail
//{
//    [JsonProperty("@ResBookDesigCode")]
//    public string ResBookDesigCode { get; set; }
//    [JsonProperty("@ResBookDesigQuantity")]
//    public string ResBookDesigQuantity { get; set; }
//    [JsonProperty("@RPH")]
//    public string RPH { get; set; }
//}

//public class DepartureAirport
//{
//    [JsonProperty("@LocationCode")]
//    public string LocationCode { get; set; }
//}

//public class Equipment
//{
//    [JsonProperty("@AirEquipType")]
//    public string AirEquipType { get; set; }
//}

//public class FlightSegment
//{
//    public DepartureAirport DepartureAirport { get; set; }
//    public ArrivalAirport ArrivalAirport { get; set; }
//    public Equipment Equipment { get; set; }
//    public MarketingAirline MarketingAirline { get; set; }
//    public Meal Meal { get; set; }
//    public MarketingCabin MarketingCabin { get; set; }
//    public List<BookingClassAvail> BookingClassAvail { get; set; }
//    [JsonProperty("@DepartureDateTime")]
//    public string DepartureDateTime { get; set; }
//    [JsonProperty("@ArrivalDateTime")]
//    public string ArrivalDateTime { get; set; }
//    [JsonProperty("@StopQuantity")]
//    public string StopQuantity { get; set; }
//    [JsonProperty("@FlightNumber")]
//    public string FlightNumber { get; set; }
//    [JsonProperty("@JourneyDuration")]
//    public string JourneyDuration { get; set; }
//}

//public class KIUAirAvailRS
//{
//    public string Success { get; set; }
//    public List<OriginDestinationInformation> OriginDestinationInformation { get; set; }
//    [JsonProperty("@EchoToken")]
//    public string EchoToken { get; set; }
//    [JsonProperty("@TimeStamp")]
//    public DateTime TimeStamp { get; set; }
//    [JsonProperty("@Target")]
//    public string Target { get; set; }
//    [JsonProperty("@Version")]
//    public string Version { get; set; }
//    [JsonProperty("@SequenceNmbr")]
//    public string SequenceNmbr { get; set; }
//}

//public class MarketingAirline
//{
//    [JsonProperty("@CompanyShortName")]
//    public string CompanyShortName { get; set; }
//}

//public class MarketingCabin
//{
//    [JsonProperty("@CabinType")]
//    public string CabinType { get; set; }
//    [JsonProperty("@RPH")]
//    public string RPH { get; set; }
//}

//public class Meal
//{
//    [JsonProperty("@MealCode")]
//    public string MealCode { get; set; }
//}

//public class OriginDestinationInformation
//{
//    public DateTime DepartureDateTime { get; set; }
//    public string OriginLocation { get; set; }
//    public string DestinationLocation { get; set; }
//    public OriginDestinationOptions OriginDestinationOptions { get; set; }
//}

//public class OriginDestinationOption
//{
//    public FlightSegment FlightSegment { get; set; }
//}

//public class OriginDestinationOptions
//{
//    public OriginDestinationOption OriginDestinationOption { get; set; }
//}

//public class Root
//{
//    public KIUAirAvailRS KIU_AirAvailRS { get; set; }
//}


public class KIU_AirAvailRS
{
    [XmlAttribute("EchoToken")]
    public string EchoToken { get; set; }

    [XmlAttribute("TimeStamp")]
    public string TimeStamp { get; set; }

    [XmlAttribute("Target")]
    public string Target { get; set; }

    [XmlAttribute("Version")]
    public string Version { get; set; }

    [XmlAttribute("SequenceNmbr")]
    public string SequenceNmbr { get; set; }

    public Success Success { get; set; }

    [XmlElement("OriginDestinationInformation")]
    public List<OriginDestinationInformation> OriginDestinationInformation { get; set; }
}

public class Success
{

}

public class OriginDestinationInformation
{
    [XmlElement("DepartureDateTime")]
    public string DepartureDateTime { get; set; }

    [XmlElement("OriginLocation")]
    public string OriginLocation { get; set; }

    [XmlElement("DestinationLocation")]
    public string DestinationLocation { get; set; }

    [XmlElement("OriginDestinationOptions")]
    public OriginDestinationOptions OriginDestinationOptions { get; set; }
}

public class OriginDestinationOptions
{
    [XmlElement("OriginDestinationOption")]
    public List<OriginDestinationOption> OriginDestinationOption { get; set; }
}

public class OriginDestinationOption
{
    [XmlElement("FlightSegment")]
    public FlightSegment FlightSegment { get; set; }
}

public class FlightSegment
{
    [XmlElement("DepartureDateTime")]
    public string DepartureDateTime { get; set; }

    [XmlElement("ArrivalDateTime")]
    public string ArrivalDateTime { get; set; }

    [XmlElement("StopQuantity")]
    public int StopQuantity { get; set; }

    [XmlElement("FlightNumber")]
    public string FlightNumber { get; set; }

    [XmlElement("JourneyDuration")]
    public string JourneyDuration { get; set; }

    [XmlElement("DepartureAirport")]
    public Airport DepartureAirport { get; set; }

    [XmlElement("ArrivalAirport")]
    public Airport ArrivalAirport { get; set; }

    [XmlElement("Equipment")]
    public Equipment Equipment { get; set; }

    [XmlElement("MarketingAirline")]
    public MarketingAirline MarketingAirline { get; set; }

    [XmlElement("Meal")]
    public Meal Meal { get; set; }

    [XmlElement("MarketingCabin")]
    public MarketingCabin MarketingCabin { get; set; }

    [XmlArray("BookingClassAvail")]
    [XmlArrayItem("BookingClassAvail")]
    public List<BookingClassAvail> BookingClassAvail { get; set; }
}

public class Airport
{
    [XmlAttribute("LocationCode")]
    public string LocationCode { get; set; }
}

public class Equipment
{
    [XmlAttribute("AirEquipType")]
    public string AirEquipType { get; set; }
}

public class MarketingAirline
{
    [XmlAttribute("CompanyShortName")]
    public string CompanyShortName { get; set; }
}

public class Meal
{
    [XmlAttribute("MealCode")]
    public string MealCode { get; set; }
}

public class MarketingCabin
{
    [XmlAttribute("CabinType")]
    public string CabinType { get; set; }

    [XmlAttribute("RPH")]
    public string RPH { get; set; }
}

public class BookingClassAvail
{
    [XmlAttribute("ResBookDesigCode")]
    public string ResBookDesigCode { get; set; }

    [XmlAttribute("ResBookDesigQuantity")]
    public string ResBookDesigQuantity { get; set; }

    [XmlAttribute("RPH")]
    public string RPH { get; set; }
}


