using Folder;

namespace BFS_find
{
    class BFS
    {
        public string FileName { get; set; } = string.Empty;
        public bool Found;
        public bool Occur;
        public Queue<folder> BFS_show = new Queue<folder>();

        public BFS(string nama, bool Occur)
        {
            FileName = nama;
            Found = false;
            this.Occur = Occur;
        }

        public void BFS_search(string path)
        {
            // Queue buat alur BFS
            Queue<string> Visited = new Queue<string>();

            string[] folder = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

            BFS_show.Enqueue(new folder("", path));

            foreach (string fold in folder)
            {
                Visited.Enqueue(fold);
                BFS_show.Enqueue(new folder(path, fold));
            }

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                Visited.Enqueue(file);
                BFS_show.Enqueue(new folder(path, file));
            }

            while (Visited.Count > 0)
            {
                string now = Visited.Dequeue();
                FileAttributes trib = File.GetAttributes(now);

                //Folder
                if (trib.HasFlag(FileAttributes.Directory))
                {
                    string[] fold = Directory.GetDirectories(now, "*", SearchOption.TopDirectoryOnly);
                    foreach (string fd in fold)
                    {
                        Visited.Enqueue(fd);
                        BFS_show.Enqueue(new folder(now, fd));
                    }
                    string[] files_child = Directory.GetFiles(now, "*.*", SearchOption.TopDirectoryOnly);
                    foreach (string file in files_child)
                    {
                        Visited.Enqueue(file);
                        BFS_show.Enqueue(new folder(now, file));
                    }
                }
                //File
                else
                {
                    if (Found == false)
                    {
                        if (Path.GetFileName(now) == FileName)
                        {
                            //Jika All_Occurance False, Pragram akan jalan terus
                            if (Occur == false)
                            {
                                System.Environment.Exit(0);
                            }
                        }
                    }
                }
            }
        }
    }
}
