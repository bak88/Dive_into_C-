using System.Xml.Serialization;

namespace seminar11._1
{
    [XmlRoot("Data.Root")]
    public class DataRoot
    {
        [XmlArray("Data.Root.Names")]
        [XmlArrayItem("Name")]
        public string[] Names;

        [XmlElement("Data.Entry")]
        public DataEntry Entry;

        [XmlElement("Data#ExtendedEntry")]
        public DataX X;

    }

    
    public class DataEntry
    {
        [XmlAttribute]
        public string LinkedEntry;
        [XmlElement("Data.Name")]
        public string Name;
    }

    [XmlType()]
    public class DataX
    {
        [XmlElement("Data.Name")]
        public string Name;
        [XmlElement("Data#Extended")]
        public string DataEx;
        [XmlAttribute]
        public string LinkedEntry;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var xml = """
                <?xml version="1.0" encoding="utf=8"?>
                <Data.Root>
                  <Data.Root.Names>
                    <Name>Name1</Name>
                    <Name>Name2</Name>
                    <Name>Name3</Name>
                  </Data.Root.Names>
                  <Data.Entry LinkedEntry="Name1">
                    <Data.Name>Name2</Data.Name>
                  <Data.Entry>
                  <Data_x0023_ExtendedEntry LinkedEntry="Name2">
                    <Data.Name>Name1</Data.Name>
                    <Data_x0023_Extended>NameOne</Data_x0023_Extended>
                  </Data_x0023_ExtendedEntry>
                <Data.Root>
                """;

            var dataRoot = new DataRoot() 
            { Names = new string[] { "Name1", "Name2", "Name3" },

              Entry = new DataEntry
                {
                    LinkedEntry = "Name1",
                    Name = "Name2"
                },
              X = new DataX
                {
                    Name= "Name1",
                    DataEx = "NameOne",
                    LinkedEntry = "Name2"
                }
            };

            var ser = new XmlSerializer(dataRoot.GetType());

            

            ser.Serialize(Console.Out, dataRoot);

        }
    }
}
