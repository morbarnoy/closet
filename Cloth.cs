namespace MyClosett.Algorithm
{
    using Xamarin.Forms;

    public class Cloth
    {
        string color;
        string ocassion = "";
        string clothes = "";
        Image pic;
        public Cloth(string color1, string ocasion, string type, Image pic1)
        {
            this.color = color1;
            this.ocassion = ocasion;
            this.clothes = type;
            this.pic = pic1;
        }

        public string Color { get => color; set => color = value; }
        public string Ocassion { get => ocassion; set => ocassion = value; }
        public string type { get => clothes; set => clothes = value; }
        public Image picture { get => pic; set => pic = value; }
    }

    public class Shirt : Cloth
    {
        string type = "";
        public Shirt(string color, string ocasion, string typee, Image pic) : base(color, ocasion, typee, pic)
        {
            this.Type = typee;
        }

        public string Type { get => type; set => type = value; }
    }

    public class Bottom : Cloth
    {
        string type = ""; //skirt, jeans, טרנינג

        public Bottom(string color, string ocasion, string typee, Image pic) : base(color, ocasion, typee, pic)
        {
            this.Type = typee;
        }

        public string Type { get => type; set => type = value; }
    }


    public class FullBody : Cloth
    {
        string type = ""; //dress, suit
        public FullBody(string color, string ocasion, string typee, Image pic) : base(color, ocasion, typee, pic)
        {
            this.type = typee;
        }

        public string Type { get => type; set => type = value; }
    }

}
