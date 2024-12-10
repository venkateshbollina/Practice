using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class ArrivalAirport
{
    [JsonProperty("@LocationCode")]
    public string LocationCode { get; set; }
}

public class BookingClassAvail
{
    [JsonProperty("@ResBookDesigCode")]
    public string ResBookDesigCode { get; set; }
    [JsonProperty("@ResBookDesigQuantity")]
    public string ResBookDesigQuantity { get; set; }
    [JsonProperty("@RPH")]
    public string RPH { get; set; }
}

public class DepartureAirport
{
    [JsonProperty("@LocationCode")]
    public string LocationCode { get; set; }
}

public class Equipment
{
    [JsonProperty("@AirEquipType")]
    public string AirEquipType { get; set; }
}

public class FlightSegment
{
    public DepartureAirport DepartureAirport { get; set; }
    public ArrivalAirport ArrivalAirport { get; set; }
    public Equipment Equipment { get; set; }
    public MarketingAirline MarketingAirline { get; set; }
    public Meal Meal { get; set; }
    public MarketingCabin MarketingCabin { get; set; }
    public List<BookingClassAvail> BookingClassAvail { get; set; }
    [JsonProperty("@DepartureDateTime")]
    public string DepartureDateTime { get; set; }
    [JsonProperty("@ArrivalDateTime")]
    public string ArrivalDateTime { get; set; }
    [JsonProperty("@StopQuantity")]
    public string StopQuantity { get; set; }
    [JsonProperty("@FlightNumber")]
    public string FlightNumber { get; set; }
    [JsonProperty("@JourneyDuration")]
    public string JourneyDuration { get; set; }
}

public class KIUAirAvailRS
{
    public string Success { get; set; }
    public List<OriginDestinationInformation> OriginDestinationInformation { get; set; }
    [JsonProperty("@EchoToken")]
    public string EchoToken { get; set; }
    [JsonProperty("@TimeStamp")]
    public DateTime TimeStamp { get; set; }
    [JsonProperty("@Target")]
    public string Target { get; set; }
    [JsonProperty("@Version")]
    public string Version { get; set; }
    [JsonProperty("@SequenceNmbr")]
    public string SequenceNmbr { get; set; }
}

public class MarketingAirline
{
    [JsonProperty("@CompanyShortName")]
    public string CompanyShortName { get; set; }
}

public class MarketingCabin
{
    [JsonProperty("@CabinType")]
    public string CabinType { get; set; }
    [JsonProperty("@RPH")]
    public string RPH { get; set; }
}

public class Meal
{
    [JsonProperty("@MealCode")]
    public string MealCode { get; set; }
}

public class OriginDestinationInformation
{
    public DateTime DepartureDateTime { get; set; }
    public string OriginLocation { get; set; }
    public string DestinationLocation { get; set; }
    public OriginDestinationOptions OriginDestinationOptions { get; set; }
}

public class OriginDestinationOption
{
    public FlightSegment FlightSegment { get; set; }
}

public class OriginDestinationOptions
{
    public OriginDestinationOption OriginDestinationOption { get; set; }
}

public class Root
{
    public KIUAirAvailRS KIU_AirAvailRS { get; set; }
}









//using System;
//using System.Runtime.CompilerServices;
//using System.Xml.Serialization;

//namespace XmlDemo
//{
//    [Serializable]
//    [XmlRoot("Menmberdetails")]
//    public class Member
//    {
//        [XmlElement ("MemberName")]
//        public string Name { get; set; }
//        [XmlElement("MemberEmailAdress")]
//        public string Email { get; set; }
//        [XmlElement("MemberAge ")]
//        public int Age { get; set; }
//        [XmlIgnore]
//        public DateTime JoiningDate { get; set; }
//        [XmlAttribute("PlatiniumMember")]
//        public bool IsPlatinumMember { get; set; }

//    }

//}
