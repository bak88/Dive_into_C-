using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace lecture11._2_Json
{
    public class Person
    {
        public string SomeField = "somefield";

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"name={Name}, surname={Surname}, age={Age}";
        }
    }

    public class Person2
    {
        public readonly string SomeField = "somefield";

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"name={Name}, surname={Surname}, age={Age}";
        }
    }

    public class Numbers
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Num3 { get; set; }

        public override string ToString()
        {
            return $"num1={Num1}, num2={Num2}, num3={Num3}";
        }
    }

    public class Numbers2
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Num3 { get; set; }

        public override string ToString()
        {
            return $"num1={Num1}, num2={Num2}, num3={Num3}";
        }
    }

    public class NumAndStr
    {
        [JsonIgnore]
        public int Num1 { get; set; }
        [JsonRequired]
        public string Str2 { get; set; }

        public override string ToString()
        {
            return $"num1={Num1}, str2={Str2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person { Name = "Jack", Surname = "Johns", Age = 30 };
            //string json = JsonSerializer.Serialize(person);
            //Console.WriteLine(json);




            //string json = """{"Name":"Jack","Surname":"Johns","Age":30}""";
            //Person? person = JsonSerializer.Deserialize<Person>(json);
            //Console.WriteLine(person);




            //Person person = new Person { Name = "Jack", Surname = "Johns", Age = 30 };

            //using (var stream = new MemoryStream())
            //{
            //    JsonSerializer.Serialize(stream, person, typeof(Person));
            //    string json = Encoding.UTF8.GetString(stream.ToArray());
            //    Console.WriteLine(json);

            //}




            //string json = """{"Name":"Jack","Surname":"Johns","Age":30}""";
            //using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            //{
            //    var person = (Person?)JsonSerializer.Deserialize(stream, typeof(Person));
            //    Console.WriteLine(person);
            //}






            //Person person = new Person { Name = "Jack", Surname = "Johns", Age = 30 };

            //string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { IncludeFields = true });
            //Console.WriteLine(json);
            //Console.WriteLine(JsonSerializer.Serialize(person, new JsonSerializerOptions() { IncludeFields = false}));






            //Person2 person = new Person2 { Name = "Jack", Surname = "Johns", Age = 30 };

            //string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { IncludeFields = true, IgnoreReadOnlyFields = true });
            //Console.WriteLine(json);
            //Console.WriteLine(JsonSerializer.Serialize(person, new JsonSerializerOptions { IncludeFields = true }));






            //string json = """{"Num1":"NaN","Num2":"-Infinity","Num3":"Infinity"}""";

            //Console.WriteLine(JsonSerializer.Deserialize<Numbers>(json,
            //    new JsonSerializerOptions { NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals }));





            //string json = """{"Num1":"1","Num2":"2","Num3":"3"}""";

            //Console.WriteLine(JsonSerializer.Deserialize(json, 
            //    typeof(Numbers2),
            //    new JsonSerializerOptions { NumberHandling = JsonNumberHandling.AllowReadingFromString}));




            //Person person = new Person { Name = "Jack", Surname = "Johns", Age = 30 };

            //Console.WriteLine(JsonSerializer.Serialize(person, 
            //    new JsonSerializerOptions { WriteIndented = true}));

            //Console.WriteLine(JsonSerializer.Serialize(person, 
            //    new JsonSerializerOptions { WriteIndented = false}));



            //string json = """{"Nim1":"1"}""";

            //Console.WriteLine(JsonSerializer.Deserialize<NumAndStr>(json,
            //    new JsonSerializerOptions { NumberHandling = JsonNumberHandling.AllowReadingFromString}));




            //NumAndStr numAndStr = new NumAndStr() { Num1 = 4, Str2 = "str" };
            //Console.WriteLine(JsonSerializer.Serialize(numAndStr));




        }
    }
}
