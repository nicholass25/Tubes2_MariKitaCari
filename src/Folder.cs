namespace MariKitaCari
{
    public class Folder
    {
        public string parent;
        public string direct;

        public Folder()
        {
            this.parent = "";
            this.direct = "";
        }

        public Folder(string parent, string direct)
        {
            this.parent = parent;
            this.direct = direct;
        }

        public Folder(Folder fl)
        {
            this.parent = fl.parent;
            this.direct = fl.direct;
        }

        public void SetValue(string parent, string direct)
        {
            this.parent = parent;
            this.direct = direct;
        }
    }
}

