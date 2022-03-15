using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            DFS_start(@"D:\Bahasa_C");
        }
        static void DFS_start(string dirpath)
        {
            DFS(new DirectoryInfo(dirpath));
        }
        static void DFS(DirectoryInfo dir)
        {
            Console.WriteLine(dir.FullName);

            string[] files = Directory.GetFiles(dir.FullName,"*.*");
            foreach(string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            DirectoryInfo[] children = dir.GetDirectories();
            foreach(DirectoryInfo child in children)
            {
                DFS(child);
            }
        }
    }

}