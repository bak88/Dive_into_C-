using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;


namespace dz11
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public Child[] Children { get; set; }

        public override string ToString()
        {
            return $"name={Name}, age={Age}, married={IsMarried}, children={Children}";
        }
    }

    public class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = @"{
            ""Name"": ""John"",
            ""Age"": 30,
            ""IsMarried"": true,
            ""Children"": [
                             {
                                ""Name"": ""Anna"",
                                ""Age"": 10
                             },
                             { 
                                ""Name"": ""Ben"",
                                ""Age"": 8
                             }
                           ]
            }";

            Person? person = JsonToPerson(jsonString);
            var serialize = new XmlSerializer(person.GetType());
            serialize.Serialize(Console.Out, person);



            Person JsonToPerson(string jsonString)
            {
                string name;
                int age;
                bool isMarried;
                Child[] children;

                using (JsonDocument doc = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = doc.RootElement;
                    name = root.GetProperty("Name").GetString();
                    age = root.GetProperty("Age").GetInt32();
                    isMarried = root.GetProperty("IsMarried").GetBoolean();

                    JsonElement childrenEl = root.GetProperty("Children");
                    children = new Child[childrenEl.GetArrayLength()];
                    int i = 0;
                    foreach (var child in childrenEl.EnumerateArray())
                    {
                        string childName = child.GetProperty("Name").GetString();
                        int childAge = child.GetProperty("Age").GetInt32();
                        children[i++] = new Child { Name = childName, Age = childAge };
                    }

                }
                Person person = new Person()
                {
                    Name = name,
                    Age = age,
                    IsMarried = isMarried,
                    Children = children
                };

                return person;
            }
        }
    }
}
