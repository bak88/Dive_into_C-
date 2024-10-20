using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace lecture11._1
{
    public class SomeClass
    {
        private int _field1 = 10;
        private int _field2 = 20;
        public int Field3 = 30;
        public int Field4 = 40;
    }

    public class Person
    {
        public string Name = "Jack";
        public string Surname = "Vorobei";
        public int Age = 33;
        public object[] Details;
    }

    [XmlType("XmlPerson2")]
    public class Person2
    {
        public string Name = "Jack";
        [XmlElement("FamilyName")]
        public string Surname = "Vorobei";
        public int Age = 33;


        public override string ToString()
        {
            return $"name = {Name}, surname = {Surname}, age = {Age}";
        }
    }
    [XmlType("XmlAnotherPerson2")]
    public class AnotherPerson2 : Person2 { };

    public class Group
    {
        [XmlElement(typeof(Person2))]
        [XmlElement(typeof(AnotherPerson2))]

        public object[] People;

    }

    [XmlType("XmlPerson3")]
    public class Person3
    {
        [XmlAttribute]
        public string Name = "Jack";
        [XmlAttribute("FamilyName")]
        public string Surname = "Vorobei";
        public int Age = 33;


        public override string ToString()
        {
            return $"name = {Name}, surname = {Surname}, age = {Age}";
        }
    }

    [XmlType("XmlPerson4")]
    public class Person4
    {

        public string Name = "Jack";
        public string Surname = "Vorobei";
        public int Age = 33;

        [XmlAnyElement]
        public XmlElement[] AllElement;

        [XmlAnyAttribute]
        public XmlAttribute[] AllAttributes;

        public override string ToString()
        {
            return $"name = {Name}, surname = {Surname}, age = {Age}";
        }
    }
    public class Person5
    {

        public string Name = "Jack";
        public string Surname = "Vorobei";
        [XmlIgnore]
        public int Age = 33;
        [XmlArray("HobbiesList")]
        [XmlArrayItem("Hobby")]
        public Hobby[] Hobbies;        

        public override string ToString()
        {
            return $"name = {Name}, surname = {Surname}, age = {Age}";
        }
    }

    public enum Hobby
    {
        [XmlEnum("Art")]
        Painting,
        [XmlEnum("Hunt")]
        Fishing,
        Sport
    }


    public class Address
    {
        public string Street;
        public int Building;
    }

    public class Phone
    {
        public string Home;
        public string Work;

    }

    public class MySettings
    {
        public string Setting1 = "";
        public string Setting2 = "";
        public string Setting3 = "";

        public override string ToString()
        {
            return $"set1 = {Setting1}, set2 = {Setting2}, set3 = {Setting3} ";
        }
    }

    internal class Program
    {
        static MySettings? LoadSettings()
        {
            var ser = new XmlSerializer(typeof(MySettings));

            if (Path.Exists("mySetting.xml"))
            {
                using (var stream = File.OpenRead("mySetting.xml"))
                {
                    return (MySettings?)ser.Deserialize(stream);
                }
            }
            return null;
        }

        static void SaveSettings(MySettings settings)
        {
            var ser = new XmlSerializer(settings.GetType());

            using (var stream = File.OpenWrite("mySetting.xml"))
            {
                ser.Serialize(stream, settings);
            }
        }

        static MySettings? LoadSettings2(string settings)
        {
            var ser = new XmlSerializer(typeof(MySettings));

            using (var stream = new StringReader(settings))
            {
                return (MySettings?)ser.Deserialize(stream);
            }
        }

        static string SaveSettings2(MySettings settings)
        {
            var ser = new XmlSerializer(settings.GetType());

            using (var writer = new StringWriter())
            {
                ser.Serialize(writer, settings);
                return writer.ToString();
            }

        }

        static MySettings? LoadSettings3()
        {
            var ser = new XmlSerializer(typeof(MySettings));

            using (var reader = XmlReader.Create("mySettings2.xml"))
            {
                return (MySettings?)ser.Deserialize(reader);
            }
        }

        static void SaveSettings3(MySettings settings)
        {
            var ser = new XmlSerializer(settings.GetType());

            using (var writer = XmlWriter.Create("mySettings2.xml"))
            {
                ser.Serialize(writer, settings);
            }
        }



        static void Main(string[] args)
        {
            //var serializer = new XmlSerializer(typeof(SomeClass));

            //var obj = new SomeClass(); 
            //serializer.Serialize(Console.Out, obj);








            //var xml = """
            //    <SomeClass >                     
            //    </SomeClass>
            //    """;

            //var serializer = new XmlSerializer(typeof(SomeClass));

            //var obj = (SomeClass?)serializer.Deserialize(new StringReader(xml));

            //Console.WriteLine(obj.Field3);
            //Console.WriteLine(obj.Field4);







            //var person = new Person()
            //{
            //    Name = "Jack",
            //    Surname = "Vorobei",
            //    Age = 30,
            //    Details = new object[]
            //    {
            //        new Address() { Street = "Street", Building = 13},
            //        new Phone { Home = "123234", Work = "qwe13321"},

            //    }
            //};

            //List<Type> types = new List<Type>();
            //foreach (var item in person.Details)
            //{
            //    types.Add(item.GetType());
            //}

            //var serializer = new XmlSerializer(typeof(Person), types.ToArray());

            //serializer.Serialize(Console.Out, person);






            //var person = new Person()
            //{
            //    Name = "Jack",
            //    Surname = "Vorobei",
            //    Age = 30,

            //};

            //XmlRootAttribute root = new XmlRootAttribute();
            //root.ElementName = "Someone";
            //root.Namespace = "NameSpace";
            //root.IsNullable = true;

            //var ser = new XmlSerializer(typeof(Person), root);

            //ser.Serialize(Console.Out, person);






            //string xml =
            //    """
            //    <Person>
            //        <Name>Jack</Name>
            //        <Surname>Vorobei</Surname>
            //        <Age>30</Age>
            //    </Person>
            //    """;

            //var ser = new XmlSerializer(typeof(Person));
            //XmlReader xmlReader = XmlReader.Create(new StringReader(xml));

            //Console.WriteLine(ser.CanDeserialize(xmlReader));








            //var ser = XmlSerializer.FromTypes(new Type[] { typeof(Person) });

            //if ( ser.Length != 0)
            //{
            //    ser[0]?.Serialize(Console.Out, new Person());
            //}






            //var setting = LoadSettings();

            //if (setting == null)
            //{
            //    Console.WriteLine("Setting created");
            //    setting = new MySettings { Setting1 = "Setting1", Setting2 = "Setting2", Setting3 = "Setting3" };
            //    SaveSettings(setting);
            //}
            //else
            //{
            //    Console.WriteLine("Setting loaded");
            //}

            //Console.WriteLine(setting.ToString());






            //var settings = new MySettings { Setting1 = "sett1", Setting2 = "sett2", Setting3 = "sett3" };
            //var str = SaveSettings2(settings);
            //Console.WriteLine("Setting created");
            //var settings1 = LoadSettings2(str);
            //Console.WriteLine(settings1?.ToString());






            //MySettings? settings = LoadSettings3();

            //if (settings == null)
            //{
            //    settings = new MySettings { Setting1 = "sett1", Setting2 = "sett2", Setting3 = "sett3" };
            //    Console.WriteLine("Setting created");
            //}
            //else
            //{
            //    Console.WriteLine("Settings loaded");
            //}

            //Console.WriteLine(settings.ToString());
            //SaveSettings3(settings);
            //Console.WriteLine("Settings saved");







            //using (var reader = XmlReader.Create("mySetting.xml"))
            //{
            //    while (reader.Read())
            //    {
            //        if (reader.IsStartElement())
            //        {
            //            Console.Write("<");
            //            Console.Write(reader.Name);
            //            Console.WriteLine(">");
            //        }
            //        else if (reader.NodeType == XmlNodeType.EndElement)
            //        {
            //            Console.Write("</");
            //            Console.Write(reader.Name);
            //            Console.WriteLine(">");

            //        }
            //        else
            //        {
            //            Console.WriteLine(reader.Value);
            //        }
            //    }
            //}







            //int[] array = new[] {1, 2, 3, 4, 5};

            //var setting = new XmlWriterSettings()
            //{
            //    Indent = true,
            //    IndentChars = "   "
            //};

            //using(var writer = XmlWriter.Create("array.xml", setting))
            //{
            //    writer.WriteStartElement("arr");
            //    foreach(var i in array)
            //    {
            //        writer.WriteStartElement("elem");
            //        writer.WriteValue(i);
            //        writer.WriteEndElement();
            //    }
            //    writer.WriteEndElement();
            //}





            //var ser = new XmlSerializer(typeof(Person2));

            //Person2 person = new Person2()
            //{
            //    Name = "Bob",
            //    Surname = "Bober",
            //    Age = 34
            //};

            //using (var writer = new StringWriter())
            //{
            //    ser.Serialize(writer, person);
            //    Console.WriteLine(writer);
            //}






            //var xml = """
            //    <?xml version="1.0" encoding="utf-16"?>
            //    <Person2 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            //      <Name>Bob</Name>
            //      <FamilyName>Bober</FamilyName>
            //      <Age>34</Age>
            //    </Person2>
            //    """;

            //var ser = new XmlSerializer(typeof(Person2));

            //using (var strReader = new StringReader(xml))
            //{
            //    Person2 person2 = (Person2)ser.Deserialize(strReader);
            //    Console.WriteLine(person2);
            //}




            //var ser = new XmlSerializer(typeof(Person2));

            //Person2 person = new Person2()
            //{
            //    Name = "Bob",
            //    Surname = "Bober",
            //    Age = 34
            //};

            //ser.Serialize(Console.Out, person);





            //var ser = new XmlSerializer(typeof(Group));

            //Person2 person = new Person2()
            //{
            //    Name = "Bob",
            //    Surname = "Bober",
            //    Age = 34
            //};

            //AnotherPerson2 anotherPerson2 = new AnotherPerson2()
            //{
            //    Name = "Jack",
            //    Surname = "Vorobei",
            //    Age = 40
            //};

            //Group group = new Group()
            //{ People = new object[] { person, anotherPerson2 } };

            //ser.Serialize(Console.Out, group);







            //var ser = new XmlSerializer(typeof(Person3));

            //Person3 person = new Person3()
            //{
            //    Name = "Bob",
            //    Surname = "Bober",
            //    Age = 34
            //};

            //ser.Serialize(Console.Out, person);




            //string xml =
            //            """
            //            <XmlPerson4 dafdadfadada="fwffsfsfsfews">
            //                <Name>jack</Name>
            //                <Surname>vorobei</Surname>
            //                <partonomicName>alex</partonomicName>
            //                <Age>30</Age>
            //            </XmlPerson4>
            //            """;

            //XmlSerializer ser = new XmlSerializer(typeof(Person4));

            //using (var strReader = new StringReader(xml))
            //{
            //    var person = (Person4?)ser.Deserialize(strReader);

            //    if(person != null)
            //    {
            //        foreach (var item in person.AllElement)
            //        {
            //            Console.WriteLine(item.Name);
            //            Console.WriteLine(item.InnerText);
            //        }
            //        Console.WriteLine();
            //        foreach(var item in person.AllAttributes)
            //        {
            //            Console.WriteLine(item.Name);
            //            Console.WriteLine(item.InnerText);
            //        }
            //    }
            //}



            var ser = new XmlSerializer(typeof(Person5));

            Person5 person = new Person5() 
            { 
                Name = "Bob",
                Surname = "Bober",
                Age = 34,
                Hobbies = new Hobby[] { Hobby.Painting, Hobby.Sport }
                
            };

            ser.Serialize(Console.Out, person);
        }
    }
}


