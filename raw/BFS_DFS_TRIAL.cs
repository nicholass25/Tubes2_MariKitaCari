using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


/* README
 * Jadi program ini niatnya cmn buat ngehasilin urutan pengecekannya
 * klo buat pencarian file, niat nya bikin class baru lagi
 * itu class file_folder buat nyimpen
 
 
 
 
 
 */


namespace Testing
{
    public class file_folder
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

        public void setvalue(string parent,string direct)
        {
            this.parent = parent;
            this.direct = direct;
        }
    }
    
    
    class file : file_folder
    {
        public string namafile { get; set; } = string.Empty;
        public bool found;
        public bool all_occur;
        public Queue<file_folder> urutan = new Queue<file_folder>();

        public file(string nama, bool all_occur)
        {
            namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }

        public void DFS_start(string dirpath)
        {
            this.DFS(new DirectoryInfo(dirpath));
        }
        public void DFS(DirectoryInfo dir)
        {
            //Console.WriteLine(Path.GetFileName(dir.FullName)); // get just the name of folder
            //Console.WriteLine(dir.FullName); // get the full path of the folder
            string[] files = Directory.GetFiles(dir.FullName,"*.*");
            if (urutan.Count == 0)
                urutan.Enqueue(new file_folder("", dir.FullName));

            foreach(string file in files)
            {
                //Console.WriteLine(file);
                urutan.Enqueue(new file_folder(dir.FullName, file));
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
                    //Console.WriteLine(child.FullName);
                    urutan.Enqueue(new file_folder(dir.FullName, child.FullName));
                    this.DFS(child);
                }
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
        public Queue<file_folder> bfs_show = new Queue<file_folder>(); // Queue buat output (jaga jagabuat di graph)

        public file_bfs(string nama, bool all_occur)
        {
            namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }

        public void BFS(string dirpath)
        {
            Queue<string> dir_visited = new Queue<string>(); // Queue buat alur bfs

            
            //dir_visited.Enqueue(dirpath);
            string[] folder = Directory.GetDirectories(dirpath, "*", SearchOption.TopDirectoryOnly);

            bfs_show.Enqueue(new file_folder("", dirpath));

            foreach(string fold in folder)
            {
                //Console.WriteLine(fold);
                dir_visited.Enqueue(fold);
                bfs_show.Enqueue(new file_folder(dirpath, fold));
            }

            string[] files = Directory.GetFiles(dirpath, "*.*",SearchOption.TopDirectoryOnly);
            foreach(string file in files)
            {
                //Console.WriteLine(file);
                dir_visited.Enqueue(file);
                bfs_show.Enqueue(new file_folder(dirpath, file));
            }

            while (dir_visited.Count > 0)
            {
                string now = dir_visited.Dequeue();
                //Console.WriteLine(now);
                FileAttributes trib = File.GetAttributes(now);


                if (trib.HasFlag(FileAttributes.Directory)) // its a folder
                {
                    string[] fold = Directory.GetDirectories(now, "*", SearchOption.TopDirectoryOnly);
                    foreach(string fd in fold)
                    {
                        dir_visited.Enqueue(fd);
                        //Console.WriteLine(fd);
                        bfs_show.Enqueue(new file_folder(now, fd));
                    }
                    string[] files_child = Directory.GetFiles(now, "*.*", SearchOption.TopDirectoryOnly);
                    foreach(string file in files_child)
                    {
                        dir_visited.Enqueue(file);
                        //Console.WriteLine(file);
                        bfs_show.Enqueue(new file_folder(now, file));
                    }
                }
                else // its a file
                {
                    if (found == false)
                    {
                        if (Path.GetFileName(now) == namafile)
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

            file_bfs fl2 = new file_bfs(nama, temu);
            file fl = new file(nama, temu);

            fl.DFS_start(@"D:\for_testing");
            //fl.BFS(@"D:\for_testing");

            //fl.show_queue();

            // Bfs Testing
/*            foreach (file_folder ok in fl.bfs_show)
            {
                Console.WriteLine(ok.direct);
                Console.WriteLine(ok.parent);
            }*/

            //DFS Testing
            foreach(file_folder ok in fl.urutan)
            {
                Console.WriteLine(ok.direct);
            }
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

