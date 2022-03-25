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
            bool temu;
            string nama, opsi;

            Console.WriteLine("Masukkan nama DFS yang ingin dicari : ");
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

            BFS fl2 = new BFS(nama, temu);
            DFS fl = new DFS(nama, temu);

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
            foreach (folder ok in fl.urutan)
            {
                Console.WriteLine(ok.direct);
            }
        }
    }
}