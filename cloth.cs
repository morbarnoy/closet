using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_to_know_you
{
    using System;

    public class Cloth
    {
        int[] color = new int[3] { 0, 0, 0 };
        string ocassion = "";

        public Cloth(int r, int g, int b, string ocasion)
        {
            Color[0] = r;
            Color[1] = g;
            Color[2] = b;
            this.ocassion = ocasion;
        }

        public int[] Color { get => color; set => color = value; }
        public string Ocassion { get => ocassion; set => ocassion = value; }
    }

    public class Shirt : Cloth
    {
        int length = 1;

        public Shirt(int r, int g, int b, string ocasion, int lengthhh) : base(r, g, b, ocasion)
        {
            this.length = lengthhh;
        }

        public int Length { get => length; set => length = value; }
    }

    public class Bottom : Cloth
    {
        int length = 1; //1 = short 2 = long
        string type = ""; //skirt, jeans, טרנינג

        public Bottom(int r, int g, int b, string ocasion, int lengthhh, string typee) : base(r, g, b, ocasion)
        {
            this.length = lengthhh;
            this.type = typee;
        }

        public int Length { get => length; set => length = value; }
        public string Type { get => type; set => type = value; }
    }


    public class FullBody : Cloth
    {
        string type = ""; //dress, suit

        public FullBody(int r, int g, int b, string ocasion, string typee) : base(r, g, b, ocasion)
        {
            this.type = typee;
        }

        public string Type { get => type; set => type = value; }
    }
}
