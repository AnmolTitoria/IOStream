using System;
using System.IO;

namespace IOStream
{
    internal class Program
    {
// Edit from gitgub
        static void Main(string[] args)

        {
            Write();
            Read();
        }

        public static void Write()
        {
            StreamWriter SW = new StreamWriter(@"D:\Max 2\Demo.txt");
            SW.WriteLine("IO Stream Implementation");
            SW.Close();

        }

        public static void Read()
        {
            StreamReader RW = new StreamReader(@"D:\Max 2\Demo.txt");
            Console.WriteLine(RW.ReadToEnd());
            RW.Close();

            var files = Directory.GetFiles(@"D:\Max 2\", "*.*", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
               // Console.WriteLine(file);
               Console.WriteLine(Path.GetFileName(file));
            }

            string DirPath = @"D:\Max 2\Day2";
            bool DirSta = Directory.Exists(DirPath);

            if (DirSta)
            {
                Console.WriteLine("Yes Exist");
            }
            else
            {
                Console.WriteLine("Does not exixt");
                Directory.CreateDirectory(DirPath);
            }

        }
    }


}
