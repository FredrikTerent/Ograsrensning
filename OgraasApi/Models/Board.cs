using System.ComponentModel.DataAnnotations.Schema;

namespace OgraasApi.Models
{
	public class Board
	{
		public int Id { get; set; }
		[NotMapped]
		public Cell[,] Cells { get; set; } = new Cell[10,10];

	}
}
