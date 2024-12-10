using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace XmlDemo
{
    public class Program
    {
        static void Main()
        {
            //SerializeObjectToString();
            //SerialiseObjectToFile();
            //SerialiseListToFile();
            DSerializeXmlFileToList();
        }

        //private static void SerializeObjectToString()
        //{
        //    var member = new Member
        //    {
        //        Name = "sunny",
        //        Email = "sunny@gmail.com",
        //        Age = 24,
        //        JoiningDate = DateTime.Now,
        //        IsPlatinumMember = false,

        //    };
        //    var xmlserializer = new XmlSerializer(typeof(Member));
        //    using (var writer = new StringWriter())
        //    {
        //        xmlserializer.Serialize(writer, member);
        //        var XmlContent = writer.ToString();
        //        Console.WriteLine(XmlContent);
        //    }
        //}

        //private static void SerialiseObjectToFile()
        //{

        //    var member = new Member
        //    {
        //        Name = "sunny",
        //        Email = "sunny@gmail.com",
        //        Age = 24,
        //        JoiningDate = DateTime.Now,
        //        IsPlatinumMember = false,

        //    };
        //    var xmlserializer = new XmlSerializer(typeof(Member));
        //    using (var writer = new StreamWriter(@"C:\Users\Admin\source\repos\XmlDemo\XmlDemo.txt"))
        //    {
        //        xmlserializer.Serialize(writer, member);

        //        Console.WriteLine("Process completed");
        //    }
        //}
        //private static void SerialiseListToFile()
        //{

        //    var memberList = new List<Member>
        //    {
        //            new Member
        //    {
        //        Name = "sunny",
        //        Email = "sunny@gmail.com",
        //        Age = 24,
        //        JoiningDate = DateTime.Now,
        //        IsPlatinumMember = true,

        //    },
        //    new Member
        //    { Name = "bunny",
        //        Email = "bunny@gmail.com",
        //        Age = 24,
        //        JoiningDate = DateTime.Now,
        //        IsPlatinumMember = true,
        //    },
        //    new Member
        //    { Name = "monny",
        //        Email = "monny@gmail.com",
        //        Age = 20,
        //        JoiningDate = DateTime.Now,
        //        IsPlatinumMember = false
        //    },
        //     new Member
        //    { Name = "Ramnesh",
        //        Email = "Ramesh@gmail.com",
        //        Age = 20,
        //        JoiningDate = DateTime.Now,
        //        IsPlatinumMember = true
        //    }
        //    };


        //    var xmlserializer = new XmlSerializer(typeof(LKIUAirAvailRS>));
        //    using (var writer = new StreamWriter(@"C:\Users\Admin\source\repos\XmlDemo\XmlDemo1.txt"))
        //    {
        //        xmlserializer.Serialize(writer, memberList);

        //        Console.WriteLine("Process completed");
        //    }
        //}

        private static void DSerializeXmlFileToList()
        {
            var XmlSerialize = new XmlSerializer(typeof(KIUAirAvailRS));
            using (var Reader = new StreamReader(@"C:\Users\Admin\source\repos\XmlDemo\XmlDemo1.txt"))
            { 
                var members =(KIUAirAvailRS)XmlSerialize.Deserialize(Reader);

            }
        }
    }
}
