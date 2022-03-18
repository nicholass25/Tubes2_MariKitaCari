using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Testing
{
    class file_folder
    {
        public string parent;
        public string direct;

        public file_folder()
        {
            this.parent = "";
            this.direct = "";
        }

        public file_folder(string parent,string direct)
        {
            this.parent = parent;
            this.direct = direct;
        }

        public file_folder(file_folder fl)
        {
            this.parent = fl.parent;
            this.direct = fl.direct;
        }
    }
    
    
    class file : file_folder
    {
        public string namafile { get; set; } = string.Empty;
        public bool found;
        public bool all_occur;
        public Stack<file_folder> urutan;

        public file(string nama, bool all_occur)
        {
            namafile = nama;
            found = false;
            this.all_occur = all_occur;
            urutan = new Stack<file_folder>();
        }

        public void DFS_start(string dirpath)
        {
            this.DFS(new DirectoryInfo(dirpath));
        }
        public void DFS(DirectoryInfo dir)
        {
            //Console.WriteLine(Path.GetFileName(dir.FullName)); // get just the name of folder
            //Console.WriteLine(dir.FullName); // get the full path of the folder
            file_folder temp = new file_folder();

            string[] files = Directory.GetFiles(dir.FullName,"*.*");


            foreach(string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(dir.FullName+"\n");
                temp.direct = file;
                temp.parent = dir.FullName;
                //if(!this.urutan.Contains(temp))
                this.urutan.Push(temp);
                if (found == false)
                {
                    if (Path.GetFileName(file) == namafile)
                    {
                        //Console.WriteLine(Path.GetFileName(file) + " YEY");
                        if (all_occur == false) //opsi buat mau all occurance atau enggak
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    else
                    {
                        //Console.WriteLine(Path.GetFileName(file));
                    }
                }
            }

            DirectoryInfo[] children = dir.GetDirectories();
            if (found==false)
            {
                foreach (DirectoryInfo child in children)
                {
                    Console.WriteLine(child.FullName);
                    Console.WriteLine(dir.FullName + "\n");
                    temp.direct = child.FullName;
                    temp.parent = dir.FullName;
                    //if(!this.urutan.Contains(temp))
                    this.urutan.Push(temp);
                    this.DFS(child);
                }
            }
        }

        public void show_queue()
        {
            file_folder tempo;
            while (urutan.Count > 0)
            {
                tempo = new file_folder(this.urutan.Pop());

                Console.WriteLine(tempo.direct);
            }
        }
    }


    // BFS start disini, class lainnya ga ngaruhh
    /* BFS nya pake Queue jadi itu semua path(folder/file) di masukin queue
     * itu tinggal nyari cara bedain folder sama file aja, klo misal folder berarti isinya dibuka lagi terus child nya di enque
     * klo file di cocokin sama file yg di cari sama atau engga*/

    class file_bfs : file_folder
    {
        public string namafile { get; set; } = string.Empty;
        public bool found;
        public bool all_occur;

        public file_bfs(string nama, bool all_occur)
        {
            namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }

        public void BFS(string dirpath)
        {
            Queue<string> dir_visited = new Queue<string>();
            string[] folder = Directory.GetDirectories(dirpath, "*", SearchOption.AllDirectories);
            foreach(string fold in folder)
            {
                dir_visited.Enqueue(fold);
            }
            string[] files = Directory.GetFiles(current_directory.FullName, "*.*",SearchOption.TopDirectoryOnly);
            foreach(string file in files)
            {
                dir_visited.Enqueue(file);
            }
            while (dir_visited.Count > 0)
            {
                string now = dir_visited.Dequeue();
                
            }
        }
    }


    // klo mau nger un program panggil aja fungsi nya sama sesuaiin parameter yg dipake ajaa
    class Program
    {
        public static void Main(String[] args)
        {
            bool temu;
            string nama, opsi;

            Console.WriteLine("Masukkan nama file yang ingin dicari : ");
            nama = Console.ReadLine();
            while (nama is null)
            {
                nama = Console.ReadLine();
            }

            Console.WriteLine("\nPencarian Semua kemunculan ? (Y/N) "); //buat sementara sebelum ada GUI :"s
            opsi = Console.ReadLine();
            if (opsi == "Y")
                temu = true;
            else
                temu = false;

            file fl = new file(nama, temu);

            fl.DFS_start(@"D:\for_testing");
            //fl.BFS(@"D:\for_testing", namafile,all_occur);

            //fl.show_queue();
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

//    Console.WriteLine(current_directory.FullName);

//    DirectoryInfo[] children = current_directory.GetDirectories();
//    foreach (DirectoryInfo child in children)
//    {
//        dir_visited.Enqueue(child);
//    }

//    string[] files = Directory.GetFiles(current_directory.FullName, "*.*");
//    foreach (string file in files)
//    {
//        if (fl.found == false)
//        {
//            if (Path.GetFileName(file) == fl.namfile)
//            {
//                Console.WriteLine(file + " YEY");
//                if (fl.all_occur == false) //opsi buat mau all occurance atau enggak
//                {
//                    System.Environment.Exit(0);
//                }
//            }
//            else
//            {
//                Console.WriteLine(Path.GetFileName(file));
//            }
//        }
//    }
//}

