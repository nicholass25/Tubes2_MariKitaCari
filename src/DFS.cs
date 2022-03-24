using System.Collections.Generic;
using System.IO;

namespace MariKitaCari
{
    public class DFS
    {
        public string Namafile { get; set; } = string.Empty;
        public bool found;
        public bool all_occur;
        public Queue<Folder> urutan = new Queue<Folder>();

        public DFS(string nama, bool all_occur)
        {
            Namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }

        public void DFS_Start(string dirpath)
        {
            this.DFS_Search(new DirectoryInfo(dirpath));
        }
        public void DFS_Search(DirectoryInfo dir)
        {
            string[] files = Directory.GetFiles(dir.FullName, "*.*");
            if (urutan.Count == 0)
                urutan.Enqueue(new Folder("", dir.FullName));

            foreach (string file in files)
            {
                urutan.Enqueue(new Folder(dir.FullName, file));
                // if (found == false)
                // {
                //     if (Path.GetFileName(file) == Namafile)
                //     {
                //         if (all_occur == false)
                //         {
                //             // System.Environment.Exit(0);
                //         }
                //     }
                //     else
                //     {
                //         //
                //     }
                // }
            }

            DirectoryInfo[] children = dir.GetDirectories();
            if (found == false)
            {
                foreach (DirectoryInfo child in children)
                {
                    urutan.Enqueue(new Folder(dir.FullName, child.FullName));
                    this.DFS_Search(child);
                }
            }
        }
    }
}

