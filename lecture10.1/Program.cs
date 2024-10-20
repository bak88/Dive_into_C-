using System.IO;
using System.Text;

namespace lecture10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string currentDir = Directory.GetCurrentDirectory();
            //DirectoryInfo parentDir = Directory.GetParent(currentDir);

            //Console.WriteLine("Current dir is " + currentDir);
            //Console.WriteLine("Parent dir is " + parentDir);




            //DirectoryInfo? prjRoot = GetProjectRoot();
            //if (prjRoot == null)
            //{
            //    Console.WriteLine("Не могу найти каталог проекта");
            //    return;
            //}
            //Console.WriteLine(prjRoot);

            //foreach(FileInfo fi in prjRoot.EnumerateFiles())
            //{
            //    Console.WriteLine(fi.Name);
            //}





            //DirectoryInfo? prjRoot = GetProjectRoot();
            //if (prjRoot == null)
            //{
            //    Console.WriteLine("Не могу найти каталог проекта");
            //    return;
            //}
            //Console.WriteLine(prjRoot +" "+ ContainsExtensions(prjRoot, new string[] {".cs", ".csproj"}));
            //Console.WriteLine(prjRoot +" "+ ContainsExtensions(prjRoot, new string[] {".txt", ".html"}));





            //DirectoryInfo? prjRoot = GetProjectRoot();
            //if (prjRoot == null)
            //{
            //    Console.WriteLine("Не могу найти каталог проекта");
            //    return;
            //}

            //DrawDirectoryInfo(prjRoot);





            //DirectoryInfo? prjRoot = GetProjectRoot();
            //if (prjRoot == null)
            //{
            //    Console.WriteLine("Не могу найти каталог проекта");
            //    return;
            //}

            //var pathToProgram = Path.Combine(prjRoot.FullName, "Program.cs");

            //if(!Path.Exists(pathToProgram))
            //{
            //    Console.WriteLine(pathToProgram + "not find");
            //}

            //using (var fStream = new FileStream(pathToProgram, FileMode.Open))
            //{
            //    long length = fStream.Length;
            //    byte[] bytes = new byte[length];
            //    var read = fStream.Read(bytes, 0, bytes.Length);

            //    if (read == length)
            //    {
            //        var str = Encoding.Default.GetString(bytes);
            //        Console.WriteLine(str);
            //    }
            //}




            DirectoryInfo? prjRoot = GetProjectRoot();
            if (prjRoot == null)
            {
                Console.WriteLine("Не могу найти каталог проекта");
                return;
            }

            var pathToProgram = Path.Combine(prjRoot.FullName, "Program.cs");

            if (!Path.Exists(pathToProgram))
            {
                Console.WriteLine(pathToProgram + "not find");
            }

            using (var fStream = new FileStream(pathToProgram, FileMode.Open))
            {
                long length = fStream.Length;
                byte[] bytes = new byte[length];

                for (int i = 0; i < length; i++)
                {
                    bytes[i] = (byte)fStream.ReadByte();
                }
                var str = Encoding.Default.GetString(bytes);
                Console.WriteLine(str);
            }



        }

        static DirectoryInfo? GetProjectRoot()
        {
            Stack<string> names = new Stack<string>(new string[] { "bin", "Debug", "net8.0" });

            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo? directoryInfo = new(currentDir);

            while (names.Count > 0)
            {
                string expected = names.Pop();
                if (directoryInfo?.Name == expected)
                {
                    directoryInfo = directoryInfo.Parent;
                }
                else
                    return null;
            }
            return directoryInfo;
        }
        static bool ContainsExtensions(DirectoryInfo dir, string[] extensions)
        {
            HashSet<string> set = new HashSet<string>(extensions);

            foreach (FileInfo fi in dir.EnumerateFiles())
            {
                if (set.Contains(fi.Extension))
                {
                    set.Remove(fi.Extension);
                }
            }
            return set.Count == 0;
        }
        static void DrawDirectoryInfo(DirectoryInfo dir)
        {
            foreach (var d in dir.GetDirectories())
            {
                Console.WriteLine(d.Name.PadRight(50, ' ') + CalculateDirectorySize(d));
            }

            foreach (var f in dir.GetFiles())
            {
                Console.WriteLine(f.Name.PadRight(50, ' ') + f.Length);
            }

        }
        static long CalculateDirectorySize(DirectoryInfo dir)
        {
            long length = 0;

            foreach (var item in dir.GetFiles())
            {
                length += item.Length;
            }

            foreach (var item in dir.GetDirectories())
            {
                length += CalculateDirectorySize(item);
            }
            return length;
        }
    }
}
