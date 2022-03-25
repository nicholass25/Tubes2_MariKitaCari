namespace Folder
{
    public class folder
    {
        public string parent;
        public string direct;

        public folder()
        {
            this.parent = "";
            this.direct = "";
        }

        public folder(string parent, string direct)
        {
            this.parent = parent;
            this.direct = direct;
        }

        public folder(folder fl)
        {
            this.parent = fl.parent;
            this.direct = fl.direct;
        }

        public void setvalue(string parent, string direct)
        {
            this.parent = parent;
            this.direct = direct;
        }
    }
}

