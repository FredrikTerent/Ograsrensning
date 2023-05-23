namespace OgraasApi.Models
{
	public class Weed
	{
        public string Name { get; set; } = string.Empty;
        public int Width { get; set; }
        public int Hits { get; set; }
        public bool IsWeeded { get { return Hits >= Width; } }
    }

    public class Maskros : Weed
    {
        public Maskros()
        {
            Name = "Maskros";
            Width = 5;
        }
    }

    public class Kardborre : Weed
    {
        public Kardborre()
        {
            Name = "Kardborre";
            Width = 4;
        }
    }

    public class Kvickrot : Weed
    {
        public Kvickrot()
        {
            Name = "Kvickrot";
            Width = 3;
        }
    }

    public class Kirskal : Weed
    {
        public Kirskal()
        {
            Name = "Kirskal";
            Width = 2;
        }
    }
}
