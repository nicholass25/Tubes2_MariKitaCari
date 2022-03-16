using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Testing
{
    class Search_File
    {
        public string namfile;
        public bool found;
        public bool all_occur;

        public Search_File(string nama,bool all_occur)
        {
            namfile = nama;
            found = false;
            this.all_occur = all_occur;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama file yang ingin dicari : ");
            string namafile = Console.ReadLine();

            Console.WriteLine("\nPencarian Semua kemunculan ? (Y/N) "); //buat sementara sebelum ada GUI :"s
            string all_occur = Console.ReadLine();

            Search_File Input1 = new Search_File(namafile,true);


            //DFS_start(@"D:\for_testing", Input1);
            BFS(@"D:\for_testing", Input1);
        }
        static void DFS_start(string dirpath,Search_File fl)
        {
            DFS(new DirectoryInfo(dirpath),fl);
        }
        static void DFS(DirectoryInfo dir,Search_File fl)
        {
            //Console.WriteLine(Path.GetFileName(dir.FullName)); // get just the name of folder
            Console.WriteLine(dir.FullName); // get the full path of the folder

            string[] files = Directory.GetFiles(dir.FullName,"*.*");

            foreach(string file in files)
            {
                if (fl.found == false)
                {
                    if (Path.GetFileName(file) == fl.namfile)
                    {
                        Console.WriteLine(Path.GetFileName(file) + " YEY");
                        if (fl.all_occur == false) //opsi buat mau all occurance atau enggak
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine(Path.GetFileName(file));
                    }
                }
            }

            DirectoryInfo[] children = dir.GetDirectories();
            if (fl.found==false)
            {
                foreach (DirectoryInfo child in children)
                {
                    DFS(child, fl);
                }
            }
        }
        static void BFS(string dir,Search_File fl)
        {

        }
    }

}

//class Program
//{
//    static void DFS(DirectoryInfo dir)
//    {

//        Console.WriteLine(dir.Name);
//        DirectoryInfo[] roots = dir.GetDirectories();

//        foreach (DirectoryInfo root in roots)
//        {
//            DFS(root);  
//        }
//    }

//    static void DFS_start(string path)
//    {
//        DFS(new DirectoryInfo(path));
//    }
//    static void Main(string[] args)
//    {
//        string rootPath = @"D:\Bahasa_C";

//        //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

//        //foreach (string dir in dirs)
//        //{
//        //    Console.WriteLine(dir);
//        //}

//        //string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

//        //foreach (string file in files)
//        //{
//        //    Console.WriteLine(file); // for showing the file with the path

//        //    //Console.WriteLine(Path.GetFileName(file)); //for showing the file just the filename with ext

//        //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file)); //for showing the filename without ext

//        //    if (Path.GetFileName(file) == "b1.txt")
//        //    {
//        //        Console.Write("success\n");
//        //    }

//        //}


//        DFS_start(rootPath);
//        Console.ReadLine();


//    }
//}


//static void DFS(string path)
//{
//    string[] files = Directory.GetFiles(path);

//    foreach (string file in files)
//    {
//        Console.WriteLine(Path.GetFileName(file));
//    }

//    var directories = Directory.GetDirectories(path);
//    foreach (var directory in directories)
//    {
//        DFS(directory);
//    }
//}
//static void Main(string[] args)
//{
//    string rootPath = @"D:\Bahasa_C";
//    DFS(rootPath);
//}



//BAWAH INI HARUSNYA BFS CMN MASIH SALAH

//Queue<DirectoryInfo> dir_visited = new Queue<DirectoryInfo>();
//dir_visited.Enqueue(new DirectoryInfo(dir));
//while (dir_visited.Count > 0)
//{
//    DirectoryInfo current_directory = dir_visited.Dequeue();
//    string[] files = Directory.GetFiles(current_directory.FullName, "*.*", SearchOption.TopDirectoryOnly);

//    Console.WriteLine(current_directory.FullName);
//    //foreach (string file in files)
//    //{
//    //    if (fl.found == false)
//    //    {
//    //        if (Path.GetFileName(file) == fl.namfile)
//    //        {
//    //            Console.WriteLine(Path.GetFileName(file) + " YEY");
//    //            if (fl.all_occur == false) //opsi buat mau all occurance atau enggak
//    //            {
//    //                System.Environment.Exit(0);
//    //            }
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine(Path.GetFileName(file));
//    //        }
//    //    }
//    //}

//    DirectoryInfo[] children = current_directory.GetDirectories();
//    foreach (DirectoryInfo child in children)
//    {
//        dir_visited.Enqueue(child);
//    }
//}