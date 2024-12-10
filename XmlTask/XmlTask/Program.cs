using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;



public class Program
{
    public static void SaveJsonToFile(string json, string filePath)
    {
        File.WriteAllText(filePath, json);
    }
   
    public static string SerializeObjectToJson(KIU_AirAvailRS obj)
    {
        return JsonConvert.SerializeObject(obj, Formatting.Indented);
    }


    public static void Main()
    {

        string xml = File.ReadAllText(@"C:\Users\Admin\source\repos\XmlDemo\XmlDemo1.txt");
        XmlSerializer serializer = new XmlSerializer(typeof(KIU_AirAvailRS));
        using (StringReader reader = new StringReader(xml))
        {
            KIU_AirAvailRS result = (KIU_AirAvailRS)serializer.Deserialize(reader);

            Console.WriteLine($"EchoToken: {result.EchoToken}");
        }

        KIU_AirAvailRS ki = new KIU_AirAvailRS ();
        string json = SerializeObjectToJson(ki);

       
        string filePath = "C:\\Users\\Admin\\source\\repos\\XmlTask\\Taskjson.txt";

    
        SaveJsonToFile(json, filePath);

       
        Console.WriteLine(json);
    }

   
}

