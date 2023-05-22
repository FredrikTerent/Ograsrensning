namespace OgraasApi.Models
{
	public class Player
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        List<Cell> Cells { get; set; } = new();
        Board Board { get; set; }
    }
}
