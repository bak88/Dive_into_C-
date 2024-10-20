using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace test2
{
    public class SomeClass
    {
        private int field1 = 10;
        private int field2 = 20;
        public int field3 = 40;
        public int field4 = 40;
    }

    internal class Program
    {      
        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(SomeClass));
            var obj = new SomeClass();
            serializer.Serialize(Console.Out, obj);


        }


        private static void WriteTo(string str, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(str);

                }
            }
        }

        private static string ReaderFrom(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }

    }
}
