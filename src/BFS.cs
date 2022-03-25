
using System.Collections.Generic;
using System.IO;

namespace MariKitaCari
{
    class BFS
    {
        public string Namafile { get; set; } = string.Empty;
        public bool found;
        public bool all_occur;
        public Queue<Folder> bfs_show = new Queue<Folder>();
        public Queue<string> solution = new Queue<string>();
        public Queue<string> jalur = new Queue<string>();

        public BFS(string nama, bool all_occur)
        {
            Namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }

        public void BFS_Search(string dirpath)
        {
            // Queue alur BFS
            Queue<string> dir_visited = new Queue<string>();

            //dir_visited.Enqueue(dirpath);
            string[] folder = Directory.GetDirectories(dirpath, "*", SearchOption.TopDirectoryOnly);

            bfs_show.Enqueue(new Folder("", dirpath));

            foreach (string fold in folder)
            {
                dir_visited.Enqueue(fold);
                bfs_show.Enqueue(new Folder(dirpath, fold));
            }

            string[] files = Directory.GetFiles(dirpath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                dir_visited.Enqueue(file);
                bfs_show.Enqueue(new Folder(dirpath, file));
            }

            while (dir_visited.Count > 0)
            {
                string now = dir_visited.Dequeue();
                FileAttributes trib = File.GetAttributes(now);

                // if folder
                if (trib.HasFlag(FileAttributes.Directory))
                {
                    string[] fold = Directory.GetDirectories(now, "*", SearchOption.TopDirectoryOnly);
                    foreach (string fd in fold)
                    {
                        dir_visited.Enqueue(fd);
                        bfs_show.Enqueue(new Folder(now, fd));
                    }
                    string[] files_child = Directory.GetFiles(now, "*.*", SearchOption.TopDirectoryOnly);
                    foreach (string file in files_child)
                    {
                        dir_visited.Enqueue(file);
                        bfs_show.Enqueue(new Folder(now, file));
                    }
                }
                else
                {
                    if (String.Compare(Path.GetFileName(now), namafile) == 0 && this.found == false)
                    {
                        if (this.all_occur == false)
                        {
                            this.found = true;
                        }
                        solution.Enqueue(now);
                    }
                }
            }
            foreach (string sol in this.solution)
            {
                foreach (file_folder ok in this.bfs_show)
                {
                    int coba =this.substring(ok.direct, sol);
                    if (coba != -1)
                    {
                        this.jalur.Enqueue(ok.direct);
                    }
                }
            }
        }
    }
}
