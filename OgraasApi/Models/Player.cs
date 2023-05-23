namespace OgraasApi.Models
{
	public class Player
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public Board Board { get; set; }
        public bool isLoss { get { return Board.Weeds.All(x => x.IsWeeded); } }

        public Player(string name)
        {
            Name = name;
            Board = new();
        }
    }
}
