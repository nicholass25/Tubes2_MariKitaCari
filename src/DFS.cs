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
        public Queue<string> solution = new Queue<string>();
        public Queue<string> jalur = new Queue<string>();

        public DFS(string nama, bool all_occur)
        {
            Namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }
        public int substring(string sub, string main)
        {
            int M = sub.Length;
            int N = main.Length;

            /* A loop to slide pat[] one by one */
            for (int i = 0; i <= N - M; i++)
            {
                int j;

                /* For current index i, check for
                pattern match */
                for (j = 0; j < M; j++)
                    if (main[i + j] != sub[j])
                        break;

                if (j == M)
                    return i;
            }

            return -1;
        }

        public void DFS_Start(string dirpath)
        {
            this.DFS_Search(new DirectoryInfo(dirpath));
            foreach (string sol in this.solution)
            {
                foreach (file_folder ok in this.urutan)
                {
                    int coba = this.substring(ok.direct, sol);
                    if (coba != -1)
                    {
                        this.jalur.Enqueue(ok.direct);
                    }
                }
            }
        }
        public void DFS_Search(DirectoryInfo dir)
        {
            string[] files = Directory.GetFiles(dir.FullName, "*.*");
            if (urutan.Count == 0)
                urutan.Enqueue(new Folder("", dir.FullName));

            foreach (string file in files)
            {
                urutan.Enqueue(new Folder(dir.FullName, file));
                if (String.Compare(Path.GetFileName(file), namafile) == 0 && this.found == false)
                {
                    if (this.all_occur == false)
                    {
                        this.found = true;
                    }
                    solution.Enqueue(file);
                }
            }

            DirectoryInfo[] children = dir.GetDirectories();
            foreach (DirectoryInfo child in children)
            {
                urutan.Enqueue(new Folder(dir.FullName, child.FullName));
                this.DFS_Search(child);
            }
        }
    }
}

