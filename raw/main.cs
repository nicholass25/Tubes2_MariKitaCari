using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Folder;
using BFS_find;
using DFS_find;

namespace Main
{
    class program
    {
        public static void Main(String[] args)
        {
            //Inisialisasi
            bool found = false;
            string? Name, Parent, Option, Algorithm;

            //Input nama DFS
            Console.WriteLine("Masukkan nama file yang ingin dicari : ");
            Name = Console.ReadLine();
            while (Name is null)
            {
                Name = Console.ReadLine();
            }

            //Input nama parent
            Console.WriteLine("\nMasukkan nama parent yang ingin digunakan : ");
            Parent = Console.ReadLine();
            while (Parent is null)
            {
                Parent = Console.ReadLine();
            }

            //Input option occurance atau tidak
            Console.WriteLine("\nPencarian Semua kemunculan ? (Y/N) ");
            //Input Option (Y/N)
            Option = Console.ReadLine();
            if (Option == "Y")
            {
                found = true;
            }

            else if (Option == "N")
            {
                found = false;
            }

            //Input option BFS atau DFS
            Console.WriteLine("\nPencarian BFS atau DFS ? (BFS/DFS) ");
            //Input Option (BFS/DFS)
            Algorithm = Console.ReadLine();
            if (Algorithm == "BFS")
            {
                BFS f = new BFS(Name, found);
                f.BFS_search(Parent);
                Console.WriteLine(Parent);
                //Munculin di layar
                foreach (folder ok in f.BFS_show)
                {
                    Console.WriteLine(ok.direct);
                    // Console.WriteLine(ok.parent);
                }

            }
            else if (Algorithm == "DFS")
            {
                DFS f = new DFS(Name, found);
                f.DFS_start(Parent);
                //Munculin di layar
                foreach (folder ok in f.urutan)
                {
                    Console.WriteLine(ok.direct);
                    // Console.WriteLine(ok.parent);
                }
            }
            else
            {
                Console.WriteLine("error!");
            }
            // BFS fl2 = new BFS(Name, found);
            // DFS fl = new DFS(Name, found);

            // fl.DFS_start(@"D:\for_testing");
            // fl.BFS(@"D:\for_testing");



            //fl.show_queue();

            // Bfs Testing
            /*            foreach (DFS_folder ok in fl.bfs_show)
                        {
                            Console.WriteLine(ok.direct);
                            Console.WriteLine(ok.parent);
                        }*/

            //DFS Testing
            // foreach (folder ok in fl.urutan)
            // {
            //     Console.WriteLine(ok.direct);
            // }
        }
    }



    // class Program
    // {
    //     public static void Main(String[] args)
    //     {
    //         bool temu;
    //         string? nama, opsi;

    //         Console.WriteLine("Masukkan nama DFS yang ingin dicari : ");
    //         nama = Console.ReadLine();
    //         while (nama is null)
    //         {
    //             nama = Console.ReadLine();
    //         }

    //         Console.WriteLine("\nPencarian Semua kemunculan ? (Y/N) "); //buat sementara sebelum ada GUI :"s
    //         opsi = Console.ReadLine();
    //         if (opsi == "Y")
    //             temu = true;
    //         else
    //             temu = false;

    //         BFS fl2 = new BFS(nama, temu);
    //         DFS fl = new DFS(nama, temu);

    //         fl.DFS_start(@"D:\Games");
    //         //fl.BFS(@"D:\for_testing");

    //         // fl.show_queue();

    //         // Bfs Testing
    //         /*            foreach (DFS_folder ok in fl.bfs_show)
    //                     {
    //                         Console.WriteLine(ok.direct);
    //                         Console.WriteLine(ok.parent);
    //                     }*/

    //         //DFS Testing
    //         foreach (folder ok in fl.urutan)
    //         {
    //             Console.WriteLine(ok.direct);
    //         }
    //     }
    // }
}