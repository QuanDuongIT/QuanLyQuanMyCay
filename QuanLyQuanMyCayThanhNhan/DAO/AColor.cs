using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DAO
{//https://www.google.com/search?q=google+color+picker&sca_esv=566202829&sxsrf=AM9HkKknQWRsTZ0pqBnZPBjoh0rpYLUXTQ%3A1695021399046&ei=V_kHZeW0AufK1e8P_NOXmAE&oq=google+color+&gs_lp=Egxnd3Mtd2l6LXNlcnAiDWdvb2dsZSBjb2xvciAqAggBMgcQIxiKBRgnMggQABiKBRiRAjIIEAAYigUYkQIyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAESMZ5UABYyVtwAHgBkAEAmAHPAaAByw-qAQYwLjEyLjK4AQPIAQD4AQHCAgQQIxgnwgIOEAAYigUYsQMYgwEYkQLCAg0QABiKBRixAxiDARhDwgITEC4YigUYsQMYgwEYxwEY0QMYQ8ICBxAAGIoFGEPCAhAQABiKBRixAxiDARgKGJECwgIIEAAYywEYgATCAgoQABjLARiABBgKwgIHEAAYgAQYCuIDBBgAIEGIBgE&sclient=gws-wiz-serp#cobssid=s

    public class AColor
    {
        //private static AColor instance;

        //public static AColor Instance
        //{
        //    get { if (instance == null) instance = new AColor(); return AColor.instance; }
        //    set => instance = value;
        //}
        private int a;
        private int b;
        private int c;

        public AColor() { }


        public AColor(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public Color ToColor()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(a)))), ((int)(((byte)(b)))), ((int)(((byte)(c)))));
        }

        
    }
    //public class AColor
    //{
    //    private AColor c1 = new AColor(255, 192, 128);
    //    private AColor c2 = new AColor(228, 241, 255);
    //    //private AColor c2 = new AColor(228, 241, 255);

    //    public AColor C1 { get => c1; set => c1 = value; }
    //    public AColor C2 { get => c2; set => c2 = value; }
    //}
}

