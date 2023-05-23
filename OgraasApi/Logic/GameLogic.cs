using OgraasApi.Models;

namespace OgraasApi.Logic
{
	public class GameLogic
	{
		public Player player { get; set; }

		public void Pangakrut(Player player, int x, int y)
		{
			if (!player.Board.Cells[x, y].IsHit)
			{
				player.Board.Cells[x, y].IsHit = true;

				if (player.Board.Cells[x, y].IsOccupied)
				{
					if (player.Board.Cells[x, y].Weed != null)
					{
						player.Board.Cells[x, y].Weed.Hits += 1;
					}
				}
			}
			GameOver(player);
		}

		public bool GameOver(Player player) 
		{
			if (player.isLoss)
			{
				return true;
			} 
			else 
			{
				return false; 
			}
		}

		public void TestGame()
		{
			Player p = new Player("Pelle");
			for(int i = 0; i < 10; i++)
			{
                for (int j = 0; j < 10; j++)
                {
					Pangakrut(p, i, j);
                }
            }
			GameOver(p);
		}
	}
}
