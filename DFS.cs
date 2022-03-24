using Folder;

namespace DFS_find
{
    public class DFS
    {
        public string FileName { get; set; } = string.Empty;
        public bool found;
        public bool Occur;
        public Queue<folder> urutan = new Queue<folder>();

        public DFS(string nama, bool Occur)
        {
            FileName = nama;
            found = false;
            this.Occur = Occur;
        }

        public void DFS_start(string Path)
        {
            this.DFS_Search(new DirectoryInfo(Path));
        }
        public void DFS_Search(DirectoryInfo directory)
        {
            string[] Files = Directory.GetFiles(directory.FullName, "*.*");
            if (urutan.Count == 0)
                urutan.Enqueue(new folder("", directory.FullName));

            foreach (string file in Files)
            {
                urutan.Enqueue(new folder(directory.FullName, file));
                if (found == false)
                {
                    if (Path.GetFileName(file) == FileName)
                    {
                        //Jika All_Occurance False, Pragram akan jalan terus
                        if (Occur == false)
                        {
                            System.Environment.Exit(0);
                        }
                    }
                }
            }

            DirectoryInfo[] children = directory.GetDirectories();
            if (found == false)
            {
                foreach (DirectoryInfo child in children)
                {
                    urutan.Enqueue(new folder(directory.FullName, child.FullName));
                    this.DFS_Search(child);
                }
            }
        }
    }
}

