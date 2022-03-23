using Folder;

namespace BFS_find
{
    class BFS
    {
        public string namafile { get; set; } = string.Empty;
        public bool found;
        public bool all_occur;
        public Queue<folder> bfs_show = new Queue<folder>(); // Queue buat output (jaga jagabuat di graph)

        public BFS(string nama, bool all_occur)
        {
            namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }

        public void BFS_search(string dirpath)
        {
            Queue<string> dir_visited = new Queue<string>(); // Queue buat alur bfs


            //dir_visited.Enqueue(dirpath);
            string[] folder = Directory.GetDirectories(dirpath, "*", SearchOption.TopDirectoryOnly);

            bfs_show.Enqueue(new folder("", dirpath));

            foreach (string fold in folder)
            {
                //Console.WriteLine(fold);
                dir_visited.Enqueue(fold);
                bfs_show.Enqueue(new folder(dirpath, fold));
            }

            string[] files = Directory.GetFiles(dirpath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                //Console.WriteLine(file);
                dir_visited.Enqueue(file);
                bfs_show.Enqueue(new folder(dirpath, file));
            }

            while (dir_visited.Count > 0)
            {
                string now = dir_visited.Dequeue();
                //Console.WriteLine(now);
                FileAttributes trib = File.GetAttributes(now);


                if (trib.HasFlag(FileAttributes.Directory)) // its a folder
                {
                    string[] fold = Directory.GetDirectories(now, "*", SearchOption.TopDirectoryOnly);
                    foreach (string fd in fold)
                    {
                        dir_visited.Enqueue(fd);
                        //Console.WriteLine(fd);
                        bfs_show.Enqueue(new folder(now, fd));
                    }
                    string[] files_child = Directory.GetFiles(now, "*.*", SearchOption.TopDirectoryOnly);
                    foreach (string file in files_child)
                    {
                        dir_visited.Enqueue(file);
                        //Console.WriteLine(file);
                        bfs_show.Enqueue(new folder(now, file));
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
}
