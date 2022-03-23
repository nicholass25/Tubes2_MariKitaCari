using Folder;

namespace DFS_find
{
    public class DFS
    {
        public string namafile { get; set; } = string.Empty;
        public bool found;
        public bool all_occur;
        public Queue<folder> urutan = new Queue<folder>();

        public DFS(string nama, bool all_occur)
        {
            namafile = nama;
            found = false;
            this.all_occur = all_occur;
        }

        public void DFS_start(string dirpath)
        {
            this.DFS_Search(new DirectoryInfo(dirpath));
        }
        public void DFS_Search(DirectoryInfo dir)
        {
            //Console.WriteLine(Path.GetFileName(dir.FullName)); // get just the name of folder
            //Console.WriteLine(dir.FullName); // get the full path of the folder
            string[] files = Directory.GetFiles(dir.FullName, "*.*");
            if (urutan.Count == 0)
                urutan.Enqueue(new folder("", dir.FullName));

            foreach (string file in files)
            {
                //Console.WriteLine(file);
                urutan.Enqueue(new folder(dir.FullName, file));
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
            if (found == false)
            {
                foreach (DirectoryInfo child in children)
                {
                    //Console.WriteLine(child.FullName);
                    urutan.Enqueue(new folder(dir.FullName, child.FullName));
                    this.DFS_Search(child);
                }
            }
        }
    }
}

