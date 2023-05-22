namespace OgraasApi.Models
{
	public class Player
	{
        public string Name { get; set; }
        public int Wins { get; set; }
        List<Cell> Cells { get; set; }
        Board Board { get; set; }
    }
}
