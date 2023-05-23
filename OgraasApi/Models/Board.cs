	public class Board
	{

		public int Id { get; set; }
	  public Random random = new Random();
    [NotMapped]
		public Cell[,] Cells { get; set; } = new Cell[10,10];
        public List<Weed> Weeds = new()
        {
            new Maskros(),
            new Kardborre(),
            new Kardborre(),
            new Kvickrot(),
            new Kvickrot(),
            new Kvickrot(),
            new Kirskal(),
            new Kirskal(),
            new Kirskal(),
            new Kirskal()
        };

