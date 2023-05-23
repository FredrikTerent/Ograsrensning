using OgraasApi.Models;

namespace OgraasApi.Logic
{
	public class CreateBoard
	{
        public Player Player { get; set; }
        public Board Board { get; set; } = new();

        public void Pangakrut(int x, int y)
        {
            if (Board.Cells[x, y].IsOccupied)
            {
                Board.Cells[x, y].IsHit = true;

                if (Board.Cells[x, y].Weed != null)
                {

                }
            }
        }
    }
}
